using BookTitleGenerator.Models;
using GetRandomFromList;
using RandomDateTimeNS;

namespace BookTitleGenerator.DataSeed;

public static class GenerateBooks
{
	static readonly Random _random = new();

	static readonly List<Func<string>> _bookTitlePatterns = new BookTitlePatterns().GetPatterns();
	static readonly List<Func<string>> _bookSubtitlePatterns = new BookSubtitlePatterns().GetPatterns();
	public static List<Book> Generate(int numberOfBooks, List<Author> authors)
	{
		if (authors.Count < 1) return [];

		List<Book> books = [];

		for (int i = 0; i < numberOfBooks; i++)
		{
			var book = new Book
			{
				Title = GenerateBookTitle(),
				Subtitle = GenerateSubtitle(1),
				PublicationDate = GeneratePublicationDate(),
				Authors = SelectAuthors(authors),
			};

			books.Add(book);
		}

		return books;
	}
	public static string? GenerateLastName(List<string> lastNames, bool noInitials = false, bool noHyphenation = false)
	{
		if (noInitials && noHyphenation)
		{
			return lastNames.PickOne();
		}

		var enoughInitials = noInitials;
		var initials = string.Empty;

		while (!enoughInitials)
		{
			if (_random.Next(2 + initials.Length) == 0)
			{
				initials += (char)('A' + _random.Next(26));
			}
			else enoughInitials = true;
		}

		if (initials.Length > 0) initials = string.Join(". ", initials.ToCharArray()) + ". ";

		var hyphenated = noHyphenation ? false : _random.Next(3) == 0;

		return initials + (hyphenated
			? lastNames.PickOne() + "-" + lastNames.PickOne()
			: lastNames.PickOne());
	}
	public static List<Author> GenerateAuthors(int numberOfAuthors, List<string> firstNames, List<string> lastNames)
	{
		if (numberOfAuthors < 1) return [];

		var authors = new List<Author>();

		for (int i = 0; i < numberOfAuthors; i++)
		{
			authors.Add(new Author
			{
				FirstName = firstNames.PickOne(),
				LastName = GenerateLastName(lastNames, false, false),
			});
		}

		return authors;
	}
	
	static List<Author> SelectAuthors(List<Author> authorsList)
	{
		var authorsToChooseFrom = authorsList.ToList();

		var authorsToReturn = new List<Author>();

		var i = 0;
		while (true)
		{
			if (_random.Next(i++ * 5) == 0)
			{
				var author = authorsToChooseFrom.PickOne();

				authorsToReturn.Add(author);

				authorsToChooseFrom.Remove(author);

				if (authorsToChooseFrom.Count < 1) break;
			}
			else break;
		}

		return authorsToReturn;
	}
	static DateOnly GeneratePublicationDate()
	{
		var offset = 0;

		var i = 1;
		while (true)
		{
			if (_random.Next(1, 10) >= i)
			{
				offset += _random.Next(365) * i * i * i;
				i++;
			}

			else break;
		}

		return DateOnly.FromDateTime(DateTime.Now).AddDays(offset * -1);
	}
	
	private static string GenerateBookTitle()
	{
		//return BookTitlePatterns.BookTitlePattern0();

		return _bookTitlePatterns.PickOne().Invoke();
	}
	private static string? GenerateSubtitle(int rarity = 3)
	{
		if (_random.Next(rarity) != 0) return null;

		//return BookSubtitlePatterns.BookSubtitlePattern7();

		return _bookSubtitlePatterns.PickOne().Invoke();
	}
}

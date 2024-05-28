using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTitleGenerator.Models;

public class Book
{
	public string Title { get; set; } = null!;
	public string? Subtitle { get; set; }
	public ICollection<Author> Authors { get; set; } = new List<Author>();
	public DateOnly PublicationDate { get; set; }

	public string Print()
	{
		var authorNames = Authors.Select(a => a.FirstName + " " + a.LastName).ToList();

		List<string> result = [
			Title,
			"\n",
			"- " + Subtitle,
			"\n\n",
			authorNames.Count < 2 ? "Author:" : "Authors:",
			"\n",
			.. authorNames.Select(a => "  " + a + (authorNames.Last() == a ? "" : "\n")),
			"\n\n",
			"Published " + PublicationDate,
		];

		return string.Concat(result);
	}
}

public static class BookExtensions
{
	public static string Print(this List<Book> books) =>
		string.Concat(books.Select(book => 
			$"\n------ Book {books.IndexOf(book) + 1} ------\n\n"
			+ book.Print() 
			+ "\n"));
}
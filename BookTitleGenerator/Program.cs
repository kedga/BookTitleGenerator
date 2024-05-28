using BookTitleGenerator;
using BookTitleGenerator.DataSeed;
using BookTitleGenerator.Models;

Console.WriteLine("Welcome to the book generator!");

var generateMoreBooks = true;

while (generateMoreBooks)
{
	var numberOfAuthors = ConsoleInput.GetInt("Enter the number of authors to generate:");

	var numberOfBooks = ConsoleInput.GetInt("Enter the number of books to generate:");

	var authors = GenerateBooks.GenerateAuthors(numberOfAuthors, Names.AllFirstNames, Names.AllLastNames);

	var books = GenerateBooks.Generate(numberOfBooks, authors);

	Console.WriteLine("\nYour generated books:");

	Console.WriteLine(books.Print());

	Console.WriteLine("------ End ------\n");

	if (ConsoleInput.GetBoolean("Export to json? (Y/N)"))
	{
		var filePath = $"books_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.json";

		await SaveToJson.SaveBooks(books, filePath);

		Console.WriteLine("Books saved to " + filePath);
	}

	generateMoreBooks = ConsoleInput.GetBoolean("Do you want to generate more books? (Y/N)");
}
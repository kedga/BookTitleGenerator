using BookTitleGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookTitleGenerator;

internal static class SaveToJson
{
	static readonly JsonSerializerOptions _jsonOptions = new()
	{
		WriteIndented = true
	};
	public static async Task SaveBooks(IEnumerable<Book> books, string filePath)
	{
		using FileStream fs = File.Create(filePath);

		await JsonSerializer.SerializeAsync(fs, books, _jsonOptions);
	}
}

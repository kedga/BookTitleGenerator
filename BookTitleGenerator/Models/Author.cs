using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookTitleGenerator.Models;

public class Author
{
	public string FirstName { get; set; } = null!;
	public string? LastName { get; set; }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookTitleGenerator;

internal static class ConsoleInput
{
	public static int GetInt(string prompt = "Please enter a number:")
	{
		var inputString = string.Empty;
		var number = 0;

		while (string.IsNullOrEmpty(inputString))
		{
			Console.WriteLine(prompt);
			inputString = Console.ReadLine();
			if (inputString is not null && inputString != "0" && Regex.IsMatch(inputString, @"^\d+$"))
			{
				number = int.Parse(inputString);
			}
			else
			{
				inputString = string.Empty;
			}
		}

		return number;
	}

	public static bool GetBoolean(string prompt = "Please enter Y or N:", string yesString = "Y", string noString = "N")
	{
		string inputString = string.Empty;

		while (string.IsNullOrEmpty(inputString))
		{
			Console.WriteLine(prompt);
			var input = Console.ReadLine()?.Trim().ToUpper();

			if (input is not null) inputString = input;

			if (inputString != yesString && inputString != noString)
			{
				inputString = string.Empty;
			}
		}

		return inputString == yesString;
	}
}

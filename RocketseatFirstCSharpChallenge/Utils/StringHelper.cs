using System.Text.RegularExpressions;

namespace Utils;

public static class StringHelper
{
    private const string NamePattern = @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$";
    private const string FullNamePattern = @"^([A-Za-zÀ-ÖØ-öø-ÿ]+(?:\s+[A-Za-zÀ-ÖØ-öø-ÿ]+)+)$";

    /// <summary>
    /// Prompts the user to input a valid text.
    /// </summary>
    /// <param name="label">A label describing what is being requested.</param>
    /// <returns>The validated value input.</returns>
    public static string ReadText(string label)
    {
        while (true)
        {
            Console.WriteLine($"{label}");
            string? text = Console.ReadLine();

            if (!IsAValidName(text))
                Console.WriteLine("Entrada inválida! Digite apenas letras e espaços.");
            else
                return text!;
        }
    }

    /// <summary>
    /// Checks if the entered name contains only letters and spaces.
    /// </summary>
    /// <param name="value">The name to be validated.</param>
    /// <returns>True if the input is valid; otherwise, false.</returns>
    public static bool IsAValidName(string? value)
    {
        return !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value.Trim(), NamePattern);
    }

    /// <summary>
    /// Checks if the concatenation of first and last name forms a valid full name.
    /// </summary>
    /// <param name="firstValue">The first name.</param>
    /// <param name="secondValue">The last name.</param>
    /// <returns>True if the full name is valid; otherwise, false.</returns>
    public static bool IsAValidFullName(string? firstValue, string? secondValue)
    {
        string value = $"{firstValue} {secondValue}";
        return !string.IsNullOrWhiteSpace(value) && Regex.IsMatch(value.Trim(), FullNamePattern);
    }

    /// <summary>
    /// Counts the number of characters in a given text, excluding whitespaces.
    /// </summary>
    /// <param name="text">The text to analyze.</param>
    /// <returns>The count of characters excluding whitespaces.</returns>
    public static int GetCharacterCount(string? text)
    {
        var count = 0;

        if (string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine("Texto em branco ou vazio.");
            return count;
        }

        foreach (var ch in text)
        {
            if (!char.IsWhiteSpace(ch))
                count++;
        }

        return count;
    }
}
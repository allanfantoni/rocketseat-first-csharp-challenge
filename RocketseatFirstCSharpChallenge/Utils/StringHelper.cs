using System.Text.RegularExpressions;

namespace Utils;

public static class StringHelper
{
    private const string NamePattern = @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$";
    private const string FullNamePattern = @"^([A-Za-zÀ-ÖØ-öø-ÿ]+(?:\s+[A-Za-zÀ-ÖØ-öø-ÿ]+)+)$";

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
    /// Prompts the user to input a valid name.
    /// </summary>
    /// <param name="valueType">A label describing what is being requested.</param>
    /// <returns>The validated string input.</returns>
    public static string ReadText(string valueType)
    {
        while (true)
        {
            Console.WriteLine($"Digite seu {valueType}:");
            string? text = Console.ReadLine();

            if (!IsAValidName(text))
                Console.WriteLine("Entrada inválida! Digite apenas letras e espaços.");
            else
                return text!;
        }
    }
}
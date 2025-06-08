using System.Globalization;

namespace Utils;

public static class DateHelper
{
    /// <summary>
    /// Attempts to parse a string into a <see cref="DateTime"/> using Brazilian Portuguese (pt-BR) culture.
    /// </summary>
    /// <param name="input">The string containing the date to parse.</param>
    /// <param name="result">When this method returns, contains the parsed <see cref="DateTime"/> value if the conversion succeeded, or <see cref="DateTime.MinValue"/> if it failed.</param>
    /// <returns><c>true</c> if the input string was successfully parsed; otherwise, <c>false</c>.</returns>
    public static bool TryParseDate(string input, out DateTime result) => DateTime.TryParse(input, new CultureInfo("pt-BR"), DateTimeStyles.None, out result);

    /// <summary>
    /// Returns a formatted string representation of the specified date, based on the selected format type.
    /// </summary>
    /// <param name="date">The <see cref="DateTime"/> value to format.</param>
    /// <param name="formatType">The format type to apply, specified by the <see cref="DateFormatType"/> enum.</param>
    /// <returns>A string containing the formatted date.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the specified <paramref name="formatType"/> is not supported.</exception>
    public static string FormatDate(DateTime date, DateFormatType formatType)
    {
        switch (formatType)
        {
            case DateFormatType.Completo:
                return date.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR"));
            case DateFormatType.Data:
                return date.ToString("dd/MM/yyyy");
            case DateFormatType.Hora:
                return date.ToString("HH:mm:ss");
            case DateFormatType.MesPorExtenso:
                return date.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
            default:
                throw new ArgumentOutOfRangeException(nameof(formatType));
        }
    }
}
namespace Utils;

public static class NumberHelper
{
    /// <summary>
    /// Reads and validates a double-precision floating-point number from user input.
    /// </summary>
    /// <param name="label">A label describing what is being requested.</param>
    /// <returns>The validated value input.</returns>
    public static double ReadDouble(string label)
    {
        while (true)
        {
            Console.WriteLine($"{label}");
            string? input = Console.ReadLine();

            if (!double.TryParse(input, out double result))
                Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
            else
                return result;
        }
    }

    /// <summary>
    /// Calculates and returns the sum of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="firstValue">The first number to be added.</param>
    /// <param name="secondValue">The second number to be added.</param>
    /// <returns>The sum of <paramref name="firstValue"/> and <paramref name="secondValue"/>.</returns>
    public static double Sum(double firstValue, double secondValue) => firstValue + secondValue;

    /// <summary>
    /// Calculates and returns the difference between two double-precision floating-point numbers.
    /// </summary>
    /// <param name="firstValue">The number from which to subtract.</param>
    /// <param name="secondValue">The number to subtract.</param>
    /// <returns>The difference between <paramref name="firstValue"/> and <paramref name="secondValue"/>.</returns>
    public static double Subtract(double firstValue, double secondValue) => firstValue - secondValue;

    /// <summary>
    /// Calculates and returns the product of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="firstValue">The first number to be multiplied.</param>
    /// <param name="secondValue">The second number to be multiplied.</param>
    /// <returns>The product of <paramref name="firstValue"/> and <paramref name="secondValue"/>.</returns>
    public static double Multiply(double firstValue, double secondValue) => firstValue * secondValue;

    /// <summary>
    /// Calculates and returns the quotient of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="firstValue">The dividend.</param>
    /// <param name="secondValue">The divisor.</param>
    /// <returns>An object containing the result, message, and status of the operation.</returns>
    public static DivisionResult DivideSafe(double firstValue, double secondValue)
    {
        if (secondValue == 0)
            return new DivisionResult(false, 0, "Divisão por zero não é permitida.");

        double result = firstValue / secondValue;
        return new DivisionResult(true, result, "Divisão realizada com sucesso.");
    }

    /// <summary>
    /// Calculates and returns the average of two double-precision floating-point numbers.
    /// </summary>
    /// <param name="firstValue">The first number.</param>
    /// <param name="secondValue">The second number.</param>
    /// <returns>The average of <paramref name="firstValue"/> and <paramref name="secondValue"/>.</returns>
    public static double Average(double firstValue, double secondValue) => Sum(firstValue, secondValue) / 2.0;
}
using Utils;

namespace MathematicalOperations;

internal class Program
{
    static void Main(string[] args)
    {
        Run();

        ConsoleHelper.PromptToExit();
    }

    private static void Run()
    {
        var firstNumber = NumberHelper.ReadDouble("Digite primeiro número:");
        var secondNumber = NumberHelper.ReadDouble("Digite segundo número:");

        PerformCalculations(firstNumber, secondNumber);
    }

    private static void PerformCalculations(double firstNumber, double secondNumber)
    {
        var sum = NumberHelper.Sum(firstNumber, secondNumber);
        var difference = NumberHelper.Subtract(firstNumber, secondNumber);
        var product = NumberHelper.Multiply(firstNumber, secondNumber);
        var quotient = NumberHelper.DivideSafe(firstNumber, secondNumber);
        var average = NumberHelper.Average(firstNumber, secondNumber);

        DisplayResults(firstNumber, secondNumber, sum, difference, product, quotient, average);
    }

    private static void DisplayResults(double firstNumber, double secondNumber, double sum, double difference, double product, DivisionResult quotient, double average)
    {
        Console.WriteLine($"A soma de {firstNumber} e {secondNumber} é: {sum}");
        Console.WriteLine($"A diferença entre {firstNumber} e {secondNumber} é: {difference}");
        Console.WriteLine($"O produto de {firstNumber} e {secondNumber} é: {product}");

        if (!quotient.Success)
            Console.WriteLine(quotient.Message);
        else
            Console.WriteLine($"O quociente de {firstNumber} e {secondNumber} é: {quotient.Result}");

        Console.WriteLine($"A média entre {firstNumber} e {secondNumber} é: {average}");
    }
}

using Utils;

namespace LicensePlateValidator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a placa de um veículo e o programa retornará se é verdadeira ou falsa:");
        var text = Console.ReadLine();

        if (!StringHelper.IsAValidLicensePlate(text))
            Console.WriteLine("Falso");
        else
            Console.WriteLine("Verdadeiro");

        ConsoleHelper.PromptToExit();
    }
}
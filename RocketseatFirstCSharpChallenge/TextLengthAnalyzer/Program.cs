using Utils;

namespace TextLengthAnalyzer;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um texto para analisar o comprimento:");
        var text = Console.ReadLine();

        var count = StringHelper.GetCharacterCount(text);

        if (count > 0)
            Console.WriteLine($"O tamanho do texto digitado é {count}, excluindo espaços.");

        ConsoleHelper.PromptToExit();
    }
}
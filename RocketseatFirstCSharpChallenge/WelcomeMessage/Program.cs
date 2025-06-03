using Utils;

namespace WelcomeMessage;

internal class Program
{
    static void Main(string[] args)
    {
        var name = StringHelper.ReadText("Digite seu nome:");

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo");

        ConsoleHelper.PromptToExit();
    }
}
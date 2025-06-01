using Utils;

namespace FirstAndLastNameConcatenated;

internal class Program
{
    static void Main(string[] args)
    {
        var name = StringHelper.ReadText("nome");
        var lastName = StringHelper.ReadText("sobrenome");

        Console.WriteLine($"Seu nome completo é: {name} {lastName}");

        ConsoleHelper.PromptToExit();
    }
}
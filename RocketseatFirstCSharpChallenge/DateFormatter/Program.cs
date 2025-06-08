using System.Globalization;
using Utils;

namespace DateFormatter;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        Run();

        ConsoleHelper.PromptToExit();
    }

    private static void Run()
    {
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa (ou pressione Enter para usar a data atual):");
        string? input = Console.ReadLine();

        if (!TryGetValidDateFromInput(input, out DateTime data))
            return;

        DisplayFormattedDateOutputs(data);
    }

    private static bool TryGetValidDateFromInput(string? input, out DateTime data)
    {
        if (string.IsNullOrWhiteSpace(input))
            data = DateTime.Now;
        else if (DateHelper.TryParseDate(input, out data))
            Console.WriteLine("Data válida inserida.\n");
        else
        {
            Console.WriteLine("Data inválida. Encerrando o programa.");
            ConsoleHelper.PromptToExit();
            return false;
        }

        return true;
    }

    private static void DisplayFormattedDateOutputs(DateTime data)
    {
        Console.WriteLine("Formatos solicitados:");
        Console.WriteLine("1. Formato completo: " + DateHelper.FormatDate(data, DateFormatType.Completo));
        Console.WriteLine("2. Apenas a data: " + DateHelper.FormatDate(data, DateFormatType.Data));
        Console.WriteLine("3. Apenas a hora: " + DateHelper.FormatDate(data, DateFormatType.Hora));
        Console.WriteLine("4. Mês por extenso: " + DateHelper.FormatDate(data, DateFormatType.MesPorExtenso));
    }
}
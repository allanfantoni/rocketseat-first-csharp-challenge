namespace Utils;

public static class ConsoleHelper
{
    /// <summary>
    /// Returns a message to close the console window.
    /// </summary>
    public static void PromptToExit()
    {
        Console.WriteLine("Press any key to close this window . . .");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
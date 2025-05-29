namespace WelcomeMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            var name = Console.ReadLine();
            Console.WriteLine($"Olá, {name}! Seja muito bem-vindo");

            Console.WriteLine("Press any key to close this window . . .");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            Random random = new Random();

            random.GeneraNumero("double", 2, 6);
            Console.WriteLine(random.GeneraNumero("double", 2, 6));
        }
    }
}

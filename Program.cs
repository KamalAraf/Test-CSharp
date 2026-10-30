namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            Funzioni funzioni = new Funzioni();

            Essere essere1 = new Essere("Test", 500, 10);
            Essere essere2 = new Essere();

            for (int i = 0; i < 10; i++)
            {
                essere2.Attacca(ref essere1);
            }
        }
    }
}

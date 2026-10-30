namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            Funzioni funzioni = new Funzioni();

            ETurni test1 = new ETurni("test1", 500, 50);
            ETurni test2 = new ETurni("test2", 800, 40);

            ETurni[] A = [test1];
            ETurni[] B = [test2];

            Turni arena = new Turni(A, B);
            Console.WriteLine(arena.inizio);

            arena.Stampa();
            Console.WriteLine();
            Console.WriteLine(arena.ToString());

            // Da fixare ETurni.cs, Funzioni.cs nel controllo se esiste in modo da usare ref generale
        }
    }
}

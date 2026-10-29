namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            Punto punto = new Punto(2, 4);
            Matrice matrice = new Matrice();

            matrice.Inserisci(punto, 6);

            matrice.Stampa();
        }
    }
}

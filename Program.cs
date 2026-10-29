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
            matrice.StampaElemento(punto);

            // matrice.StampaElemento(6, 5); // Test dell'errore

            matrice.Inserisci(-4, 3, 2);
        }
    }
}

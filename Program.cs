namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrice matrice = new Matrice(5, 5);
            // int[,] matrice = new int[5, 5];

            int contatore = 0;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    matrice.Inserisci(j, i, contatore);
                    contatore++;
                }
            }

            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrice[i, j]);
                    if (j != 4)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine(matrice[4, 1]);
            */

            matrice.Stampa();
        }
    }
}

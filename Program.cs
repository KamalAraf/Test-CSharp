namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrice = new int[5, 5];
            int contatore = 0;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    matrice[i, j] = contatore;
                    contatore++;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.Write("| ");
            }
        }
    }
}

using Test_CSharp.funzioni;
using Test_CSharp.test.tools;

namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            int[] numeri = [7, 6, 5, 4, 3, 2];

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.Write(numeri[i] + " ");
            }
            Console.WriteLine();

            Sort.SelectionSort(numeri);

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.Write(numeri[i] + " ");
            }

        }
    }
}

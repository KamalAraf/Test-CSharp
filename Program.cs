using Test_CSharp.funzioni;

namespace Test_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test-CSharp");
            Console.WriteLine();

            int[] array = [1, 2, 3, 6, 4, 2, 8, 5, 1, 7];

            Console.WriteLine(Search.LinearSearch(array, 8));
            Sort.BubbleSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(Search.BinarySearch(array, 8));
        }
    }
}

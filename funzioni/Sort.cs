using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.funzioni
{
    public class Sort // Classe per i metodi sorting
    {
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min]) < 0) // metodo per comparare senza tipi, se <, -; se =, +; se >, +
                    {
                        min = j;
                    }
                }

                T temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
    }
}

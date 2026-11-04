using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.funzioni
{
    public class Search
    {
        public static int LinearSearch<T>(T[] array, T target) where T : IComparable // Funziona per array non ordinati
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(target) == 0)
                {
                    return i;
                }
            }
            return -1; // Condizione di errore
        }
    }
}

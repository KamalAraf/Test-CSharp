using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test_CSharp.funzioni
{
    public class Search
    {
        public static int LinearSearch<T>(T[] array, T target) where T : IComparable // Funziona anche per array non ordinati
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

        public static int BinarySearch<T>(T[] array, T target) where T : IComparable // Funziona solo per array ordinati
        {
            int start = 0;
            int end = array.Length - 1;

            while(start <= end)
            {
                if (array[(int)((start + end) / 2)].CompareTo(target) == 0)
                {
                    return (int)((start + end) / 2);
                } 
                else if (array[(int)((start + end) / 2)].CompareTo(target) > 0)
                {
                    end = (int)((start + end) / 2) - 1;
                } else
                {
                    start = (int)((start + end) / 2) + 1;
                }
            }
            return -1; // Condizione di errore
        }
    }
}

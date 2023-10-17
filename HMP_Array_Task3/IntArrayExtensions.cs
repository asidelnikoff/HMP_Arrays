using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMP_Arrays_Task3
{
    public static class IntArrayExtensions
    {
        static Random rnd = new Random();
        static int MAX_VALUE = 1000;
        static int MIN_VALUE = -1000;
        public static void InitializeWithRandomNumbers(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(MIN_VALUE, MAX_VALUE + 1);
        }

        public static void Sort(this int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;
            int q = Partition(array, left, right);
            QuickSort(array, left, q - 1);
            QuickSort(array, q + 1, right);
        }

        static int Partition(int[] array, int left, int right)
        {
            int q = left;
            for (int i = left; i < right; i++)
            {
                if (array[i] < array[right])
                {
                    int current = array[i];
                    array[i] = array[q];
                    array[q] = current;
                    q++;
                }
            }
            int ourElement = array[right];
            array[right] = array[q];
            array[q] = ourElement;
            return q;
        }
    }
}

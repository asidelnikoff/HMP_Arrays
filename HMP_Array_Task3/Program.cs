using HMP_Arrays_Task3;
using System.Runtime.CompilerServices;

namespace HMP_Array_Task3
{
    /*Реализовать проект – операций над массивами, каждая подзадача реализуется
            в виде отдельной функции:
            - инициализация массива с помощью датчика случайных чисел. Размер массива
            определяет пользователь
            - сложение массивов поэлементно в случае равенства длины массивов
            - умножение массива на число осуществляется поэлементно
            - поиск общих значений двух массивов (длины массивов могут быть разные)
            - печать значений массива
            - упорядочивание значений массива по убыванию (без использования стандартных
            - поиск min, max значение в массиве, среднего значения всех значений массива (без
            использования стандартных функций)*/
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            array.InitializeWithRandomNumbers();
            Print(array);

            var sumOfArrays = GetElementByElementSumOfArrays(new int[] { 12, 42, 54 }, new int[] { 439, 54, 3212 });
            Print(sumOfArrays);

            MultiplyArrayByNumber(array, 10);
            Print(array);

            var intersection = GetIntersectionOfArrays(new int[] { 1, 4, 424, 86, 23, 7, 23, 9, 23 },
                                                         new int[] { 543, 1, 64, 435, 9, 34, 9, 431, 23 });
            Print(intersection);

            array.Sort();
            Print(array);

            var min_max_average = GetMinMaxAndAverage(new int[] { 1, 5, 65, 25, 9, 5210, 540286, 848, 964, 3, 53893 });
            Console.WriteLine($"Max = {min_max_average.max}\n" +
                $"Min = {min_max_average.min}\n" +
                $"Average = {min_max_average.average}");

        }

        static int[] GetElementByElementSumOfArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays should be of equal size");

            int size = array1.Length;
            int[] resultArray = new int[size];

            for(int i = 0; i < size; i++)
                resultArray[i] = array1[i] + array2[i];

            return resultArray;
        }

        static void MultiplyArrayByNumber(int[] array, int multiplier)
        {
            int size = array.Length;

            for (int i = 0; i < size; i++)
                array[i] *= multiplier;
        }

        static int[] GetIntersectionOfArrays(int[] array1, int[] array2)
        {
            Dictionary<int, int> countElements = new();
            foreach (var it in array1)
                if (countElements.ContainsKey(it))
                    countElements[it]++;
                else
                    countElements.Add(it, 1);

            List<int> result = new();
            foreach(var it in array2)
                if(countElements.ContainsKey(it) && countElements[it] > 0)
                {
                    result.Add(it);
                    countElements[it]--;
                }

            return result.ToArray();
        }

        static void Print(int[] array)
        {
            Console.WriteLine(String.Join(' ', array));
        }

        static (int min, int max, float average) GetMinMaxAndAverage(int[] array)
        {
            int max = int.MinValue, min = int.MaxValue;
            float average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
                average += array[i];
            }

            average /= (float)array.Length;

            return (min, max, average);
        }
    }
}
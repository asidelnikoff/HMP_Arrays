using System;

namespace VMP_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        // Дан одномерный массив числовых значений, насчитывающий N элементов.
        // Вставить группу из M новых элементов, начиная с позиции K.
        static void Task1()
        {
            var array = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            var itemsToAdd = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            int K = int.Parse(Console.ReadLine());

            AddElementsToSourceFromPosition(ref array, itemsToAdd, K);

            Console.WriteLine(String.Join(' ', array));
        }
        static void AddElementsToSourceFromPosition(ref int[] sourceArray, int[] elementsToAdd, int startPosition)
        {
            int N = sourceArray.Length;
            int M = elementsToAdd.Length;
            int K = startPosition;

            if (K >= N || K < 0)
                return;

            Array.Resize(ref sourceArray, N + M);

            for (int i = K; i < N; i++)
                sourceArray[N + i - K + 1] = sourceArray[i];

            for (int i = 0; i < M; i++)
                sourceArray[K + i] = elementsToAdd[i];
        }


    }
}
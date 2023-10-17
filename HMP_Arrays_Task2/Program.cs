namespace HMP_Arrays_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        // Дан одномерный массив числовых значений, насчитывающий N элементов.
        // Поменять местами первую и вторую половины массива без использования
        // дополнительных массивов
        static void Task2()
        {
            var array = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();

            SwapHalfsOfArray(ref array);

            Console.WriteLine(String.Join(' ', array));
        }

        static void SwapHalfsOfArray(ref int[] array)
        {
            int N = array.Length;
            int middle = N / 2;

            for (int i = 0; i < middle; i++)
            {
                int secondHalfIndex = i + middle + N % 2;
                (array[i], array[secondHalfIndex]) = (array[secondHalfIndex], array[i]);
            }
        }
    }
}
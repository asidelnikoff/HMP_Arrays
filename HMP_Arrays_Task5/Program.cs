namespace HMP_Arrays_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 30;
            int minValue = -10;
            Random rnd = new Random();
            long rowSize = 1000;
            long arraySize = (long)rowSize*(long)rowSize;
            long rows = arraySize / rowSize;
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];

            for(long i = 0; i < arraySize; i++)
            {
                array1[i] = rnd.Next(minValue, maxValue + 1);
                array2[i] = rnd.Next(minValue, maxValue + 1);
            }

            Console.WriteLine(String.Join(' ', array1));
            Console.WriteLine(String.Join(' ', array2));

            int[] result = new int[arraySize];

            for(long i = 0; i < rows; i++)
            {
                for(long j = 0; j < rowSize; j++)
                {
                    int elementFromArray1 = array1[j + i*rowSize];
                    for(long k = 0; k < rowSize; k++)
                    {
                        int elementFromArray2 = array2[k + j * rowSize];
                        int r = elementFromArray1 * elementFromArray2;
                        result[i*rowSize + k] += r;
                    }
                }
            }

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
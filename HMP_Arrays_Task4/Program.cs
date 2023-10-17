namespace HMP_Arrays_Task4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Task4();
        }

        static void Task4()
        {
            var inp = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
            int N = inp[0], M = inp[1];

            var map = new int[N][];

            for (int i = 0; i < N; i++)
            {
                var inpLine = Console.ReadLine().Split(' ').Select(it => int.Parse(it)).ToArray();
                map[i] = inpLine;
            }

            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(FindRowWithFreeKPlaces(N, M, map, k));
        }

        static int FindRowWithFreeKPlaces(int N, int M, int[][] map, int k)
        {
            for (int i = 0; i < N; i++)
            {
                int countContiniousZeros = 0;
                for (int j = 0; j < M; j++)
                {
                    if (map[i][j] == 0)
                    {
                        countContiniousZeros++;
                        if (countContiniousZeros >= k)
                            return i + 1;
                    }
                    else
                        countContiniousZeros = 0;
                }
            }

            return 0;
        }
    }
}
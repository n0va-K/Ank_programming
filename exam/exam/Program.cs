using System;

namespace exam
{
    internal class Program
    {
        static void Main()
        {
            const int N = 100000000;
            long[] sequence = new long[N+1];
            sequence[1] = 1;

            for (int i = 1; 2 * i <= N; i++)
            {
                sequence[2 * i] = 2 * i;
                if (2 * i + 1 <= N)
                {
                    sequence[2 * i + 1] = sequence[i] - 3 * sequence[i + 1];
                }
            }

            long sum = CalculateSum(sequence, N);
            Console.WriteLine($"Сумма первых {N} членов последовательности: {sum}");
            Console.ReadKey();
        }

        static long CalculateSum(long[] sequence, int N)
        {
            long sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += sequence[i];
            }
            return sum;
        }
    }

}




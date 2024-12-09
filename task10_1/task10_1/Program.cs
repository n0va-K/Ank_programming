using System;

namespace task10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            if (!TryInputNumber("Введите значение n (натуральное число): ", out n) || n < 0)
            {
                Console.WriteLine("n должно быть натуральным числом больше 0.");
                Console.ReadKey();
                return;
            }

            var k = 0;
            if (!TryInputNumber("Введите значение k (натуральное число): ", out k) || k < 0)
            {
                Console.WriteLine("k должно быть натуральным числом больше 0.");
                Console.ReadKey();
                return;
            }

            double sum = CalculateSum(n, k);
            Console.WriteLine($"Сумма = {sum}");
            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return int.TryParse(input, out number);
        }

        static double CalculateSum(int n, int k)
        {
            double sum = 1;
            double currentTerm = 1;

            for (int i = 1; i <= k; i++)
            {
                currentTerm /= n;
                sum += currentTerm;
            }

            return sum;
        }
    }
}


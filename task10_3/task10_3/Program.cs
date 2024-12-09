using System;

namespace task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var count = 0;
            int number;
            double average = 0;

            do
            {
                if (!TryInputNumber("Введите очередной член последовательности", out number))
                {
                    Console.ReadKey();
                    return;
                }

                if (number != 0)
                {
                    sum += number;
                    count++;
                }


            } while (number != 0);

            if (count > 0)
            {
                average = (double)sum / count;
            }

            Console.WriteLine($"Среднее арифметическое чисел последовательности: {average}");

            Console.ReadKey();
        }

        static bool TryInputNumber(string message, out int number)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            return true;
        }
    }
}

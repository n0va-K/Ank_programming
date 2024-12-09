using System;

namespace task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!TryInputNumber("Введите количество чисел в последовательности: ", out int n))
            {
                Console.ReadKey();
                return;
            }

            if (n < 1)
            {
                Console.WriteLine("Количество чисел должно быть > 0");
                Console.ReadKey();
                return;
            }

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int number;
                Console.WriteLine($"Введите значение {i + 1}-го числа последовательности: ");
                while (!int.TryParse( Console.ReadLine(), out number ) )
                {
                    Console.WriteLine("Введите действительное число");
                }

                int sign = (i % 2 == 0) ? 1 : -1;
                result += sign * number;

            }

            Console.WriteLine($"Результат выражения = {result}");
            Console.ReadKey();

        }
            static bool TryInputNumber(string message, out int number)
            {
                Console.Write(message);
                var input = Console.ReadLine();
                return int.TryParse(input, out number);
            }
    }
}

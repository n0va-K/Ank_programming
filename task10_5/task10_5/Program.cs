using System;

namespace Task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            if (!int.TryParse(Console.ReadLine(), out int number) || number < 1)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            Console.Write($"Наименьший делитель {number}, отличный от 1: ");

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{i}");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics;

namespace Task10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (!TryInputNumber("Введите число a", out int a))
            {
                Console.ReadKey();
                return;
            }

            if (a < 1)
            {
                Console.WriteLine("Число a должно быть натуральным");
                Console.ReadKey();
                return;
            }

            if (!TryInputNumber("Введите число b", out int b))
            {
                Console.ReadKey();
                return;
            }

            if (b < 1)
            {
                Console.WriteLine("Число b должно быть натуральным");
                Console.ReadKey();
                return;
            }

            if (b < a)
            {
                Console.WriteLine("Число b должно быть больше, чем число a");
                Console.ReadKey();
                return;
            }

            int sum = 0;
            int maxSumNumber = 0;

            for (int num = 0; num <= b; num++)
            {
                    int counter = 0;
                    for (int i = 2; i < num; i++) 
                    { 
                        if (num % i == 0) 
                        { 
                            counter += i;
                        } 
                    }

                    if (counter > sum)
                    {
                        sum = counter;
                        maxSumNumber = num;
                    }
            }

            Console.Write($"Число с наибольшей суммой собственных делителей: {maxSumNumber}");
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
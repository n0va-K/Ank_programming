using System;

namespace task07._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = GetNumber("n");

            if (IsStatementTrue(n))
                Console.WriteLine("Число кратно двум или трём");
            else
                Console.WriteLine("Число не кратно двум и трём");

            Console.ReadKey();
        }

        static bool IsStatementTrue(int n)
        {
            return n % 2 == 0 || n % 3 == 0;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return
            int.Parse(Console.ReadLine());
        }
    }
}

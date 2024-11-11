using System;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента функции: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine($"f({x})={MyFunction(x)}");

            Console.ReadKey();
        }

        static double MyFunction(double x)
        {
            if (x <= 0)
                return 0;
            else if (x > 1)
                return Math.Pow(x, 2);

            return x;
        }
    }
}

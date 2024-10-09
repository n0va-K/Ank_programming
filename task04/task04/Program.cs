using System;

namespace task04
{
    class Program
    {
        static double f(double x)
        {
            return (x + (2 + Math.Cos(x)) / Math.Pow(x, 2)) / (x + (1 / Math.Sqrt(Math.Pow(x, 2) + 10)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            string t = Console.ReadLine();

            double x = Double.Parse(t);
            Console.WriteLine("Результат y=f(x): " + f(x));

            Console.ReadKey();
        }
    }
}

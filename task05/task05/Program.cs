using System;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(5, 7) * F(12, 8) * F(31, 2);
            Console.WriteLine($"x = {x:F3}");
            Console.ReadKey();
        }

        static double F(double a, double b)
        {
            return (a + Math.Sqrt(a)) / (b + Math.Sqrt(b));
        }
    }
}

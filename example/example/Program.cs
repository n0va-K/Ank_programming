using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слагаемое");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе слагаемое");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма чисел равна " + (x+y));

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: ");

            int i = int.Parse(Console.ReadLine());

            int a = i / 100;
            int b = (i/10)%10;
            int c = i % 10;
            int d = c*100 + b*10 + a;

            Console.WriteLine("Число с противоположным порядком цифр = "+d);

            Console.ReadKey();

        }
    }
}

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

            int i = Convert.ToInt32(Console.ReadLine());

            int a = i / 100;
            int b = ((i - (i / 100) * 100)) / 10;
            int c = i % 10;

            Console.WriteLine("Число с противоположным порядком цифр = "+c+b+a);

            Console.ReadKey();

        }
    }
}

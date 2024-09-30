using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус: ");

            double r = Convert.ToDouble(Console.ReadLine());
            double d = 2 * Math.PI * r;
            double s = Math.PI * Math.Pow(r, 2);

            Console.Write("Длина окружности = " + Math.Round(d, 2) + "\n" + "Площадь круга = " + Math.Round(s, 2));

            Console.ReadKey();
        }
    }
}

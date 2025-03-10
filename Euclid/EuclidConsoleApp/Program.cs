using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclid;

namespace EuclidConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point();
            p.X = 1;
            p.Y = 2;
            PrintPoint(p);

            var q = new Point() { X = -1, Y = 3 };
            PrintPoint(q);

            var r = new Point(5, 6);
            PrintPoint(r);

            var segment = new Segment(p, q);
            Console.WriteLine(segment.Length);

            var p1 = new Point(p.X, p.Y);

            var s = Geometry.CreateSegment(p, p1);

            Console.ReadKey();
        }

        static void PrintPoint(Point p)
        {
            Console.WriteLine($"Точка ({p.X}; {p.Y})");
        }
    }
}

using System;

namespace task06._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вертикаль");

            var s = "вертикаль";
            var word1 = s
                .Remove(5)
                .Remove(0, 3);

            word1 += s.Substring(2, 1);

            Console.WriteLine(word1);

            var word2 = s
                .Remove(2);

            word2 += s.Substring(3, 1);
            word2 += s.Substring(5, 2);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
    }
}

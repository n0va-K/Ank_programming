using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первого члена геометрической прогрессии");

            if(!double.TryParse(Console.ReadLine(), out double p))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
            }

            Console.WriteLine("Введите значение знаменателя геометрической прогрессии");

            if (!double.TryParse(Console.ReadLine(), out double q))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
            }

            Console.WriteLine("Введите значение множителя k");

            if (!double.TryParse(Console.ReadLine(), out double k))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
            }

            var numbers = new double[20];
            
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = p * Math.Pow(q, i);

            }

            Console.WriteLine("Геометрическая прогрессия из 20 элементов: ");
            PrintArray(numbers);

            Console.WriteLine("Каждый элемент геометрической прогрессии в квадрате: ");
            SquareArray(numbers);

            Console.WriteLine("Среднее геометрическое массива: ");
            GeometricMeanOfArray(numbers);

            Console.WriteLine("Массив, умноженный на k: ");
            PrintArray(MultiplyArray(numbers, k));

            Console.ReadKey();

        }

        static void PrintArray(double[] array)
        {
            foreach (var element in array)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void SquareArray(double[] array)
        {
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i<array.Length; i++)
            {
                array[i] = Math.Pow(array[i], 2);
            }

            foreach (var element in array)
                Console.Write($"{element}, ");

            Console.WriteLine("\b\b ");
        }

        static void GeometricMeanOfArray (double [] array)
        {
            if (array == null || array.Length == 0)
                return;

            double product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            Console.Write(Math.Sqrt(product));
        }

        static double[] MultiplyArray (double [] array, double k)
        {
            if (array.Length == 0)
                return new double[0];

            double[] result = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * k;
            }

            return result;

        }
    }
}

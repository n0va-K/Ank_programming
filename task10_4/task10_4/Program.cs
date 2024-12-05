using System;

namespace task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число, все цифры которого должны отличаться:");

            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Число не натуральное");

                return;
            }

            if (!int.TryParse(Console.ReadLine(), out number) || RepeatedDigits(number))
            {
                Console.WriteLine("Цифры в числе повторяются");

                return;
            }

            int maxDigit = 0;
            int minDigit = 0;
            int maxDigitPosition = 0;
            int minDigitPosition = 0;
            var temp = number;
            int maxPosition;
            int minPosition;
            int counter = 0;
            int digit;

            while (temp > 0)
            {
                digit = temp % 10;
                temp /= 10;

                if (counter == 0)
                {
                    maxDigit = digit;
                    minDigit = digit;
                }

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    maxDigitPosition = counter;
                }

                if (digit < minDigit)
                {
                    minDigit = digit;
                    minDigitPosition = counter;
                }

                counter++;
            }

            maxPosition = counter - maxDigitPosition;
            minPosition = counter - minDigitPosition;
            Console.WriteLine($"Позиция наибольшей цифры {maxDigit} в числе {number} равна {maxPosition}");
            Console.WriteLine($"Позиция наименьшей цифры {minDigit} в числе {number} равна {minPosition}");

            Console.ReadKey();
        }

        static bool RepeatedDigits(int number)
        {
            int seenDigits = 0;
            while (number > 0)
            {
                int digit = number % 10;
                int metches = 1 << digit;

                if ((seenDigits & metches) != 0)
                {
                    return true; 
                }
                seenDigits |= metches;
                number /= 10;
            }
            return false; 
        }
    }
}

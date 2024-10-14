﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке: ");
            var text = Console.ReadLine();

            Console.WriteLine("Транслитерированный текст: ");
            Console.WriteLine(Translate(text));

            Console.ReadKey();
        }

        static string Translate(string s)
        {
            return s
                .ToUpper()
                .Replace(" ", " ")
                .Replace("A", "A")
                .Replace("Б", "B")
                .Replace("В", "V")
                .Replace("Г", "G")
                .Replace("Д", "D")
                .Replace("Е", "E")
                .Replace("Ё", "E")
                .Replace("Ж", "ZH")
                .Replace("З", "Z")
                .Replace("И", "I")
                .Replace("Й", "I")
                .Replace("К", "K")
                .Replace("Л", "L")
                .Replace("М", "M")
                .Replace("Н", "N")
                .Replace("О", "O")
                .Replace("П", "P")
                .Replace("Р", "R")
                .Replace("С", "S")
                .Replace("Т", "T")
                .Replace("У", "U")
                .Replace("Ф", "F")
                .Replace("Х", "KH")
                .Replace("Ц", "TS")
                .Replace("Ч", "CH")
                .Replace("Ш", "SH")
                .Replace("Щ", "SHCH")
                .Replace("Ъ", "IE")
                .Replace("Ь", "")
                .Replace("Э", "E")
                .Replace("Ы", "Y")
                .Replace("Ю", "IU")
                .Replace("Я", "IA");
        }
    }
}

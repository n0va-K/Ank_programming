using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Узник");

            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Сижу за решеткой в темнице сырой.\r\nВскормленный в неволе орел молодой,\r\nМой грустный товарищ, махая крылом,\r\nКровавую пищу клюет под окном,\r\nКлюет, и бросает, и смотрит в окно,\r\nКак будто со мною задумал одно.\r\nЗовет меня взглядом и криком своим\r\nИ вымолвить хочет: «Давай улетим!\r\nМы вольные птицы; пора, брат, пора!\r\nТуда, где за тучей белеет гора,\r\nТуда, где синеют морские края,\r\nТуда, где гуляем лишь ветер… да я!..»");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

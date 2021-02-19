using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        // Умовистов Андрей
        // 2. Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
           
            Header("Подсчет количества цифр числа");
            Print("* При вводе не числа - получите 0 ! В качестве разделителя разряда - запятая", ConsoleColor.DarkGray);
            Console.Write("Введите число: ");

            var input = Console.ReadLine();

            var count = 1;
            if (Double.TryParse(input, out double n))
            {
                count = GetDigitsCount(input);
                Print($"Количество цифр в числе: {count}", ConsoleColor.Green);
            } else
            {
                Print("Вы ввели не число!", ConsoleColor.Yellow);
            }

            Print("Нажмите Enter для выхода");
            Console.ReadLine();
        }

   

        /// <summary>
        /// Подсчет цифр в строке
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static int GetDigitsCount(string s)
        {
            var count = 0;
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9')
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Вывод на консоль заголовка программы
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public static void Header(string header)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition((Console.WindowWidth - header.Length) / 2, 1);
            Console.WriteLine(header);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Вывод на консоль заданным цветом
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public static void Print(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

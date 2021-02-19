using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        // Умовистов Андрей
        // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            
            Header("Подсчет количества цифр числа");

            Print("* При вводе не числа - получите 0 ! В качестве разделителя разряда - запятая", ConsoleColor.DarkGray);
            int summ = 0;
            var current = 0;
            bool exit = false;
            do
            {
                Print("Введите число");

                if (Int32.TryParse(Console.ReadLine(), out current))
                {
                    if (current > 0 && current %2 == 1)
                    {
                        summ += current;
                    }
                    if (current == 0) exit = true;

                } else
                {
                    Print("Вы ввели не число!", ConsoleColor.Yellow);
                  
                }

            } while (!exit);

            Print($"Сумма нечетных положительных чисел равна {summ}", ConsoleColor.Green);

            Print("Нажмите Enter для выхода");
            Console.ReadLine();
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
    }
}

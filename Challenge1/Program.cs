using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        // Умовистов Андрей
        // 1. Написать метод, возвращающий минимальное из трех чисел.
        static void Main(string[] args)
        {

            Header("Минимальное из трех чисел");

            Print("* При вводе не числа - получите 0 !", ConsoleColor.DarkGray);
            Console.Write("Введите первое число: ");
            Double.TryParse(Console.ReadLine(), out double n1);

            Console.Write("Введите второе число: ");
            Double.TryParse(Console.ReadLine(), out double n2);

            Console.Write("Введите третье число: ");
            Double.TryParse(Console.ReadLine(), out double n3);

            var min = n1;
            if (n2 < n1 && n2 < n3) min = n2;
            else if (n3 < n1 && n3 < n2) min = n3;


            Print($"Минимальное число: {min}", ConsoleColor.Green);

            // В одну строку
            // Console.WriteLine($"Минимальное число 2: {((n2 < n1 && n2 < n3) ? n2 : (n3 < n1 && n3 < n2) ? n3 : n1)}");


            Print("Нажмите Enter для выхода");
            Console.ReadLine();
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


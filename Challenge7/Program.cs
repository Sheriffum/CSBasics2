using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7
{
    class Program
    {
        //7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static void Main(string[] args)
        {

            Header("Рекурсивные методы");

            Console.WriteLine("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            Print("Вывод чисел:", ConsoleColor.Green);

            PrintNumbers(a, b);
            Console.WriteLine();

            var summ = SummNumbers(a, b);

            Print($"Сумма чисел = {summ}", ConsoleColor.Blue);


            Print("Нажмите Enter для выхода");
            Console.ReadLine();
        }

        /// <summary>
        /// Рекурсивный подсчет чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int SummNumbers(int a, int b)
        {
            if (a==b)
            {
                return b;
            } else
            {
                return a + SummNumbers(a + 1, b);
            }
            
        }

        /// <summary>
        /// Рекурсивный вывод чисел на экран
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void PrintNumbers(int a, int b)
        {
            if (a <= b)
            {
                Console.Write(a + "\t");
                a++;
                PrintNumbers(a, b);
            }
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

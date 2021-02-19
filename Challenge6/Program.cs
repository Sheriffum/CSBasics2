using System;

namespace Challenge6
{
    class Program
    {
        //6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //Хорошим называется число, которое делится на сумму своих цифр.
        //Реализовать подсчет времени выполнения программы, используя структуру DateTime.

        static void Main(string[] args)
        {
            var min = 1;
            var max = 1000000000;
            Header("Подсчет количества «Хороших» чисел");

            var startTime = DateTime.Now;
            Print($"Начинаем поиск хороших чисел в диапазоне от {min} до {max}... Ждите");
            var counter = 0;

            for (int i = min; i < max; i++)
            {
                // выполняется за ~90 сек.
                // с использованием while и делением, 
                // самый быстрый способ
                //t = 0,662 секунд для 10 000 000 чисел
                if (IsGood(i)) counter++;

                // с использованием for и массивом, 
                // быстрый способ, 
                //t = 1,009 секунд для 10 000 000 чисел
                // if (IsGood2(i)) counter++;

                // с использованием foreach и TryParse, 
                // медленный способ, 
                // t = 5,811 секунд для 10 000 000 чисел
                // if (IsGood3(i)) counter++;
            }

            var finishTime = DateTime.Now;
            var duration = finishTime - startTime;

            Print($"Программа выполнялась {duration.TotalSeconds:F3} секунд", ConsoleColor.DarkGray);

            //Найдено хороших чисел: 61574509
            Print($"Найдено хороших чисел: {counter}", ConsoleColor.Green);

            Print("Нажмите Enter для выхода");
            Console.ReadLine();

        }

        // с использованием while и делением, самый быстрый способ, t = 0,662 секунд для 10 000 000 чисел
        private static bool IsGood(int n)
        {
            var origin = n;
            var summDigits = 0;

            while (n > 0)
            {
                summDigits += n % 10;
                n /= 10;
            }

            if (origin % summDigits == 0) return true;
            else return false;
        }

        // с использованием for и массивом, быстрый способ, t = 1,009 секунд для 10 000 000 чисел
        private static bool IsGood2(int n)
        {
            var summDigits = 0;
            var nstring = n.ToString();
            for (int i = 0; i < nstring.Length; i++)
            {
                summDigits += nstring[i];
            }

            if (n % summDigits == 0) return true;
            else return false;
        }

        // с использованием foreach и TryParse, медленный способ, t = 5,811 секунд для 10 000 000 чисел
        private static bool IsGood3(int n)
        {
            var summDigits = 0;

            foreach (var c in n.ToString())
            {
                summDigits += Int32.Parse(c.ToString());
            }
            if (n % summDigits == 0) return true;
            else return false;
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

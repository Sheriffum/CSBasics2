using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    class Program
    {
        // Умовистов Андрей
        //5. 
        //а) Написать программу, которая запрашивает массу и рост человека, 
        //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


        //Индекс массы тела Соответствие между массой человека и его ростом
        //16 и менее  Выраженный дефицит массы тела
        //16—18,5	Недостаточная(дефицит) масса тела
        //18,5—25	Норма
        //25—30	Избыточная масса тела(предожирение)
        //30—35	Ожирение
        //35—40	Ожирение резкое
        //40 и более  Очень резкое ожирение

        static void Main(string[] args)
        {
  

            Header("Индекс массы тела");

            Console.Write("Введите вес (кг): ");
            Double.TryParse(Console.ReadLine(), out double weight);
            Console.Write("Введите рост (см): ");
            Double.TryParse(Console.ReadLine(), out double height);
            
            if (height == 0 || weight == 0)
            {
                Print("Такие не живут..", ConsoleColor.Red);

            } else
            {
                // перевод роста из см в метры
                height = height / 100;
                var index = weight / (height * height);

                Console.Write("Индекс массы тела равен ");
                Print(String.Format("{0:F2}", index), ConsoleColor.Red);

                // Норма индекса 18,5 - 25
                var lowerLimitNormalIndex = 18.5;
                var upperLimitNormalIndex = 25;

                // расчет нормального минимального и максимального веса при текущем росте
                var lowerrNormalWeight = lowerLimitNormalIndex * height * height;
                var upperNormalWeight = upperLimitNormalIndex * height * height;
                double delta = 0;

                if (index <= 16)
                {
                    Print("Выраженный дефицит массы тела", ConsoleColor.Blue);
                    delta = lowerrNormalWeight - weight;
                    Print($"До нормы нужно набрать {delta:F1} кг.");
                } else if (index < 18.5)
                {
                    Print("Недостаточная(дефицит) масса тела", ConsoleColor.Cyan);
                    delta = lowerrNormalWeight - weight;
                    Print($"До нормы нужно набрать {delta:F1} кг.");
                }
                else if (index <= 25)
                {
                    Print("Норма", ConsoleColor.Green);
                    delta = lowerrNormalWeight - weight;
                    Print("Так держать!");
                }
                else if (index <= 30)
                {
                    Print("Избыточная масса тела(предожирение)", ConsoleColor.Yellow);
                    delta = weight - upperNormalWeight;
                    Print($"До нормы нужно сбросить {delta:F1} кг.");
                }
                else if (index <= 35)
                {
                    Print("Ожирение", ConsoleColor.DarkYellow);
                    delta = weight - upperNormalWeight;
                    Print($"До нормы нужно сбросить {delta:F1} кг.");
                }
                else if (index <= 40)
                {
                    Print("Ожирение резкое", ConsoleColor.Red);
                    delta = weight - upperNormalWeight;
                    Print($"До нормы нужно сбросить {delta:F1} кг.");
                } else
                {
                    Print("Очень резкое ожирение", ConsoleColor.DarkRed);
                    delta = weight - upperNormalWeight;
                    Print($"До нормы нужно сбросить {delta:F1} кг.");
                }
            }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        //4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: 
        //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
            Header("Авторизация");


            var attempts = 3;
            bool isAutorized = Authorize(attempts);


            if (isAutorized)
            {
                Print("Поздравляем. Вы успешно авотризовались", ConsoleColor.Green);
            }
            else
            {
                Print("Ты кто такой? Давай до свидания!", ConsoleColor.Red);
            }


            Print("Нажмите Enter для выхода");
            Console.ReadLine();
          
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="attempts"></param>
        /// <returns>sad</returns>
        private static bool Authorize(int attempts)
        {
            while (attempts > 0)
            {
                attempts--;
               
                Console.Write("Введите логин: ");
                var login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains")
                {
                    return true;
                }
                else
                {

                    Print($"Введены неверные логин/пароль. Осталось попыток: {attempts}", ConsoleColor.Yellow);
                }
            }
            return false;
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

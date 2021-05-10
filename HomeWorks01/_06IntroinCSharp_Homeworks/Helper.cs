using System;
//-------------------------------------------------------------------------------------------------------------
//Сухинин М
//*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
//-------------------------------------------------------------------------------------------------------------
namespace _06IntroinCSharp_Homeworks
{
    public class Helper
    {
        /// <summary>
        /// пауза
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Пауза с выводом сообщения
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        public static void Pause(string msg)
        {
            Print(msg);
            Console.ReadKey();
        }
        /// <summary>
        /// Пауза с выводом сообщенеия и заданием цвета текста
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        /// <param name="color">цвет текста</param>
        public static void Pause(string msg, ConsoleColor color)
        {

            Print(msg, color);
            Console.ReadKey();
        }
        /// <summary>
        /// Вывод текста на консоль
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Вывод текста на консоль
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        /// <param name="color">цвет текста</param>
        public static void Print(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Вывод текста на консоль с указанием положения на экране
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        /// <param name="x">координата х </param>
        /// <param name="y">координата у</param>
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Вывод текста на консоль с указанием положения на экране
        /// </summary>
        /// <param name="msg">текст сообщения</param>
        /// <param name="x">координата х </param>
        /// <param name="y">координата у</param>
        /// <param name="color">цвет</param>
        public static void Print(string msg, int[] pos, ConsoleColor color)
        {
            Console.SetCursorPosition(pos[0], pos[1]);
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
        }
        /// <summary>
        /// Получение целочисленного числа
        /// </summary>
        /// <returns></returns>
        public static int GetInt()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в целочисленном формате");
            }
            return x;
        }
        /// <summary>
        /// Получение целочисленного числа с выводом сообщения
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <returns>возвращает введеное пользователем число</returns>
        public static int GetInt(string msg)
        {
            Print($"{msg}");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в целочисленном формате");
            }
            return x;
        }
        /// <summary>
        /// Получение  числа с плавающей запятой сообщения
        /// </summary>
        /// <returns>возвращает введеное пользователем число</returns>
        public static double GetDouble()
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в численном формате");
            }
            return x;
        }
        /// <summary>
        /// Получение  числа с плавающей запятой сообщения
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <returns>возвращает введеное пользователем число</returns>
        public static double GetDouble(string msg)
        {
            Print($"{msg}");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в численном формате");
            }
            return x;
        }
        /// <summary>
        /// Получение строки
        /// </summary>
        /// <returns>возвращает строку</returns>
        public static string GetString()
        {
            string x = Console.ReadLine();
            while (x == "")
            {
                Console.WriteLine("ошибка, символ не введен");
                x = Console.ReadLine();

            }
            return x;
        }
        /// <summary>
        /// Получение строки
        /// </summary>
        /// <param name="msg">сообщение</param>
        /// <returns>возвращает строку</returns>
        public static string GetString(string msg)
        {
            Print($"{msg}");
            string x = Console.ReadLine();
            while (x == "")
            {
                Console.WriteLine("ошибка, символ не введен");
                x = Console.ReadLine();

            }
            return x;
        }
        /// <summary>
        /// Получение координат середины экрана
        /// </summary>
        /// <returns></returns>
        public static int[] GetConsoleCenter()
        {
            int[] a = { 0, 0 };
            a[0] = Console.WindowWidth / 2;
            a[1] = Console.WindowHeight / 2;
            return a;
        }

        static void Main()
        {
            Print($"{Console.WindowHeight} / {Console.WindowWidth}");
            Print($"вы ввели {GetInt("введите число")}");
            Print($"вы ввели {GetDouble("введите флоат"):f2}", GetConsoleCenter(), ConsoleColor.Red);
            Print($"вы ввели  ввели{GetString("Введите строку")}");
            Pause("выход");
        }
    }
}

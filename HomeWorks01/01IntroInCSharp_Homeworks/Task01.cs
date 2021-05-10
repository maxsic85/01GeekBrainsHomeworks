using System;
//------------------------------------------------------------------------------------------------------------
//Сухинин М
/*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
рост, вес). В результате вся информация выводится в одну строчку
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.*/
//------------------------------------------------------------------------------------------------------------
namespace _01IntroInCSharp_Homeworks
{
    public class Task01
    {
        static void Main(string[] args)
        {
            GetInfo();
        }
        static private void GetInfo()
        {
            string name = "", surname = "";
            int age = 0;
            double height = 0, weight = 0;

            Console.WriteLine("Введите имя");
            name = CheckingInputasText();
            Console.WriteLine("Введите фамилию");
            surname = CheckingInputasText();
            Console.WriteLine("Введите возраст");
            age = CheckingInputasInt();
            Console.WriteLine("Введите рост");
            height = CheckingInputasDouble();
            Console.WriteLine("Введите вес");
            weight = CheckingInputasDouble();

            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + ", Вес: " + weight);
            Console.WriteLine("Имя: {0} Фамилия: {1,2} Возраст: {2:D2} Рост: {3:f1} Вес: {4:f2}", name, surname, age, height, weight);
            Console.WriteLine($"Имя: {name,2} Фамилия: {surname,2} Возраст: {age:d2} Рост: {height:f1} Вес: {weight:f2}");
            Console.ReadKey();
        }
        /// <summary>
        ///  Проверка правильности ввода  текста
        /// </summary>
        /// <returns></returns>
        public static string CheckingInputasText()
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
        /// Проверка правильности ввода целочисленного числа
        /// </summary>
        /// <returns></returns>
        public static int CheckingInputasInt()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в численном формате");
            }

            return x;
        }
        /// <summary>
        ///  Проверка правильности ввода целочисленного числа
        /// </summary>
        /// <returns></returns>
        public static double CheckingInputasDouble()
        {
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("ошибка введите в численном формате");
            }

            return x;
        }
    }
}

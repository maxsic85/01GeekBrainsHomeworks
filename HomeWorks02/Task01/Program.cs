using System;
using HelperSpace;
/*
Сухинин М.
Написать метод, возвращающий минимальное из трёх чисел.
*/
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.Print("Введите последовательно три числа", ConsoleColor.Green);
            Max(Helper.GetInt(), Helper.GetInt(), Helper.GetInt());
            Helper.Pause();
        }

        public static void Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Helper.Print($"Максимальное чиисло а= {a}");
            }
            else if (b > c)
            {
                Helper.Print($"Максимальное чиисло b= {b}");
            }
            else
            {
                Helper.Print($"Максимальное чиисло c= {c}");
            }
        }
    }
}

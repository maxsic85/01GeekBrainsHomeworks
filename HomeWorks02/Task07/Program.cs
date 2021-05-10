using System;
/*Сухинин М.
 a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */
namespace Task07
{
    class Program
    {
        static int temp = 0;
        static void Main(string[] args)
        {
            RecOut(0, 10);
            RecSum(1, 100);
            Console.WriteLine($"{temp }");

        }
        /// <summary>
        /// метод, который выводит на экран числа от a до b(a<b)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void RecOut(int a, int b)
        {
            Console.WriteLine($"{ a++}");
            if (a < b) RecOut(a, b);
        }
        /// <summary>
        /// метод, который считает сумму чисел от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void RecSum(int a, int b)
        {
            int sum = 0;
            sum = (a / 10) + a % 10;
            temp += sum;
            if (a >= b)
            {
                return;
            }
            else
            {
                a++;
                RecSum(a, b);
            }
        }
        static int Summ(int a, int b, out Int32 res)
        {
            res = 0;
            Console.WriteLine($"{res = (a + b) * b / 2}");
            return res;
        }
    }
}

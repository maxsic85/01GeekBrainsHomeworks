using System;
using HelperSpace;
using System.Collections;
using System.Collections.Generic;
/*
Сухинин М.
Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать
подсчёт времени выполнения программы, используя структуру DateTime.
*/
namespace Task06
{
    class Program
    {
        /// <summary>
        /// рекурсивный м-д для подсчета суммы числа
        /// </summary>
        /// <param name="dig">введеное число</param>
        /// <returns></returns>
        public static ulong RecurcSum(ulong dig)
        {
            if (dig == 0)
            {
                return 0;
            }
            else
            {
                return RecurcSum(dig / 10) + dig % 10;
            }
        }

        /// <summary>
        /// Возвращает истину если число i делится на число sum
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool GoodDigit(ulong sum, ulong i)
        {
            if (i == 0)
            { return false; }

            return i % sum == 0;
        }

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            ulong sum = 0;
            ulong a = 1000000000;
            for (ulong i = 0; i < a; i++)
            {
                if (GoodDigit(RecurcSum(i), i))
                    sum++;
            }
            Console.WriteLine($"Кол-во хороших чисел для: {a} равно:{sum}, затраченное время {DateTime.Now - start}");

        }
    }
}

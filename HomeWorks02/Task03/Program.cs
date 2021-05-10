using System;
using HelperSpace;
/* Сухинин М
* С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
* положительных чисел.
*/
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int tmp = 1;
            while (tmp != 0)
            {
                //Получение целочисленного числа вводом с консоли
                tmp = Helper.GetInt();
                //Если число четное то суммируем 
                if (IsOdd(tmp))
                {
                    cnt =cnt+tmp;
                }
            }
            Helper.Print($"Сумма четных чисел {cnt}");
        }
        public static bool IsOdd(int n)
        {
            if (n == 0)
            { return false; }

            return n % 2 == 0;
        }
    }
}

using System;
/*
Сухинин М.
а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму
вывести на экран, используя tryParse.
*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInt("Введите число, для выхода введите 0");
        }

        private static bool IsOdd(int digit)
        {
            return (digit % 2 == 0) ? true : false;
        }

        private static int CalcNotOddDigit(int digit, ref int x)
        {
            return (IsOdd(digit)) ? 0 : x++;
        }
               
        private static int GetInt(string message)
        {
            bool flag;
            int x;
            int cnt = 0;
            do
            {
                Console.WriteLine(message);
                string s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                CalcNotOddDigit(x, ref cnt);
            } while (!flag || x != 0);
            Console.WriteLine($"Вы ввели {x}, кол-во нечентый чисел {cnt}");
            return x;

        }
    }
}

using System;
using HelperSpace;
/*
Сухинин М.
Написать метод подсчета количества цифр числа.
*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcDigitLenght(Helper.GetInt("введите целочисленное число"));
            CalcDigitLenght(Helper.GetDouble("введите вещественное число"));

        }
        /// <summary>
        /// Подсчет кол-ва знаков введеного числа
        /// </summary>
        /// <param name="a">целочисленное число</param>
        private static void CalcDigitLenght(int a)
        {
            int cnt = 0;
            string digit = a.ToString();
            for (int i = 0; i < digit.Length; i++)
            {
                cnt++;
            }
            if (digit.Contains("-"))
            {
                Helper.Print($"Число состоит из {cnt - 1} чисел");

            }
            else
            {
                Helper.Print($"Число состоит из {cnt} чисел");
            }
        }
        /// <summary>
        /// Подсчет кол-ва знаков введеного числа
        /// </summary>
        /// <param name="a">вещественное число</param>
        private static void CalcDigitLenght(double a)
        {
            int cnt = 0;
            string digit = a.ToString();
            for (int i = 0; i < digit.Length; i++)
            {
                cnt++;
            }
            if (digit.Contains(","))
            {
                Helper.Print($"Число состоит из {cnt - 1} чисел");

            }
            else
            {
                Helper.Print($"Число состоит из {cnt } чисел");
            }
        }
    }
}

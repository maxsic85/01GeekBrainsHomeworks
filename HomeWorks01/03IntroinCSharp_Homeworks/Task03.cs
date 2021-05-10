using System;
using _01IntroInCSharp_Homeworks;
//------------------------------------------------------------------------------------------------------------------------------
//Сухинин М
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).Вывести результат,
//используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
//метода.
//-------------------------------------------------------------------------------------------------------------------------------
namespace _03IntroinCSharp_Homeworks
{
    class Task03
    {
        static void Main(string[] args)
        {
            CalcDistanceV2();
        }
        /// <summary>
        /// Расчет растояния м-у двумя точками
        /// </summary>
        private static void CalcDistanceV2()
        {
            int[] x = new int[2] { 0, 0 };
            int[] y = new int[2] { 0, 0 };

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("введите координату х" + (i + 1));
                x[i] = Task01.CheckingInputasInt();
            }
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine("введите координату y" + (i + 1));
                y[i] = Task01.CheckingInputasInt();
            }

            double r = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));
            Console.WriteLine($"Расстояние между координатамми равно: {r:f2}");
            Console.ReadKey();
        }
    }
}

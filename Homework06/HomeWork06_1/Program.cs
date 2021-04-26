using System;
using static HomeWork06_1.logic;
//Сухинин М.
//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
//типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и
//функцией a* sin(x).

namespace HomeWork06_1
{
    class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        static void Main(string[] args)
        {
            Table(new Fun(MyFunc), 0, 5);
            Table(new Fun(CalcShift), 0, 5);
            Table(new Fun(CalcSinX), 0, 5);
        }
    }
}

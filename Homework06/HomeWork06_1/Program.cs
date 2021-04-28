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
        static void Main(string[] args)
        {
            OnGUI.PrintTable(new Fun(MyFunc), 0, 5);
            OnGUI.PrintTable(new Fun(CalcShift), 0, 5);
            OnGUI.PrintTable(new Fun(CalcSinX), 0, 5);
        }
    }
}

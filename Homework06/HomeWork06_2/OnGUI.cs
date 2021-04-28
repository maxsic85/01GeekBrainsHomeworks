using System;
using System.Collections.Generic;
using System.Text;
using static HomeWork06_2.Logic;
namespace HomeWork06_2
{
    class OnGUI
    {
        public static void PrintMinFuncValue()
        {
            CalcDelegate[] arrayDelegates = new CalcDelegate[5];
            TytpeFunction t = new TytpeFunction();
            int a, b;
            double step;

            Console.WriteLine($"Выберете функцию, введите число от 0 до 4 ");
            t = (TytpeFunction)int.Parse(Console.ReadLine());
            Console.WriteLine($"укажите длину отрезка от 0 до 4");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"укажите шаг");
            step = double.Parse(Console.ReadLine());

            switch (t)
            {
                case TytpeFunction.F:
                    arrayDelegates[0] = F;
                    break;
                case TytpeFunction.F1:
                    arrayDelegates[1] = F2;
                    break;
                case TytpeFunction.F2:
                    arrayDelegates[2] = F3;
                    break;
                case TytpeFunction.F3:
                    arrayDelegates[3] = F4;
                    break;
                case TytpeFunction.F4:
                    arrayDelegates[4] = F5;
                    break;
                default:
                    arrayDelegates[4] = F5;
                    break;
            }

            Data data = new Data();
            data.SaveFunc(arrayDelegates[(int)t], "data.bin", a, b, step);

            double min1;
            data.Load("data.bin", out min1);
            Console.WriteLine($"Минимум функции {t.ToString()} равен {min1}");
            Console.ReadKey();
        }
    }
}

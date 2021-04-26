using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06_1
{
    public delegate double Fun(double x, double a);

    public class logic
    {
        public static double MyFunc(double x, double a) => a * x * x;

        public static double CalcShift(double x, double a) => a * ((int)x ^ 2);

        public static double CalcSinX(double x, double a) => a* Math.Sin(x);
    }
}

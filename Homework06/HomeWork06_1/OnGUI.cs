using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06_1
{
   public static class OnGUI
    {
        public static void PrintTable(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
    }
}

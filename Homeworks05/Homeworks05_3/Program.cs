using System;
using static Homework05_3.Logics;
/*
Сухинин М.
*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.
*/

namespace Homework05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{IsPermutationString("abac", "caba")}");
        }
    }
}

using System;
//Сухинин Максим.
//Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.
namespace _04IntroinCSharp_Homeworks
{
    class Task04
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a= {a}, b= {b} ");

            int x = 50;
            int y = 123;

            x = y - x;
            y = y - x;
            x = y + x;
            Console.WriteLine($"x= {x}, y= {y} ");

            int n = 1;  //0001
            int m = 2;  //0010

            n = n ^ m;  //0011
            m = m ^ n;  //0010
            n = n ^ m;  //0001
            Console.WriteLine($"n= {n}, m= {m} ");

        }
    }
}

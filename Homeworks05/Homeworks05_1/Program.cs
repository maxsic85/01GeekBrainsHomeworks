using System;
using System.Text.RegularExpressions;
using static Homework05_1.Logics;
/*
Сухинирн М.
Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.*/

namespace Homework05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckInputLogin("а1");
            Regex reg = new Regex(@"^[a-z]{1}[A-Za-z0-9]{1,9}$");
            CheckInputLogin("ш123gyui", reg);
        }

    }

   
}

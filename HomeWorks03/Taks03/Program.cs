using System;
using System.Diagnostics;
using Task03;
/*
Сухинин М.
*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
***Добавить упрощение дробей.
*/
namespace Taks03
{
       class Program
    {
        static void Main(string[] args)
        {
            FractionalNumber fr = new FractionalNumber(126, 426);
            FractionalNumber fr2 = new FractionalNumber(15, 123);

            Console.WriteLine($"Сложение  { fr.Sum(fr, fr2)}");
            Console.WriteLine($"Вычитание  { fr.Sub(fr, fr2)}");
            Console.WriteLine($"Умножение  { fr.Mul(fr, fr2)}");
            Console.WriteLine($"Деление  { fr.Division(fr, fr2)}");
            Console.WriteLine($"НОД  { fr.CalcNOD(fr)}");
            Console.WriteLine($"Упрощение {fr} = { fr.Simplification(fr)}");
            //Проверка работы исключений
            FractionalNumber fr3 = new FractionalNumber(1, 0);

        }
    }
}

using System;

/*Suhinin M.
а) Реализовать библиотеку с классом для работы с двумерным массивом.
-Реализовать конструктор, заполняющий массив случайными числами.
-Создать методы, которые возвращают сумму всех элементов массива,
-сумму всех элементов массива больше заданного,
-свойство,возвращающее минимальный элемент массива,
-свойство, возвращающее максимальныйэлемент массива,
-*метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
-**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
-**в) Обработать возможные исключительные ситуации при работе с файлами.
*/

namespace Homework04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumbOfMaxElementArray2D = null;

            Array2dLib a0 = new Array2dLib("array2d.txt", out int[,] outarr0," ", true);

            return;
            Array2dLib a1 = new Array2dLib(4, 4, out int[,] outarr, true);
            a1.SummArrayElements(a1, out int[,] outarr1, true);
            a1.SummArrayElements(a1, out int[,] outarr2, 90, true);
            Console.WriteLine($"{a1.minElementInArray}");
            Console.WriteLine($"{a1.maxElementInArray}");
            a1.GetNumbOfMaxElementArray2(ref NumbOfMaxElementArray2D, true);
        }
    }
}

using System;
using System.Text;
/*
Сухинин М.
Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать
программу, позволяющую найти и вывести количество пар элементов массива, в которых только
одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 */

namespace HomeWork04_1
{
    class Program
    {              
        static void Main(string[] args)
        {
            int[] outArray = GetArray( 20,  -10000, 10000);
            Console.WriteLine($"{GetPairInArray(outArray)}");
        }

        private static int[] GetArray(int size, int minVal, int maxVal)
        {
            int[] outArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                outArray[i] = rnd.Next(minVal, maxVal);
            }
            return outArray;
        }

        public static int GetPairInArray(int[] array)
        {
            int cnt = 0;
            for (int i = 1; i < array.Length; i++)
            {
                cnt = (array[i - 1] % 3 == 0 && array[i] % 3 != 0 || array[i - 1] % 3 != 0 && array[i] % 3 == 0) ? cnt += 1 : cnt;
            }
            return cnt;
        }
    }
}

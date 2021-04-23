using System;
using System.Text;
using System.Collections.Generic;
/*
Сухинин М.
а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
массив определенного размера и заполняющий массив числами от начального значения с
заданным шагом. Создать свойство Sum, которое возвращает сумму элементов массива, метод
Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый
массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу
библиотеки
в) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
*/


namespace Homework04_3
{
    class Program
    {
        static void Main(string[] args)
        {
            InitMyArray a = new InitMyArray(4, -10, 10, out int[] outarray, true);
            Console.WriteLine($"Сумма эл-в массива {a.Sum}");
            a.InverseArray(outarray, out int[] inverseArray);
            a.Multi(inverseArray, 5);
            Console.WriteLine($"Максимальный элемент массива {a.MaxCount}");

            int[] test = { 1, 2, 3, 4, 1, 1 };
            a.GetRepeatInArray(test, 0);
        }
    }
    public class InitMyArray
    {
        StringBuilder sb = new StringBuilder();

        public InitMyArray(int size, int initialValue, int step, out int[] outArray, bool print)
        {
            outArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                outArray[i] = (i == 0) ? initialValue : outArray[i - 1] + step;
                sb.AppendLine($"Array[{i}]= {outArray[i]}");
            }
            if (print) Console.WriteLine($"{sb}");
            OutArray = outArray;
        }
        public int[] OutArray { get; }
        public int Sum
        {
            get
            {
                int cnt = 0;
                if (OutArray == null) return 0;
                for (int i = 0; i < OutArray.Length; i++)
                {
                    cnt = cnt + OutArray[i];
                }
                return cnt;
            }

        }
        public void InverseArray(int[] InArray, out int[] outArray)
        {
            outArray = new int[InArray.Length];
            sb = new StringBuilder();
            for (int i = 0; i < InArray.Length; i++)
            {
                outArray[i] = -InArray[i];
                sb.AppendLine($"InArray[{InArray[i]}], InverseArray [{outArray[i]}]");
            }
            Console.WriteLine($"{sb}");
        }

        public int[] Multi(int[] array, int multi)
        {
            if (array == null) return null;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * multi;
                sb.AppendLine($"Mul x {multi}= [{array[i]}]");
            }
            Console.WriteLine($"{sb}");
            return array;

        }

        public int MaxCount
        {
            get
            {
                int max = 0;
                int cntmax = 0;
                if (OutArray == null) return 0;
                //Находим максимальный элемент
                for (int i = 0; i < OutArray.Length; i++)
                {
                    max = (max > OutArray[i]) ? max : OutArray[i];
                }
                //считаем количество повтрорв
                for (int i = 0; i < OutArray.Length; i++)
                {
                    cntmax = (max == OutArray[i]) ? cntmax += 1 : cntmax;
                }
                return cntmax;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="indexInArrayForFound">ключ для поиска пары в словаре</param>
        /// <returns></returns>
        public int GetRepeatInArray(int[] array, int indexInArrayForFound)
        {
            int cnt = 0;
            Dictionary<int, int> arrayDict = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                arrayDict.Add(i, array[i]);

            }

            arrayDict.TryGetValue(indexInArrayForFound, out int res);
            foreach (var item in arrayDict)
            {
                if (item.Value == res)
                {
                    cnt++;
                }


            }
            Console.WriteLine($"Кол-во повторов значений '{res}' в словаре по индексу {indexInArrayForFound} равно  {cnt}");

            return cnt;
        }

    }
}


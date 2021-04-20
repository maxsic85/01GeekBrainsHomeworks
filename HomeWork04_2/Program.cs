using System;
using System.IO;
/*
Сухинин М.
Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает
задачу 1;
б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен
возвращать массив целых чисел;
в)**Добавьте обработку ситуации отсутствия файла на диске.
*/
namespace HomeWork04_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] outArray = StaticClass.GetArray(20, -10000, 10000);
            Console.WriteLine($"{StaticClass.GetPairInArray(outArray,3)}");

            int[] outarray2 = StaticClass.GetArray("array.txt1");
            Console.WriteLine($"{StaticClass.GetPairInArray(outarray2,3)}");

        }
    }
    static class StaticClass
    {
        public static int[] GetArray(int size, int minVal, int maxVal)
        {
            int[] outArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                outArray[i] = rnd.Next(minVal, maxVal);
            }
            return outArray;
        }
        public static int[] GetArray(string file)
        {
            int[] outArray;
            try
            {
                int count = File.ReadAllLines($"..\\..\\{file}").Length;
                outArray = new int[count];
                StreamReader sr = new StreamReader($"..\\..\\{file}");
                // Считываем массив
                for (int i = 0; i < outArray.Length; i++)
                {
                    outArray[i] = (int.Parse(sr.ReadLine()));
                }
                sr.Close();

            }
            catch (FileNotFoundException ex)
            {
                outArray =null;
                Console.WriteLine(ex.Message);
                Console.ReadKey();
             
            }
            return outArray;
        }
        public static int GetPairInArray(int[] array, int mask)
        {
            if (array == null) return 0;
            int cnt = 0;
            for (int i = 1; i < array.Length; i++)
            {
                cnt = (array[i - 1] % mask == 0 && array[i] % mask != 0 || array[i - 1] % mask != 0 && array[i] % mask == 0) ? cnt += 1 : cnt;
            }
            return cnt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework04_05
{
    class Array2dLib
    {
        StringBuilder sb = new StringBuilder();
        public int[,] outArrayInt { get; }
        public int minElementInArray
        {
            get
            {
                int min;
                StringBuilder sb = new StringBuilder();

                if (outArrayInt == null)
                {
                    Console.WriteLine($"Массив равен 0 ");
                    min = 0;
                }
                else
                {
                    min = outArrayInt[0, 0];
                    for (int i = 0; i < outArrayInt.GetLength(0); i++)
                    {
                        for (int j = 0; j < outArrayInt.GetLength(0); j++)
                        {
                            min = (min < outArrayInt[i, j]) ? min : outArrayInt[i, j];
                        }
                    }
                }
                sb.AppendLine($"Минимальное значение массива  равно {min}");
                Console.WriteLine($"{sb}");
                return min;
            }
        }
        public int maxElementInArray
        {
            get
            {
                int max;
                StringBuilder sb = new StringBuilder();

                if (outArrayInt == null)
                {
                    Console.WriteLine($"Массив равен 0 ");
                    max = 0;
                }
                else
                {
                    max = outArrayInt[0, 0];
                    for (int i = 0; i < outArrayInt.GetLength(0); i++)
                    {
                        for (int j = 0; j < outArrayInt.GetLength(0); j++)
                        {
                            max = (max > outArrayInt[i, j]) ? max : outArrayInt[i, j];
                        }
                    }
                }
                sb.AppendLine($"Максимальное значение массива  равно {max}");
                Console.WriteLine($"{sb}");
                return max;
            }
        }
        public Array2dLib(int n, int m, out int[,] outArray, bool print)
        {
            outArray = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    outArray[i, j] = rnd.Next(0, 100);
                    sb.AppendLine($"[{i}, {j}]={outArray[i, j]}");
                }
            }
            this.outArrayInt = outArray;
            if (print) Console.WriteLine($"{sb}");
        }

        public Array2dLib(string file, out int[] outArray, bool print)
        {

            try
            {
                int count = File.ReadAllLines($"..\\..\\{file}").Length;
                outArray = new int[count];
                StringBuilder sb = new StringBuilder();
                StreamReader sr = new StreamReader($"..\\..\\{file}");

                // Считываем массив
                for (int i = 0; i < outArray.Length; i++)
                {
                    outArray[i] = (int.Parse(sr.ReadLine()));
                    sb.AppendLine($"Array[{i}]= {outArray[i]}");
                }
                sr.Close();
                if (print) Console.WriteLine($"{sb}");
            }
            catch (Exception ex)
            {
                outArray = new int[0];
                Console.WriteLine(ex.Message);
            }

        }

        public Array2dLib(string file, out int[,] outArray, string delimiter, bool print)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string[] content = File.ReadAllLines($"..\\..\\{file}");
                outArray = new int[content.Length, content[0].Split(delimiter).Length]; //размерность массива(кол-во строк, разбиваем 1 строку на подстроки м-м Split
                for (int i = 0; i < content.Length; i++)//по строкам 
                {
                    string[] temp = content[i].Split(delimiter); //записываем первую строку в массив 
                    for (int j = 0; j < temp.Length; j++)
                    {
                        outArray[i, j] = int.Parse(temp[j]);//берем строку и читаем через разделители
                        sb.AppendLine($"Array[{i},{j}]= {outArray[i, j]}");
                    }
                }
                if (print) Console.WriteLine($"{sb}");
            }
            catch (Exception ex)
            {
                outArray = new int[0, 0];
                Console.WriteLine(ex.Message);
            }

        }

        public int SummArrayElements(Array2dLib ar, out int[,] outArray, bool print)
        {
            outArray = ar.outArrayInt;
            if (ar == null) return 0;
            int cnt = 0;
            for (int i = 0; i < outArray.GetLength(0); i++)
            {
                for (int j = 0; j < outArray.GetLength(1); j++)
                {
                    cnt += outArray[i, j];
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Сумма элементов массива {outArray} равна {cnt}");
            if (print) Console.WriteLine($"{sb} \n");
            return cnt;
        }

        public int SummArrayElements(Array2dLib ar, out int[,] outArray, int max, bool print)
        {
            outArray = ar.outArrayInt;
            if (ar == null) return 0;
            int cnt = 0;
            for (int i = 0; i < outArray.GetLength(0); i++)
            {
                for (int j = 0; j < outArray.GetLength(1); j++)
                {
                    if (outArray[i, j] > max) cnt += outArray[i, j];
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Сумма элементов массива элементы которых более чем  {max} равна {cnt}");
            if (print) Console.WriteLine($"{sb} \n");
            return cnt;
        }

        public int[] GetNumbOfMaxElementArray2(ref int[] array, bool print)
        {
            StringBuilder sb = new StringBuilder();
            int max = 0;
            array = new int[2];
            for (int i = 0; i < outArrayInt.GetLength(0); i++)
            {
                for (int j = 0; j < outArrayInt.GetLength(0); j++)
                {
                    if (max < outArrayInt[i, j])
                    {
                        max = outArrayInt[i, j];
                        array[0] = i;
                        array[1] = j;
                    }
                }

            }
            sb.AppendLine($"Номер максимального элемента массива [ {array[0]}, {array[1]} ]");
            if (print) Console.WriteLine($"{sb} \n");
            return array;
        }
    }
}

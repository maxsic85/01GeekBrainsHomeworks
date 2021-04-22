using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework05_2
{
    public class logics
    {
        public static class Message
        {

            public static void PrintWords(string inputText, int lenghtWord, out List<string> result)
            {
                result = new List<string>();
                Regex re = new Regex(@"^?\b(\w){1,999}\b");
                MatchCollection matches = re.Matches(inputText);
                //разбор текста на отдельные слова
                foreach (Match mat in matches)
                {
                    if (mat.Length > lenghtWord) result.Add(mat.ToString());
                }

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine($"{result[i]}");
                }
                Console.ReadKey();
            }

            public static void DeleteWords(string inputText, string maskForSearch, out string result)
            {
                result = "";
                Regex re = new Regex(@"^?\b(\w){1,999}\b");
                MatchCollection matches = re.Matches(inputText);
                foreach (Match mat in matches)
                {
                    if (mat.ToString()[mat.Length - 1] != Char.Parse(maskForSearch)) result += mat.ToString() + " ";
                }
                Console.WriteLine($"Строка до бреобразования - {inputText}\nпосле преобразования - {result}");
                Console.ReadKey();
            }

            public static string MaxLenghtWord(string inputText)
            {
                StringBuilder sb = new StringBuilder();
                int maxLenght = 1;
                string res = "";
                //Dictionary<int, string> resdict=new Dictionary<int, string>();
                Regex re = new Regex(@"^?\b(\w){1,999}\b");
                MatchCollection matches = re.Matches(inputText);
                foreach (Match mat in matches)
                {
                    maxLenght = maxLenght > mat.Length ? maxLenght : maxLenght = mat.Length;
                    // resdict.Add(mat.Length, mat.ToString());
                }

                foreach (Match mat in matches)
                {
                    if (maxLenght == mat.Length)
                    {
                        sb.Append(mat.ToString());
                        res = mat.ToString();
                    }
                }
                Console.WriteLine($"Слово с максимальным кол-м символов  - {sb}");
                return res;
            }

            public static int[] RepeatCounter(string inputText, string[] searchingText)
            {
                Regex re = new Regex(@"^?\b(\w){1,999}\b");
                MatchCollection matches = re.Matches(inputText);
                Dictionary<int, string> resdict = new Dictionary<int, string>();
                int cnt = 0;
                int[] result = new int[searchingText.Length];
                //разбор текста на отдельные слова и запись в словарь
                foreach (Match mat in matches)
                {
                    resdict.Add(mat.Index, mat.ToString());
                }

                for (int i = 0; i < searchingText.Length; i++)
                {
                    foreach (var item in resdict)
                    {
                        if (item.Value == (searchingText[i])) cnt++;
                    }
                    result[i] = cnt;
                    Console.WriteLine($"{searchingText[i]} встречается {cnt} раз");
                    cnt = 0;
                }
                return result;
            }

            public static Dictionary<string, int> RepeatCounterDictionary(string inputText, string[] searchingText)
            {
                Regex re = new Regex(@"^?\b(\w){1,999}\b");
                MatchCollection matches = re.Matches(inputText);
                Dictionary<int, string> resdict = new Dictionary<int, string>();
                int cnt = 0;
                Dictionary<string, int> result = new Dictionary<string, int>();
                //разбор текста на отдельные слова и запись в словарь
                foreach (Match mat in matches)
                {
                    resdict.Add(mat.Index, mat.ToString());
                }

                for (int i = 0; i < searchingText.Length; i++)
                {
                    foreach (var item in resdict)
                    {
                        if (item.Value == (searchingText[i])) cnt++;
                    }
                    result.Add(searchingText[i], cnt);
                    cnt = 0;
                }
                return result;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework05_4
{
    public static class Logics
    {

        public static void Top3Loosers(int cnt, string[] text)
        {
            //Получаем словарь где ключ это имя и фамилия, а значения средний бал
            Dictionary<string, int> dict = GetDictionaryAndCalcGrade(cnt, text);
            //Сортируем полученный словарь по значению
            dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int g = 0; //для подсчета кол-ва выводящихся учеников с учетом одинаковых баллов
            //беребор словаря и вывод на экран
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} средняя оценка =  { item.Value}");
                //Определяем кол-во повторов в словаре
                var similar_value_keys = dict.Where(dict => dict.Value == item.Value).Select(dict => dict.Key).ToList();

                g++;
                //выходим из нуммератора полсе трех учеников или более с учетом одинаковых оценок
                if (g == similar_value_keys.Count + 3) return;
            }
        }
        /// <summary>
        /// Разбирает входной массив строк на отдельные слова и заносит в словарь строку как ключ числа суммирует и заносит как усредненное значение
        /// </summary>
        /// <param name="cnt">кол-во обрабатываемых строк в массиве</param>
        /// <param name="text">входной массив строк</param>
        /// <returns></returns>
        private static Dictionary<string, int> GetDictionaryAndCalcGrade(int cnt, string[] text)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            //Рег выражение разбивает текст разделенный пробелом на слова длинной от 1 до 20 символов
            Regex re = new Regex(@"^?\b(\w){1,20}\b");
            //проходим по элементам массива 
            for (int i = 0; i < cnt; i++)
            {
                int cntGrade = 0; // кол-во оценок
                int awerGrade = 0;   // сумма оценок
                string str = "";
                MatchCollection matches = re.Matches(text[i]);
                //разбор текста на отдельные слова
                foreach (Match mat in matches)
                {
                    int x;
                    //если полученная часть  не является числом то создаем строку куда дописываем остальные строки 
                    if (!int.TryParse(mat.Value.ToString(), out x))
                    {
                        str = str + mat.Value + " ";
                    }
                    //если число то считаем кол-во чисел и суммируем
                    else if (int.Parse(mat.Value.ToString()) > 0 || int.Parse(mat.Value.ToString()) < 6)
                    {
                        cntGrade++;
                        awerGrade = awerGrade + int.Parse(mat.Value);
                    }
                }
                //Добавляем в словарь полученную строку (фамилия имя) и среднюю оценку 
                dict.Add(str, awerGrade / cntGrade);
            }
            return dict;
        }
    }
}

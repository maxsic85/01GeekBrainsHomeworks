using System;
using System.Collections.Generic;
using static Homework05_2.logics;
/*
Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
*/
namespace Homework05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.PrintWords("yo Good morning my world", 3, out List<string> result);
            Message.DeleteWords("yo Good morning my world", "d", out string result1);
           
            string maxLenghtWords = Message.MaxLenghtWord("Дорогая я уменьшил детей GeekBrai");

            string[] str = { "ff", "tre" };
            int[] cnt = Message.RepeatCounter("ff aa rrr rty re k ff", str);

            Dictionary<string, int> repeat = Message.RepeatCounterDictionary("ff aa rrr re f ff", str);
            foreach (var item in repeat)
            {
                Console.WriteLine($"item {item.Key} повторяется {item.Value} раз(а)");
            }
        }
    }
}

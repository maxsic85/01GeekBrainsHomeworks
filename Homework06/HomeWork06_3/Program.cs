using System;
using System.Collections.Generic;
//*
//Сухинин М.
//Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;
//*/
namespace HomeWork06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing test = new Testing();
            test.TestSorting();
            test.TestLogic();
            test.TestFreqAnalis();
        }
    }

}



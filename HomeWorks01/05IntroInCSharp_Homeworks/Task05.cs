using _06IntroinCSharp_Homeworks;
using System;
//-----------------------------------------------------------------------------------------------------------------------
//Сухинин М
//    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) *Сделать задание, только вывод организовать в центре экрана.
//в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int
//x, int y).
//------------------------------------------------------------------------------------------------------------------------
namespace _05IntroInCSharp_Homeworks
{
    class Task05
    {
        static void Main(string[] args)
        {
            string name = Helper.GetString("Введите имя");
            string surname = Helper.GetString("Введите фамилию");
            string city = Helper.GetString("Введите город проживания");

            Helper.Print($"Имя: {name} Фамилия: {surname} Город: {city}", Helper.GetConsoleCenter(), ConsoleColor.Green);
            Helper.Pause();
        }
    }
}

using System;
using _01IntroInCSharp_Homeworks;
//-----------------------------------------------------------------------------------------------------------
//Сухинин М
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
//I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
//-----------------------------------------------------------------------------------------------------------
namespace _02IntroInCSharp_Homeworks
{
    class Task02
    {
        public static void Main(string[] args)
        {
            CalcIMT();
        }
        public static void CalcIMT()
        {
            Console.WriteLine("введите вес в кг");
            double heihgt = Task01.CheckingInputasDouble();
            Console.WriteLine("введите рост в см");
            double weight = Task01.CheckingInputasDouble() / 100;

            double imt = heihgt / (weight * weight);
            Console.WriteLine($"Вес: {heihgt}кг ,Рост: {weight:f2}м , ИМТ: {imt:f1}");
            Console.ReadKey();
        }
    }
}

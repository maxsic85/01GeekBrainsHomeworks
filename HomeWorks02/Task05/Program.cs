using System;
using HelperSpace;
/*
 Сухиинин М.
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight;
            weight = Helper.GetDouble("Введите свой вес в кг");
            height = Helper.GetDouble("Введите свой рост в см");

            CalcIMT(height, weight);
            Helper.Pause();
        }
        /// <summary>
        /// Расчет ИМТ с выдачей рекомендаций по нормализации
        /// </summary>
        /// <param name="height">рост</param>
        /// <param name="weight">вес</param>
        public static void CalcIMT(double height, double weight)
        {
            const int minIMT = 10;
            const int maxIMT = 30;
            height = height / 100;

            double imt = weight / (height * height);
            Helper.Print($"Вес: {weight}кг ,Рост: {height:f2}м , ИМТ: {imt:f1}");
            if (imt < maxIMT && imt > minIMT)
            {
                Helper.Print("вы идеален");
            }
            else if (imt > maxIMT)
            {
                Helper.Print($"пора худеть, необходимо сбросить {imt - maxIMT:f1}кг");
            }
            else if (imt < minIMT)
            {
                Helper.Print($"пора толстеть, необходимо набрать  {minIMT - imt:f1}кг");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task03
{
    public class FractionalNumber
    {
        int chislitel;
        int znamenatel;

        public int Chislitel { get => chislitel; set => chislitel = value; }
        public int Znamenatel { get => znamenatel; set => znamenatel = value; }

        public double GetFractDouble
        {
            get => chislitel / znamenatel;
        }

        public FractionalNumber()
        {

        }
        public FractionalNumber(int chislitel, int znamenatel)
        {
            this.chislitel = chislitel;
            this.znamenatel = znamenatel;
            //Проверка дроби на деление на 0 с использованием св-ва получения десятичной дроби
            try
            {
                double test = GetFractDouble;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"ОШИБКА ДЕЛЕНИЕ НА НОЛЬ {ex.Message}");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }

        }
        //возвращает истину если знаменатели равны
        public bool ZnamenatelIsEqual(FractionalNumber dig1, FractionalNumber dig2)
        {
            return (dig1.znamenatel == dig2.znamenatel) ? true : false;
        }
        //Возвращает Общий знаменатель 
        public int CalcNOK(FractionalNumber dig1, FractionalNumber dig2)
        {
            return dig1.znamenatel * dig2.znamenatel;
        }
        //Возвращает наибольший общий делитель
        public int CalcNOD(FractionalNumber dig1)
        {
            int ostatok1 = 0;
            int ostatok2 = 0;
            if (dig1.chislitel > dig1.znamenatel)
            {
                ostatok1 = dig1.chislitel % dig1.znamenatel;
                ostatok2 = dig1.znamenatel % ostatok1;


                if (dig1.chislitel % dig1.znamenatel == 0) return dig1.znamenatel;
                do
                {
                    if (ostatok2 == 0) return ostatok1;
                    ostatok1 = ostatok1 % ostatok2;
                    if (ostatok1 == 0) return ostatok2;
                    ostatok2 = ostatok2 % ostatok1;

                } while (ostatok2 != 0); return ostatok1;
            }
            else
            {
                ostatok1 = dig1.znamenatel % dig1.chislitel;
                ostatok2 = dig1.chislitel % ostatok1;
                if (dig1.znamenatel % dig1.chislitel == 0) return dig1.chislitel;
                do
                {
                    if (ostatok2 == 0) return ostatok1;
                    ostatok1 = ostatok1 % ostatok2;
                    if (ostatok1 == 0) return ostatok2;
                    ostatok2 = ostatok2 % ostatok1;
                } while (ostatok2 != 0); return ostatok1;
            }

        }
        //Упрощение дроби
        public FractionalNumber Simplification(FractionalNumber fr)
        {
            int ind = CalcNOD(fr);
            fr.chislitel /= ind;
            fr.znamenatel /= ind;
            return fr;
        }
        //Сложение дробей
        public FractionalNumber Sum(FractionalNumber dig1, FractionalNumber dig2)
        {
            FractionalNumber res = new FractionalNumber();
            if (ZnamenatelIsEqual(dig1, dig2))
            {
                res.chislitel = dig1.chislitel + dig2.chislitel;
                res.znamenatel = dig1.znamenatel;
                return res;
            }
            else
            {
                int nok = CalcNOK(dig1, dig2);
                Console.WriteLine($"Общий знаменатель {nok}");
                res.chislitel = ((nok / dig1.znamenatel) * dig1.chislitel) + ((nok / dig2.znamenatel) * dig2.chislitel);
                res.znamenatel = nok;
                return res;
            }
        }
        //Вычитание дробей
        public FractionalNumber Sub(FractionalNumber dig1, FractionalNumber dig2)
        {
            FractionalNumber res = new FractionalNumber();
            if (ZnamenatelIsEqual(dig1, dig2))
            {
                res.chislitel = dig1.chislitel - dig2.chislitel;
                res.znamenatel = dig1.znamenatel;
                return res;
            }
            else
            {
                int nok = CalcNOK(dig1, dig2);
                Console.WriteLine($"Общий знаменатель {nok}");
                res.chislitel = ((nok / dig1.znamenatel) * dig1.chislitel) - ((nok / dig2.znamenatel) * dig2.chislitel);
                res.znamenatel = nok;
                return res;
            }
        }
        //Умножение дробей
        public FractionalNumber Mul(FractionalNumber dig1, FractionalNumber dig2)
        {
            FractionalNumber res = new FractionalNumber();
            res.chislitel = dig1.chislitel * dig2.chislitel;
            res.znamenatel = dig1.znamenatel * dig2.znamenatel;
            return res;
        }
        //Деление дробей
        public FractionalNumber Division(FractionalNumber dig1, FractionalNumber dig2)
        {
            FractionalNumber res = new FractionalNumber();
            res.chislitel = dig1.chislitel * dig2.znamenatel;
            res.znamenatel = dig1.znamenatel * dig2.chislitel;
            return res;
        }
        //переопределение м-да ToString 
        public override string ToString()
        {
            return (chislitel + "/" + znamenatel);
        }
    }
}

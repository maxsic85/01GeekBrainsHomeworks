using System;
using Helper;
//Сухинин М.
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить
//работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
namespace Homework03
{
    /// <summary>
    /// Перечисление, операции с комплексными числами
    /// </summary>
    public enum OperationsType
    {
        PLUS,             //-0
        MULTY,            //-1
        SUBSTRACTION      //-2
    }

    /// <summary>
    /// Структура работы с комплексными числами
    /// </summary>
    struct ComplexStruct
    {
        #region материал с методички
        public double z;
        public double i;
        // в C# в структурах могут храниться также действия над данными
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.z = z + x.z;
            y.i = i + x.i;
            return y;
        }
        // Пример произведения двух комплексных чисел
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.z = i * x.z + z * x.i;
            y.i = i * x.i - z * x.z;
            return y;
        }
        #endregion

        #region MyCode
        //Конструктор 
        public ComplexStruct(double z, double i)
        {
            this.z = z;
            this.i = i;
        }
        // в C# в структурах могут храниться также действия над данными
        public ComplexStruct subtraction(ComplexStruct x)
        {
            ComplexStruct y;
            y.z = z - x.z;
            y.i = i - x.i;
            return y;
        }
        public override string ToString()
        {
            return (i > 0) ? z + "+" + i + "i" : z + " " + i + "i";
        }
        #endregion
    }

    /// <summary>
    /// Класс работы с комплексными числами
    /// </summary>
    class ComplexClass
    {
        #region материал с методички
        // Поля приватные.
        private double z;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double i;
        // Конструктор без параметров.
        public ComplexClass()
        {
            z = 0;
            i = 0;
        }
        // Конструктор, в котором задаем поля.
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public ComplexClass(double _im, double i)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
            z = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.i = i;
        }
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.z = x2.z + z;
            x3.i = x2.i + i;
            return x3;
        } // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return z; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) z = value;
            }
        } // Специальный метод, который возвращает строковое представление данных.
        #endregion

        #region MyCode
        public override string ToString()
        {
            return (i > 0) ? z + "+" + i + "i" : z + " " + i + "i";
        }
        public ComplexClass subtraction(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.z = z - x.z;
            y.i = i - x.i;
            return y;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.z = i * x.z + z * x.i;
            y.i = i * x.i - z * x.z;
            return y;
        }
        #endregion
    }
    class Task01
    {
        static void Main(string[] args)
        {
            double z1 = Helper.Helper.GetDouble($"введите целую часть первого числа");
            double i1 = Helper.Helper.GetDouble($"введите мнимую часть первого числа");
            double z2 = Helper.Helper.GetDouble($"введите целую часть второго числа");
            double i2 = Helper.Helper.GetDouble($"введите мнимую часть второго числа");

            OperationsType opt = new OperationsType();
            opt = (OperationsType)Helper.Helper.GetInt($"Введите операцию, 0-сложение , 1 -умножение, 2 -вычитание ");

            switch (opt)
            {
                case OperationsType.PLUS:
                    Console.WriteLine($"Сложение: {new ComplexStruct(z1, i1).Plus(new ComplexStruct(z2, i2))}"); break;
                case OperationsType.SUBSTRACTION:
                    Console.WriteLine($"Вычитание: {new ComplexClass(z1, i1).subtraction(new ComplexClass(z2, i2))}"); break;
                case OperationsType.MULTY:
                    Console.WriteLine($"Умножение: {new ComplexClass(z1, i1).Multi(new ComplexClass(z2, i2))}"); break;
                default: Helper.Helper.Print("Вы выбрали несуществующую операцию", ConsoleColor.Red); break;
            }
        }
    }
}

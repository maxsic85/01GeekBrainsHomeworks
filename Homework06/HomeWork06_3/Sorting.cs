using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork06_3
{
   public static class Sorting
    {
        internal static int SortByName(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName); //  Сравниваем две строки
        }

        internal static int SortByAge(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return (st1.age > st2.age) ? 1 : -1; //  Сравниваем две строки
        }
        
       internal static void SortByAgeAndCourse(List<Student> students, out List<Student> result)
        {
            result = new List<Student>();
            var subGroup = students.GroupBy(x => new { _company = x.age, _country = x.course });
            foreach (var it in subGroup)
            {
                // Console.WriteLine($"{it.Key._company}.{it.Key._country}: {it.Count()}");

                foreach (Student p in it)
                    Console.WriteLine($"{p.course} ----- {p.age}");
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork06_3
{
    public class Testing
    {
        ConnectToDB db = new ConnectToDB();
        GetStudentInfo gi = new GetStudentInfo();
        List<Student> currentStudents = new List<Student>();
        public void TestSorting()
        {
            db.ConnectAndGetList("..\\..\\students.csv", out currentStudents);

            currentStudents.Sort(new Comparison<Student>(Sorting.SortByAge));
            currentStudents.Sort(new Comparison<Student>(Sorting.SortByName));

            List<Student> sort = new List<Student>();
            Sorting.SortByAgeAndCourse(currentStudents, out sort);

        }

        public void TestLogic()
        {
            db.ConnectAndGetList("..\\..\\students.csv", out currentStudents);
            Console.WriteLine(gi.PrintStudents(currentStudents));
            Console.WriteLine("Численность группы:" + gi.GetInfo(gi.GetGroupCount, currentStudents));
            Console.WriteLine("Магистров:{0}", gi.GetInfo(gi.GetMagistr, currentStudents));
            Console.WriteLine("Бакалавров:{0}", gi.GetInfo(gi.GetBakalavr, currentStudents));
            Console.WriteLine("Студентов на 5 курсе:{0}", gi.GetCountStudentsOnCurs(currentStudents, 5));
        }

        public void TestFreqAnalis()
        {
            db.ConnectAndGetList("..\\..\\students.csv", out currentStudents);
            //Словарь <курс, кол-во студентов от 18 до 20>
            Dictionary<int, int> temp = new Dictionary<int, int>();
            temp = gi.FreqByGroup(currentStudents, 18, 20);
            foreach (var item in temp)
            {
                Console.WriteLine($"Кол-во студентов в возрасте от 18 до 20 лет на  {item.Key} курсе = {item.Value} студента");
            }
            Console.ReadKey();
        }
    }
}


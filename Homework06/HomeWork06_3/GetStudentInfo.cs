using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork06_3
{
    internal delegate int StudentInfoDelegate(List<Student> list);

    public class GetStudentInfo
    {

        StringBuilder sb = new StringBuilder();

        internal string PrintStudents(List<Student> students)
        {
            sb.AppendLine($"Состав группы {students[0].group}:");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.firstName}  {item.lastName}   {item.age}   {item.group};");
            }
            return sb.ToString();
        }

        internal int GetBakalavr(List<Student> students)
        {
            int numOfBachelors = 0;
            foreach (var item in students)
            {
                if ((int)item.course < 5) numOfBachelors++;
            }
            return numOfBachelors;
        }

        internal int GetMagistr(List<Student> students)
        {
            int numOfMasters = 0;
            foreach (var item in students)
            {
                if ((int)item.course > 5) ++numOfMasters;
            }
            return numOfMasters;
        }

        internal int GetCountStudentsOnCurs(List<Student> students, int course)
        {
            int result = 0;
            foreach (var item in students)
            {
                if ((int)item.course == course) ++result;
            }
            return result;
        }

        internal int GetGroupCount(List<Student> students)
        {
            return students.Count;
        }

        internal Dictionary<int, int> FreqByGroup(List<Student> students, int minage, int maxage)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            List<int> c01 = new List<int>();
            //создание списка студентов ограниченного возрастом
            foreach (var item in students)
            {
                c01 = students.Where(temp => (temp.age >= minage && temp.age <= maxage)).Select(temp => temp.course).ToList();
            }
            //считаем кол-во повторяющихся записей 
            foreach (var item in c01.Distinct())
            {
                temp.Add(item, c01.Where(x => x == item).Count());
                //Console.WriteLine(item + " - " + c01.Where(x => x == item).Count() + " раз");
            }

            return temp;
        }

        internal List<Student> Sort(List<Student> students)
        {
            List<Student> lst = new List<Student>();
            var phoneGroups = from student in students group student by student.age;

            foreach (IGrouping<int, Student> g in phoneGroups)
            {
                foreach (var item in g)
                {
                    lst.Add(item);
                }
            }
            return lst;
        }

        internal int GetInfo(StudentInfoDelegate del, List<Student> students)
        {
            return del(students);
        }
}
}

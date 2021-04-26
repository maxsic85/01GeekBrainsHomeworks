using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork06_3
{
    public class ConnectToDB
    {
        internal void ConnectAndGetList(string path, out List<Student> resultList)
        {
            resultList = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    resultList.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение  программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
        }
    }
}

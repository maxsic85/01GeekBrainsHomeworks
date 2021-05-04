using System;
using System.Collections.Generic;
using System.Text;
/*
Сухинин М.
С помощью рефлексии выведите все свойства структуры DateTime
 */
namespace TaskLibrary
{
    public class Task01
    {
        public string NullObject { get; }
        public Stack<string> resultProp = new Stack<string>();
        public Stack<int> resultHash = new Stack<int>();
        public void GetProp(Object obj)
        {
            if (obj == null) obj = this;  //Если нулевой объект то получим одно сво-во текущего объекта NullObject 
            foreach (var item in obj.GetType().GetProperties())
            {
                resultProp.Push(item.Name.ToString());
                resultProp.Push(item.GetHashCode().ToString());

            }
        }
        public StringBuilder Print<T>(Stack<T> resStack)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in resStack)
            {
                sb.AppendLine(item.ToString());
            }
            return sb;
        }

       

    }
}

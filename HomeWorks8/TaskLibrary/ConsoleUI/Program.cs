using System;
using TaskLibrary;
using TaskLibrary.Interfaces;
using TaskLibrary.Presenters;
/// <summary>
/// Краткий пример реалитзации через консоль 
/// </summary>
namespace ConsoleUI
{
    class Program : IView
    {
        #region Data
        string en;
        public string Path { get; set; }
        public string En
        {
            get => en = Console.ReadLine();
            set => en = value;
        }
        public string Ru { get; set; }
        public int Cnt { get; set; }
#endregion
        Presenter p;
        private void Test()
        {
            int selectedComand=0;
            Presenter p = new Presenter(this);
            p.GetType().GetMethod("LoadDictionary").Invoke(p, null);
            Console.WriteLine($"введите  для показа следующего слова {selectedComand=Int32.Parse(Console.ReadLine())}");
            switch (selectedComand)
            {
                case 1: p.Next(); Console.WriteLine($"{ Ru}");  break ;
                case 2: p.Prev(); break;
                case 3: p.Translate(); break;
                case 4: p.Add(); break;
                case 5: p.SaveDictionary(); break;
                default:
                    break;
            }

        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Test();            
            
            Task01 tsk = new Task01();
            tsk.GetProp(new DateTime());
            Console.WriteLine($"{tsk.Print<String>(tsk.resultProp)}");
            Console.WriteLine($"{tsk.Print<Int32>(tsk.resultHash)}");
            Console.ReadKey();
        }
    }
}

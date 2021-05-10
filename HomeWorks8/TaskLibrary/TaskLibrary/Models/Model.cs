using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TaskLibrary.Infrascture;
using TaskLibrary.Interfaces;

namespace TaskLibrary.Models
{
    class Model : IDataXML, IDataCSV
    {

        #region Data
        DictoinaryEn currenDictionary;
        public DictoinaryEn CurrenDictionary => this.currenDictionary;

        private int currentIndex;
        public int CurrenIndex
        {
            get => this.currentIndex;
            set => this.currentIndex = value;
        }
        public readonly string WAY;
        #endregion
        public Model(string Way = "D:/Geekbrains/test.xml")
        {
            currenDictionary = new DictoinaryEn();
            currentIndex = 0;
            this.WAY = Way;
        }

        public Words CurrentWord
        {

            get
            {
                if (CurrenIndex >= 0) { return currenDictionary[currentIndex]; }
                else { return null; }
            }
        }



        public void LoadDataXML()
        {
            if (!File.Exists(WAY)) return;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            Stream fStream = new FileStream(WAY, FileMode.Open, FileAccess.Read);
            currenDictionary.Dictionary = (List<Words>)xmlFormat.Deserialize(fStream);
            fStream.Close();

        }

        public void SaveDataXML()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            Stream fStream = null;
            if (!File.Exists(WAY))
            {
                fStream = new FileStream(WAY, FileMode.Create, FileAccess.ReadWrite);
            }
            else
            {
                fStream = new FileStream(WAY, FileMode.Create, FileAccess.Write);
            }
            xmlFormat.Serialize(fStream, currenDictionary.Dictionary);
            fStream.Close();
        }

        public void SaveDataXML(string path)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            Stream fStream = null;
            fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, currenDictionary.Dictionary);
            fStream.Close();
        }

        public void LoadDataCSV(string path)
        {
            CurrenDictionary.Dictionary.Clear();
            StreamReader sr = new StreamReader(path = "D:/Geekbrains/test.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    CurrenDictionary.Dictionary.Add(new Words(s[0], s[1]));
                }
                catch (Exception e)
                {

                }
            }
            sr.Close();






            //if (!File.Exists(WAY)) return;
            //XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Words>));
            //Stream fStream = new FileStream(WAY, FileMode.Open, FileAccess.Read);
            //currenDictionary.Dictionary = (List<Words>)xmlFormat.Deserialize(fStream);
            //fStream.Close();

        }
    }
}

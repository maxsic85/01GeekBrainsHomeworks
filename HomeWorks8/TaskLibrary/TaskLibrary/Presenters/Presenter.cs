using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Interfaces;
using TaskLibrary.Models;
namespace TaskLibrary.Presenters
{
    public class Presenter
    {
        public int DelegateForCompare(Words w1, Words w2)
        {
            return  String.Compare(w1.En, w2.En);
        }

        private Model model;
        private IView view;
        Task04_Translater translater = new Task04_Translater();

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

         public void LoadDictionary()
        {
            model.LoadDataXML();

            if (model.CurrenDictionary.CountWords > 0)
            {
                model.CurrenIndex = 0;
                var tempWord = model.CurrentWord;

                view.En = tempWord.En;
                view.Ru = tempWord.Ru;
                view.Path = model.WAY;
                getCntWords();
            }
        }

        public void LoadDictionaryFromCSV()
        {

            model.LoadDataCSV(view.Path);

            if (model.CurrenDictionary.CountWords > 0)
            {
                model.CurrenIndex = 0;
                var tempWord = model.CurrentWord;

                view.En = tempWord.En;
                view.Ru = tempWord.Ru;
                view.Path = model.WAY;
                getCntWords();
            }
        }

        public void Add()
        {
            model.CurrenDictionary.AddRevenge(
                new Words(view.En,translater.Translate(view.En))
                );
        }

        public void Remove()
        {
            Words t = new Words(view.En, view.Ru);
            model.CurrenDictionary.RemoveRevenge(t);

            if (model.CurrenDictionary.CountWords < 1)
            {
                model.CurrenIndex = -1;

                view.En = string.Empty;
                view.Ru = string.Empty;
                ClearUI();
            }
            else
            {
                model.CurrenIndex--;
                if (model.CurrenIndex < 0) model.CurrenIndex = 0;

                view.En = model.CurrentWord.En;
                view.Ru = model.CurrentWord.Ru;
            }
        }

        public void RemoveAll()
        {
            Words t = new Words(view.En, view.Ru);
            model.CurrenDictionary.Dictionary.Clear();
            ClearUI();
            SaveDictionary();
        }

        public void SaveDictionary()
        {
            model.SaveDataXML();
            getCntWords();
        }

        public void SaveDictionaryAs()
        {
            model.SaveDataXML(view.Path);
            getCntWords();
        }

        public void Next()
        {
            if (model.CurrenDictionary.CountWords > 0)
            {
                if (model.CurrenIndex + 1 < model.CurrenDictionary.CountWords)
                {
                    model.CurrenIndex++;
                    view.En = model.CurrentWord.En;
                    view.Ru = model.CurrentWord.Ru;
                 
                }
            }
        }

        public void Prev()
        {
            if (model.CurrenDictionary.CountWords > 0)
            {
                if (model.CurrenIndex - 1 > -1)
                {
                    model.CurrenIndex--;
                    view.En = model.CurrentWord.En;
                    view.Ru = model.CurrentWord.Ru;
                }
            }
        }

        public void Translate()
        {
            view.Ru = translater.Translate(view.En).ToString();
        }

        public void ClearUI()
        {
            view.En = string.Empty;
            view.Ru = string.Empty;
        }

        public int getCntWords()
        {
            view.Cnt = model.CurrenDictionary.CountWords;
            return model.CurrenDictionary.CountWords;
        }

        public void NewDictionary(string way)
        {
            model = new Model(way);
            LoadDictionary();
        }

        public void Sort()
        {
            model.CurrenDictionary.Dictionary.Sort(new Comparison<Words>(DelegateForCompare));

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Models;

namespace TaskLibrary.Infrascture
{
    public class DictoinaryEn : IEnumerable
    {
        public DictoinaryEn()
        {
            dictionaryEn = new List<Words>();
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Words item in dictionaryEn)
            {
                yield return (Words)item;
            }
        }
        #region Данные
        public List<Words> Dictionary
        {
            get => this.dictionaryEn;
            set => this.dictionaryEn = value;
        }
        private List<Words> dictionaryEn;

        #endregion
        #region Логика
        public bool AddRevenge(Words NewWord)
        {
            bool flag = false;
            if (!dictionaryEn.Contains(NewWord))
            {
                dictionaryEn.Add(NewWord);
                flag = true;
            }
            return flag;
        }


        public bool RemoveRevenge(Words RemoveWord)
        {

            bool flag = false;
            if (dictionaryEn.IndexOf(RemoveWord) != -1)
            {
                dictionaryEn.Remove(RemoveWord);
                flag = true;
            }
            return flag;
        }

        public int CountWords => dictionaryEn.Count;

        public Words this[int index]
        {
            get => !IsNullOrEmpty() ? dictionaryEn[index] : null;
        }

        private bool IsNullOrEmpty()
        {
            bool flag = true;

            if (dictionaryEn != null)
            {
                if (dictionaryEn.Count > 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        #endregion

    }
}

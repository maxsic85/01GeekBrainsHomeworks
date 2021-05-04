using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TaskLibrary.Models
{


    [Serializable]
    public class Words : IEquatable<Words>
    {
       
        public bool Equals(Words other)
        {
            return this.En == other.En;
        }
        public Words()
        { }
        public Words(string entext, string rutext)
        {
            this.En = entext;
            this.Ru = rutext;
        }
        #region Data
        private string en;
        private string ru;
        public string En { get => en; set => en = value; }
        public string Ru { get => ru; set => ru = value; }

        #endregion
    }
}


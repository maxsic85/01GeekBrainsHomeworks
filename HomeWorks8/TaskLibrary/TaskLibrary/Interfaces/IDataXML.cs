using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Interfaces
{
    public interface IDataXML : IData
    {
        void LoadDataXML();

        void SaveDataXML();

    }
}

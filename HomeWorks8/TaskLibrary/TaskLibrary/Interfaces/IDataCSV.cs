using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Interfaces
{
    public interface IDataCSV : IData
    {
        void LoadDataCSV(string path);

    }
}

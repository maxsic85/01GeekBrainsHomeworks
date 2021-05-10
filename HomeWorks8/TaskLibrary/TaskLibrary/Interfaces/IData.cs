using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Interfaces
{
  public  interface IData
    {
         virtual void LoadData() { }
         virtual void SaveData() { }
    }
}

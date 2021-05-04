using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Interfaces
{
  public   interface IView
    {
        string Path { get; set; }
        string En { get; set; }
        string Ru { get; set; }
        int Cnt { get; set; }

    }
}

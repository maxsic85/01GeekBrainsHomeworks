using System;
using System.Collections.Generic;
using System.Text;

namespace WF_UdvoitelLibrary.ViewInterface
{
    public interface IView
    {
        string BtnIncrease { get; set; }
        string BtnMul { get; set; }
        string BtnReset { get; set; }
        string LblTxt { get; set; }
    }
}

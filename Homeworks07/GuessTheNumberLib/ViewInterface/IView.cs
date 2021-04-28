using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheNumberLib.ViewInterface
{
  public  interface IView
    {
        string TextBoxText { get; set; }
        string BtnAnswer { get; set; }
        string BtnRestart{ get; set; }

        string LblTxt { get; set; }
    }
}

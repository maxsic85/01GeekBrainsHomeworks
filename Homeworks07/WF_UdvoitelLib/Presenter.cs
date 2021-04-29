using System;
using System.Collections.Generic;
using WF_UdvoitelLibrary.ViewInterface;

namespace WF_UdvoitelLibrary
{
    public class Presenter
    {
        private IView view;
        public int Result { get; set; }
        public int CntClickCommand { get; set; }
        public int DigitForFind { get; set; }

        public Stack<int> hystory=new Stack<int>();

        Random r = new Random();
        public Presenter(IView View)
        {
            this.view = View;
            Result = 0;
            CntClickCommand = 0;
        }
        public void NewGame()
        {
            Result = 0;
            CntClickCommand = 0;
            DigitForFind = r.Next(1, 100);
            view.LblTxt = "Загаданное число: " + DigitForFind 
                + "\n Вам необходимо получить это число за минимальное количество ходов";
        }
        public bool EndGame()=> (DigitForFind == Result) ? true : false;    
        public bool GameOver()=> (DigitForFind < Result) ? true : false;   
        private void UpdateUI()
        {
            if(!EndGame())
            view.LblTxt = "Загаданное число: " + DigitForFind
                + "\nРезультат: " + Result.ToString() + "/" + "попыток: " + CntClickCommand;
            else
            view.LblTxt = "Вы угадали загаданное число: " + DigitForFind
                 + "\nза "+ CntClickCommand+  " попыток";
            if (GameOver()) view.LblTxt = "Ты продул, разява! ";

        }
        public void Mulx2()
        {
            if (GameOver()) return;
            Result *= 2;
            CntClickCommand += 1;
            hystory.Push(Result);
            UpdateUI();
        }
        public void Increase()
        {
            if (GameOver()) return;
            CntClickCommand += 1;
            Result += 1;
            hystory.Push(Result);
            UpdateUI();
        }
        public void Reset()
        {
            Result = 1;
            CntClickCommand = 0;
            hystory.Clear();
            UpdateUI();
        }
        public void Udo()
        {
            if (hystory.Count == 0) return;
            Result = hystory.Pop();
            CntClickCommand--;
            UpdateUI();
        }
    }

}

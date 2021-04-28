using GuessTheNumberLib;
using GuessTheNumberLib.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumberFormMain
{
    public partial class MainForm : Form, IView
    {
        #region ревлизация интерфейса
        public string TextBoxText { get => newForm.textBox1.Text; set => newForm.textBox1.Text = value; }
        public string BtnRestart { get; set; }
        public string LblTxt { get => label1.Text; set => label1.Text = value; }
        string IView.BtnAnswer { get => BtnAnswer.Text; set => BtnAnswer.Text = value; }
        #endregion
        Presenter p;
        Form2 newForm = new Form2();
        public MainForm()
        {
            InitializeComponent();
            p = new Presenter(this);
            BtnNewGame.Click += (s, e) => p.Restart();
            #region подсказка
            BtnNewGame.Click += (s, e) => label2.Text = p.Secret.ToString();
            BtnNewGame.Click += (s, e) => p.UpdateUI();
            #endregion
            newForm.BtmCheck.Click += (s, e) => p.CheckAnswer();
            newForm.BtmCheck.Click += (s, e) => newForm.Hide();
        }
        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }
    }
}

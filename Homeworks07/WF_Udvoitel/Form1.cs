using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_UdvoitelLibrary.ViewInterface;
using WF_UdvoitelLibrary;
namespace WF_Udvoitel
{
    public partial class Form1 : Form, IView
    {
        public string BtnIncrease { get => btnCommand1.Text; set => btnCommand1.Text = value; }
        public string BtnMul { get => btnCommand2.Text; set => btnCommand2.Text = value; }
        public string BtnReset { get => btnReset.Text; set => btnReset.Text = value; }
        public string LblTxt { get => lblNumber.Text; set => lblNumber.Text = value; }

       Presenter p;
        public Form1()
        {
            InitializeComponent();
            p = new Presenter(this);
            btnCommand1.Click += (s, e) => p.Increase();
            btnCommand2.Click += (s, e) => p.Mulx2();
            btnReset.Click += (s, e) => p.Reset();
            NewGame.Click += (s, e) => p.NewGame();
            udoBtn.Click += (s, e) => p.Udo();

        }

        private void NewGame_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            btnCommand1.Visible = true;
            btnCommand2.Visible = true;
            btnReset.Visible = true;
            udoBtn.Visible = true;
            
        }

       
    }
}

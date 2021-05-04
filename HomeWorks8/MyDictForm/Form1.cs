using System;
using System.Windows.Forms;
using TaskLibrary.Interfaces;
using TaskLibrary.Presenters;
/*Сухинин М.
 * ПРограмма позволяет вести англо-русский словарь
 * переводить обращаясь к google переводчику
 * добавлять новые слова в сдловрь
 * сохранять словарь в файл
 * удалять слова из словаря 
 * получать новые слова из CSV файла
 * выводить слова (EN, RU) 
 */
namespace MyDictForm
{
    public partial class Form1 : Form, IView
    {
        #region Data
        public string Path
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }
        public string En
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }
        public string Ru
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }

        public int Cnt
        {
            get => p.getCntWords();
            set => label1.Text = value.ToString();
        }
        #endregion
        Presenter p;
        public Form1()
        {
            InitializeComponent();
            p = new Presenter(this);
            p.LoadDictionary();
        
            BtnLoad.Click += (s, e) => p.LoadDictionary();
            BtnAdd.Click += (s, e) => p.Add();
            BtnSave.Click += (s, e) => p.SaveDictionary();
            BtnTrans.Click += (s, e) => p.Translate();
            BtnPrev.Click += (s, e) => p.Prev();
            BtnNext.Click += (s, e) => p.Next();
            BtnRemove.Click += (s, e) => p.Remove();
            BtnRemAll.Click += (s, e) => p.RemoveAll();
            BtnClearUI.Click += (s, e) => p.ClearUI();
            BtnCreate.Click += (s, e) => p.NewDictionary(Path);
            BtnSort.Click += (s, e) => p.Sort();
            BtnCSV.Click += (s, e) => p.LoadDictionaryFromCSV();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox3.Text = openFileDialog1.FileName.ToString();
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Path = openFileDialog1.FileName.ToString();
            BtnSaveAs.Click += (s, e) => p.SaveDictionaryAs();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            contentsToolStripMenuItem.Visible = false;
            indexToolStripMenuItem.Visible = false;
            searchToolStripMenuItem.Visible = false;

            aboutToolStripMenuItem.Click+=(s,e)=> MessageBox.Show("Сухинин М.А.");
        }
    }
}

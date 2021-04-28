using System.IO;
using static HomeWork06_2.Logic;

namespace HomeWork06_2
{
    public class Data
    {
        public void SaveFunc(CalcDelegate t, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(CalcF(new CalcDelegate(t), x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }        
        public double[] Load(string fileName, out double min)
        {

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] res = new double[fs.Length];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                res[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return res;
        }
    }
}

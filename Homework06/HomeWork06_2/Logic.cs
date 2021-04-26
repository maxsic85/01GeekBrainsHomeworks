
namespace HomeWork06_2
{
    public delegate double CalcDelegate(double x);
    
   
    public static class Logic
    {
       
        public static double F(double x) => x * x - 50 * x + 10;

        public static double F2(double x) => x * x ;

        public static double F3(double x) => x * x * x;

        public static double F4(double x) => System.Math.Sin(x);

        public static double F5(double x) => System.Math.Sqrt(x);


        public static double CalcF(CalcDelegate F, double x)
        {
            return F(x);
        }  
    }
}


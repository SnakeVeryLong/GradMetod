using System;

namespace GradMetod.Function
{
    class Metods
    {
       public static double Solve(double x, double a)
        {
            double x1;

            do
            {
                x1 = a * x - Proizv(x, a);
                x = x1;
            } while (Math.Abs(x - x1) <= a);

            return x1;
        }

        /* public static double Solve(double x, double y, double a)
         {




             return;

         }*/

        public static double Proizv(double x, double a)
        {
            double  fc;
           
            

            fc = (Func(x + a) - Func(x - a)) / (2 * a);

            return fc;
        }

        public static double Proizv(double x, double y, double a)
        {
            double  fc;
          

            fc = (Func(x + a) - Func(x - a)) / (2 * a);

            return fc;
        }

        public static double Func(double x)
        {
            return Math.Sin(x) + Math.Sin(x * x);
        }

        public static double Func(double x, double y)
        {
            
            return Math.Abs(y) * Math.Abs(y) * Math.Abs(y) + Math.Abs(x) * Math.Abs(x);


        }
    }
}

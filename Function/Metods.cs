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
                x1 = a * x - Proizv();
                x = x1;
            } while (Math.Abs(x - x1) <= a);

            return x1;
        }

       /* public static double Solve(double x, double y)
        {




            return;

        }*/

        public static double Proizv()
        {
            double x, h, fc;
            x = 1; // точка, в которой вычисляем производную
            h = 0.1;

            fc = (Func(x + h) - Func(x - h)) / (2 * h);

            return fc;
        }

        

        public static double Func(double x)
        {
            return Math.Sin(x) + Math.Sin(x * x);
        }

        public static double Func(double x, double y)
        {
            return Math.Abs(x)*Math.Abs(x) + Math.Abs(y)*Math.Abs(y)*Math.Abs(y);
        }
    }
}

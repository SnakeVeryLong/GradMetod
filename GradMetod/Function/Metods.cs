using System;

namespace GradMetod.Function
{
    class Metods
    {
        public double Solve(double x, double a, int u)
        {
            double x1 = 0;

            for (int t = 0; u != t; t++)
            {
                {
                    x1 = a * x - Proizv(x, a);
                    x = x1;
                }

            }
                return x1;
            }

            public double[] Solve(double x, double y, double a, int u)
            {
                double[] x1 = { 0, 0 };
                double[] z = { x, y };

                for (int t = 0; u != t; t++) {
                    for (int i = 0; 2 != i; i++) {
                        x1[i] = a * z[i] - Proizv(x, y, a)[i];
                        z[i] = x1[i];
                    }

                }





                return x1;

            }

            public static double Proizv(double x, double a)
            {
                double fc;



                fc = (Func(x + a) - Func(x - a)) / (2 * a);

                return fc;
            }

            public static double[] Proizv(double x, double y, double a)
            {
                double fc1, fc2;


                fc1 = (Func1(x + a) - Func1(x - a)) / (2 * a);

                fc2 = (Func2(x + a) - Func2(x - a)) / (2 * a);


                double[] c = { fc1, fc2 };

                return c;
            }

            public static double Func(double x)
            {
                return Math.Sin(x) + Math.Sin(x * x);
            }

            public static double Func1(double y)
            {

                return Math.Abs(y) * Math.Abs(y) * Math.Abs(y);


            }

            public static double Func2(double x)
            {

                return Math.Abs(x) * Math.Abs(x);


            }


        }
    } 

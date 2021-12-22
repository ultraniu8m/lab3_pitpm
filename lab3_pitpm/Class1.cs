using System;

namespace lab3_pitpm
{
    public class main_vich
    {
        public int get_count(double s, double s_stanc, double r1, double r2, double r3, double K)
        {
            if (s_stanc > 0 & s>0 & r1>0 & r2>0 & r3>0 & K>0.5) 
             {
                double[] massive = new double[] { r1, r2, r3 };

                Array.Sort(massive);
                double radius = Math.Sqrt(s / Math.PI);
                double rad_stanc_ = Math.Sqrt(s_stanc / Math.PI);
                double L = Math.Pow(K * (radius / rad_stanc_), 2);
                double C = Math.Pow(2 * massive[2], 2.5) + Math.Pow(2 * massive[1], 1.5) + Math.Pow(2 * massive[0], 0.5);
                int n = Convert.ToInt32(L / C);
                Console.WriteLine(n);
                return n;
            }
            else
            {
            return -11;
            }
        }

        public int get_average_count_of_two(int n1, int n2)
        {
            int n = n1 + n2;


            return n; 
        }
    }
}

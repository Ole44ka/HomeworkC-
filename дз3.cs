using System;

namespace Integrator
{
    class Program
    {
        static void Main(string[] args)
        {
            double I_1 = Integral(x => x , 0, 5, 0.001);
            Console.WriteLine("Integral x на [0,5] = {0}", I_1);
            double I_2 = Integral(x => x*x , 0, 1, 0.001);
            Console.WriteLine("Integral x^2 на [0,1] = {0}", I_2);
            double I_3 = Integral(x => x*x*x , 0, 1, 0.001);
            Console.WriteLine("Integral x^3 на [0,1] = {0}", I_3);
            double I_4 = Integral(x => Math.Sin(2*Math.PI*x) , 0, 0.5, 0.001);
            Console.WriteLine("Integral sin(2*pi*x) на [0,0.5] = {0}", I_4);
            Console.ReadLine();
        }
        static double Integral(Func<double, double> f, double x1, double x2, double dx)
        {
            double s = 0;
            double x = x1;
            double last_f = f(x1);
            x += dx;
            while (x <= x2)
            {
                double f_val = f(x);
                s += (f_val + last_f) * dx / 2;
                last_f = f_val;
                x += dx;
            }
            return s;

        }
    }


}

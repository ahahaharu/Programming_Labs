using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    internal class Func
    {
        static public void y(double n, double k, double m, double z)
        {
            double x, y;
            if (z > 1)
            {
                Console.WriteLine("Т.к. z > 1, то x = e^z +z");
                x = Math.Exp(z) + z;
            } else
            {
                Console.WriteLine("Т.к. z <= 1, то x = z^2 + 1");
                x = z * z + 1;
            }
            y = Math.Sin(n * x) + Math.Cos(k * x) + Math.Log(m * x);
            Console.WriteLine("y = "+y);
        }
    }
}

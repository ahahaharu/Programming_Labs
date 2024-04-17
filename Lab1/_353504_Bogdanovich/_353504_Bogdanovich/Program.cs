using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Bogdanovich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a / b;

            Console.WriteLine("Quotient: " + c);
            Console.ReadLine();
        }
    }
}

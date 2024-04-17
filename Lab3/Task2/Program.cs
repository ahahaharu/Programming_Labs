using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Вариант 13\ny = sin(n*x) + cos(k*x) + ln(m*x), где\n\tx = e^z + z, при z > 1\n\tx = z^2 + 1, при z <= 1\n");

            double n, k, m, z;
            string nS, kS, mS, zS;
            Console.WriteLine("Введите n: ");
            nS = Console.ReadLine();
            while (!double.TryParse(nS, out n))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                nS = Console.ReadLine();
            }
            Console.WriteLine("Введите k: ");
            kS = Console.ReadLine();
            while (!double.TryParse(kS, out k))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                kS = Console.ReadLine();
            }
            Console.WriteLine("Введите m: ");
            mS = Console.ReadLine();
            while (!double.TryParse(mS, out m))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                mS = Console.ReadLine();
            }
            Console.WriteLine("Введите z: ");
            zS = Console.ReadLine();
            while (!double.TryParse(zS, out z))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                zS = Console.ReadLine();
            }

            Services.Func.y(n, k, m, z);
        }
    }
}

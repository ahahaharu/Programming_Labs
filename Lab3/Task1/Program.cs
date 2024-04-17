using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Вариант 3\nf(x)=x-sin(x)\n");

            double a, b;
            string aS, bS;
            Console.WriteLine("Введите значение точки a: ");
            aS = Console.ReadLine();
            while (!double.TryParse(aS, out a))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                aS = Console.ReadLine();
            }
            Console.WriteLine("Введите значение точки b: ");
            bS = Console.ReadLine();
            while (!double.TryParse(bS, out b))
            {
                Console.WriteLine("Неверный ввод! Попробуйте ещё раз: ");
                bS = Console.ReadLine();
            }

            Console.WriteLine("\tf(a) = "+Func.f(a)+"\n\tf(b) = "+Func.f(b));

            if (Func.f(a) >  Func.f(b))
            {
                Console.WriteLine("В точке a функция принимает наибольшое значение");
            } else if (Func.f(a) < Func.f(b))
            {
                Console.WriteLine("В точке b функция принимает наибольшое значение");
            } else
            {
                Console.WriteLine("В точках a и b функция принимает оиднаковое значение");
            }

            Console.ReadLine();
        }
    }
}

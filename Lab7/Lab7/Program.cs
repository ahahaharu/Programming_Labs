using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interval interval1 = new Interval(1, 5);
            Interval interval2 = new Interval(3, 7);

            // Демонстрация использования свойства Length
            Console.WriteLine($"Длина интервала1: {interval1.Length}");
            Console.WriteLine($"Длина интервала2: {interval2.Length}");

            Console.Write('\n');

            // Демонстрация работы операторов + и -
            Interval сумма = interval1 + interval2;
            Interval разность = interval1 - interval2;
            Console.WriteLine($"Сумма интервалов: {сумма}");
            Console.WriteLine($"Разность интервалов: {разность}");

            Console.Write('\n');

            // Демонстрация работы оператора *
            try
            {
                Interval пересечение = interval1 * interval2;
                Console.WriteLine($"Пересечение интервалов: {пересечение}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Write('\n');

            // Демонстрация работы операторов ++ и --
            ++interval1;
            --interval2;
            Console.WriteLine($"Расширенный интервал1: {interval1}");
            Console.WriteLine($"Суженный интервал2: {interval2}");

            Console.Write('\n');

            // Демонстрация работы операторов сравнения
            Console.WriteLine($"Равны ли интервалы? {interval1 == interval2}");
            Console.WriteLine($"Меньше ли интервал1, чем интервал2? {interval1 < interval2}");

            Console.Write('\n');

            // Демонстрация работы операторов true и false
            Console.WriteLine($"Является ли интервал1 непустым? {interval1.Length != 0}");
            Console.WriteLine($"Является ли интервал2 непустым? {interval2.Length != 0}");

            Console.Write('\n');

            // Демонстрация работы явного преобразования типа
            double length1 = (double)interval1;
            Interval interval3 = (Interval)length1;
            Console.WriteLine($"Длина интервала1: {length1}");
            Console.WriteLine($"Новый интервал из длины: {interval3}");

            Console.ReadLine();
        }
    }

}

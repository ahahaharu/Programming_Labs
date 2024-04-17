using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        public readonly int b;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Вариант 13\n");

            const int a = 123;
                    

           
            int x, y;
            string ch;
            bool isCon;

            while (true)
            {
                Console.Write("Введите x: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y: ");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Точка лежит внутри заштрихованной области?");

                if (x > 40 || x < -40 || y > 40 || y < -40)
                {
                    Console.WriteLine("Да");
                }
                else if (x < 40 && x > -40 && y < 40 && y > -40)
                {
                    Console.WriteLine("Нет");
                }
                else
                {
                    Console.WriteLine("На границе");
                }

                Console.Write("Продолжить выполнение программы?:\n\t1 - Продолжить\n\t2 - Закончить\nВведите цифру: ");
                while (true)
                {
                    ch = Console.ReadLine();

                    switch (ch)
                    {
                        case "1":
                            isCon = true;
                            break;
                        case "2":
                            isCon = false;
                            break;
                        default:
                            Console.Write("Неверный ввод! Попробуйте снова: ");
                            continue;
                    }

                    break;
                }

                if (isCon)
                {
                    Console.Write('\n');
                    continue;
                }
                else
                {
                    break;
                }
            }


        }
    }
}

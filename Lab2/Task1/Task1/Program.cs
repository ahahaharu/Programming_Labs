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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Вариант 13\n");

            int a;
            string ch;
            bool isCon;

            while (true)
            {
                Console.WriteLine("Введите трёхзначное число: ");
                a = Convert.ToInt32(Console.ReadLine());

                while (a / 1000 > 0 || a / 100 == 0 || a / 10 == 0)
                {
                    Console.Write("Неверный ввод! Введите трёхзначное число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                }

                if (a < 0)
                {
                    a = -a;
                }

                if (a / 100 > (a / 10) % 10)
                {
                    Console.WriteLine("Первая цифра числа больше, чем вторая\n");
                } else if (a / 100 < (a / 10) % 10)
                {
                    Console.WriteLine("Вторая цифра числа больше, чем первая\n");
                } else
                {
                    Console.WriteLine("Первая и вторая цифры равны");
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
                } else
                {
                    break;
                }
            }
        }
    }
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    
    internal class Program
    {
        static int intEnterCheck()
        {
            int intValue;
            string value = Console.ReadLine();
            while (!int.TryParse(value, out intValue))
            {
                Console.Write("Неверный ввод! Попробуйте снова: ");
                value = Console.ReadLine();
            }
            return intValue;
        }

        static double doubleEnterCheck()
        {
            double doubleValue;
            string value = Console.ReadLine();
            while (!double.TryParse(value, out doubleValue))
            {
                Console.Write("Неверный ввод! Попробуйте снова: ");
                value = Console.ReadLine();
            }
            return doubleValue;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string district;
            int number;
            int numOfResidents;
            int numOfPaid;
            double paymentPerMonth;

            Console.WriteLine("Вариант 3\n");
            Console.WriteLine("Создание ЖЭС");

            VES ves = VES.getInstance();

            Console.Write("\tВведите название улицы: ");
            district = Console.ReadLine();
            ves.SetDisctrict(district);

            Console.Write("\tВведите номер ЖЭСа: ");
            number = intEnterCheck();
            while (!VES.isValidNumber(number)) {
                Console.Write("Неверный ввод! Попробуйте снова: ");
                number = intEnterCheck();
            }
            ves.SetNumber(number);

            Console.Write("\tВведите число жильцов: ");
            numOfResidents = intEnterCheck();
            while (numOfResidents < 0)
            {
                Console.Write("Неверный ввод! Попробуйте снова: ");
                numOfResidents = intEnterCheck();
            }
            ves.setNumOfResidents(numOfResidents);

            Console.Write("\tВведите число оплативших в этом месяце жильцов: ");
            numOfPaid = intEnterCheck();
            while (numOfPaid < 0 || numOfPaid > numOfResidents) {
                numOfPaid = intEnterCheck();
            }
            ves.SetNumOfPaid(numOfPaid);

            Tarif tarif = new Tarif();

            Console.Write("\tВведите оплату за месяц в рублях: ");
            paymentPerMonth = doubleEnterCheck();
            while (paymentPerMonth <= 0)
            {
                Console.Write("Неверный ввод! Попробуйте снова: ");
                paymentPerMonth = doubleEnterCheck();
            }
            tarif.SetPaymentPerMonth(paymentPerMonth);
            ves.SetTarif(tarif);


            int choose;
            double value;

            while (true) {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("\t1 - Вывести информацию о ЖЭСе");
                Console.WriteLine("\t2 - Вывести общую задолженность");
                Console.WriteLine("\t3 - Увеличение тарифа");
                Console.WriteLine("\t4 - Уменьшение тарифа");
                Console.WriteLine("\t0 - Выйти из программы");

                Console.WriteLine("Введите число, чтобы выбрать: ");
                choose = intEnterCheck();
                while (choose < 0 || choose > 4)
                {
                    Console.Write("Неверный ввод! Попробуйте снова: ");
                    choose = intEnterCheck();
                }

                if (choose == 0)
                {
                    break;
                }
                else if (choose == 1)
                {
                    Console.Write("\n");
                    ves.PrintInfo();

                    Console.Write("Введите 0 чтобы вернуться в меню: ");
                    choose = intEnterCheck();
                    while (choose != 0)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    continue;
                } else if (choose == 2) {
                    Console.Write("\nОбщая задолженность в рублях: "+ ves.TotalDebt());

                    Console.Write("\nВведите 0 чтобы вернуться в меню: ");
                    choose = intEnterCheck();
                    while (choose != 0)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    continue;
                } else if (choose == 3)
                {
                    Console.WriteLine("\nКаким образом увеличить тариф?");
                    Console.WriteLine("\t1 - Увлеичить на 5 рублей");
                    Console.WriteLine("\t2 - Ввести значение самому");
                    Console.WriteLine("\t0 - Отменить и вернуться в меню");
                    Console.WriteLine("Введите число, чтобы выбрать: ");
                    choose = intEnterCheck();
                    while (choose < 0 || choose > 2)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    if (choose == 0) {
                        continue;
                    } else if (choose == 1)
                    {
                        tarif.TariffIncrease();
                    } else if (choose == 2)
                    {
                        Console.Write("\nВведите значение:");
                        value = doubleEnterCheck();
                        while (value <= 0)
                        {
                            Console.Write("Неверный ввод! Попробуйте снова: ");
                            value = doubleEnterCheck();
                        }
                        tarif.TariffIncrease(value);
                    }
                    ves.SetTarif(tarif);
                    Console.WriteLine("Оплата за месяц в данный момент: " + tarif.GetPaymentPerMonth());

                    Console.Write("\nВведите 0 чтобы вернуться в меню: ");
                    choose = intEnterCheck();
                    while (choose != 0)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    continue;
                } else if (choose == 4)
                {
                    Console.WriteLine("\nКаким образом уменьшить тариф?");
                    Console.WriteLine("\t1 - Уменьшить на 5 рублей");
                    Console.WriteLine("\t2 - Ввести значение самому");
                    Console.WriteLine("\t0 - Отменить и вернуться в меню");
                    Console.Write("Введите число, чтобы выбрать: ");
                    choose = intEnterCheck();
                    while (choose < 0 || choose > 2)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    if (choose == 0)
                    {
                        continue;
                    }
                    else if (choose == 1)
                    {
                        tarif.TariffReduction();
                    }
                    else if (choose == 2)
                    {
                        Console.Write("\nВведите значение:");
                        value = doubleEnterCheck();
                        while (value <= 0)
                        {
                            Console.Write("Неверный ввод! Попробуйте снова: ");
                            value = doubleEnterCheck();
                        }
                        tarif.TariffReduction(value);
                    }
                    ves.SetTarif(tarif);
                    Console.WriteLine("Оплата за месяц в данный момент: " + tarif.GetPaymentPerMonth());

                    Console.Write("\nВведите 0 чтобы вернуться в меню: ");
                    choose = intEnterCheck();
                    while (choose != 0)
                    {
                        Console.Write("Неверный ввод! Попробуйте снова: ");
                        choose = intEnterCheck();
                    }
                    continue;

                }
            }

        }
    }
}

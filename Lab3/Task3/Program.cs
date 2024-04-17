using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo culture = new CultureInfo("ru-RU");

            string date, dayS, monthS, yearS;
            int day, month, year;
            DateTime dateT;

            Console.WriteLine("Вычисление дня недели");
            Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
            date = Console.ReadLine();
            while (!DateTime.TryParse(date, culture, DateTimeStyles.None, out dateT)) {
                Console.WriteLine("Неверная дата или формат! Попробуйте снова: ");
                date = Console.ReadLine();
            }
            DateService.GetDay(date);

            Console.WriteLine("\nОпределение, сколько дней пройдет между текущей датой и ведённой датой");
            while (true)
            {
                Console.WriteLine("Введите номер дня в месяце: ");
                dayS = Console.ReadLine();
                while (!int.TryParse(dayS, out day) && day > 0)
                {
                    Console.WriteLine("Неверный день! Попробуйте снова: ");
                    dayS = Console.ReadLine();
                }
                Console.WriteLine("Введите номер месяца: ");
                monthS = Console.ReadLine();
                while (!int.TryParse(monthS, out month) && month > 0)
                {
                    Console.WriteLine("Неверный месяц! Попробуйте снова: ");
                    monthS = Console.ReadLine();
                }
                Console.WriteLine("Введите год:");
                yearS = Console.ReadLine();
                while (!int.TryParse(yearS, out year) && year > 0)
                {
                    Console.WriteLine("Неверный год! Попробуйте снова: ");
                    yearS = Console.ReadLine();
                }

                if (!DateTime.TryParse($"{day}/{month}/{year}", culture, DateTimeStyles.None, out dateT))
                {
                    Console.WriteLine("Введена некорректная дата. Попробуйте снова.");
                }
                else break;
            }

            DateService.GetDaysSpan(day, month, year);
        }
    }
}

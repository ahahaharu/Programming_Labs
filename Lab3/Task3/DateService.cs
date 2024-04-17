using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class DateService
    {
        public static void GetDay(string date)
        {
            DateTime dateT;
            DateTime.TryParse(date, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out dateT);
            Console.WriteLine("Day of week: "+dateT.DayOfWeek);
        }

        public static void GetDaysSpan(int day, int month, int year)
        {

            DateTime date = new DateTime(year, month, day);

            DateTime dateNow = DateTime.Now;
            double dur = Math.Abs((date - dateNow).TotalDays);

            Console.WriteLine("Количество дней между текущей датой и введённлй датой: " + (int)dur);
        }
    }
}

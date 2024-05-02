using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public sealed class Wine : AlcoholicBeverage
    {
        public string Variety { get; set; }

        public Wine(string name, double strength, string variety)
            : base(name, strength)
        {
            Variety = variety;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название вина: {Name}, Крепкость: {Strength}, Сорт: {Variety}");
        }

        public new void Open()
        {
            Console.WriteLine("Вино открыто штопором.");
        }
    }
}

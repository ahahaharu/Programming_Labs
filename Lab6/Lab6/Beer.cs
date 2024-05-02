using System;

namespace Lab6
{
    public class Beer : AlcoholicBeverage
    {
        public string Color { get; set; }

        public Beer(string name, double strength, string color)
            : base(name, strength)
        {
            Color = color;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Название пива: {Name}, Крепкость: {Strength}, Цвет: {Color}");
        }

        public override void Open()
        {
            Console.WriteLine("Пиво открыто открывашкой.");
        }

        public override void Serve()
        {
            Console.WriteLine("Пиво подаётся охлаждённым.");
        }
    }
}

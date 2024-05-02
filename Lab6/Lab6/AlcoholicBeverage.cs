using System;

namespace Lab6
{
    public abstract class AlcoholicBeverage
    {
        public string Name { get; set; }
        public double Strength;

        double getStrength()
        {
            return Strength;
        }

        void setStrength(double strength)
        {
            if (strength <= 100 && strength >= 0)
            {
                Strength = strength;
            }
        }

        public AlcoholicBeverage(string name, double strength)
        {
            Name = name;
            if (strength <= 100 && strength >= 0)
            {
                Strength = strength;
            }
        }

        public abstract void DisplayInfo();

        public virtual void Open()
        {
            Console.WriteLine("Напиток открыт");
        }

        public virtual void Serve()
        {
            Console.WriteLine("Напиток подаётся комнатной температуры.");
        }
    }
}

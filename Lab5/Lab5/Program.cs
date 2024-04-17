using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VES ves = new VES();

            ves.Tariffs.Add(new Tariff { Utility = UtilityType.Water, Rate = 3.5 });
            ves.Tariffs.Add(new Tariff { Utility = UtilityType.Electricity, Rate = 2.8 });
            ves.Tariffs.Add(new Tariff { Utility = UtilityType.Gas, Rate = 1.7 });

            Resident resident1 = new Resident { Name = "Богданович" };
            resident1.ConsumedUtilities.Add(UtilityType.Water, 10);
            resident1.ConsumedUtilities.Add(UtilityType.Electricity, 15);
            resident1.ConsumedUtilities.Add(UtilityType.Gas, 12);

            Resident resident2 = new Resident { Name = "Петров" };
            resident2.ConsumedUtilities.Add(UtilityType.Water, 8);
            resident2.ConsumedUtilities.Add(UtilityType.Electricity, 20);
            resident2.ConsumedUtilities.Add(UtilityType.Gas, 10);

            ves.Residents.Add(resident1);
            ves.Residents.Add(resident2);

            Console.WriteLine("Стоимость всех потребленных услуг жителя " + resident1.Name + ": " + ves.CalculateTotalCost(resident1));
            Console.WriteLine("Стоимость всех потребленных услуг жителя " + resident2.Name + ": " + ves.CalculateTotalCost(resident2));
            Console.WriteLine("Стоимость всех оказанных услуг: " + ves.CalculateTotalProvidedServices());

            Console.ReadLine();
        }
    }
}

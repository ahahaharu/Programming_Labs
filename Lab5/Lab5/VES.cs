using System.Collections.Generic;


namespace Lab5
{
    public enum UtilityType
    {
        Water,
        Electricity,
        Gas
    }

    public class Tariff
    {
        public UtilityType Utility { get; set; }
        public double Rate { get; set; }
    }

    public class Resident
    {
        public string Name { get; set; }
        public Dictionary<UtilityType, double> ConsumedUtilities { get; set; }

        public Resident()
        {
            ConsumedUtilities = new Dictionary<UtilityType, double>();
        }
    }

    public class VES
    {
        public List<Tariff> Tariffs { get; set; }
        public List<Resident> Residents { get; set; }

        public VES()
        {
            Tariffs = new List<Tariff>();
            Residents = new List<Resident>();
        }

        public double CalculateTotalCost(Resident resident)
        {
            double totalCost = 0;

            foreach (var utility in resident.ConsumedUtilities)
            {
                var tariff = Tariffs.Find(t => t.Utility == utility.Key);
                totalCost += tariff.Rate * utility.Value;
            }

            return totalCost;
        }

        public double CalculateTotalProvidedServices()
        {
            double totalCost = 0;

            foreach (var resident in Residents)
            {
                totalCost += CalculateTotalCost(resident);
            }

            return totalCost;
        }
    }
}

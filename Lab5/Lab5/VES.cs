using System.Collections.Generic;


namespace Lab5
{

    public class VES
    {
        public List<Tariff> Tariffs;
        public List<Resident> Residents;

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

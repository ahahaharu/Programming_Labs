using System;
using System.Collections.Generic;

namespace Lab5
{
    public class Resident
    {
        public string Name { get; set; }
        public Dictionary<UtilityType, double> ConsumedUtilities { get; set; }

        public Resident()
        {
            ConsumedUtilities = new Dictionary<UtilityType, double>();
        }
    }
}

using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Classes
{
    class RentCalculator : IRentCalculator
    {
        private IRentCalculationStrategy _strategy;

        public RentCalculator(IRentCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateAverageRent(List<ITenantType> tenantTypes)
        {
            return _strategy.CalculateAverageRent(tenantTypes);
        }
    }
}

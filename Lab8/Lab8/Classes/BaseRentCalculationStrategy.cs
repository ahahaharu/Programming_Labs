using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Classes
{
    class BaseRentCalculationStrategy : IRentCalculationStrategy
    {
        public decimal CalculateAverageRent(List<ITenantType> tenantTypes)
        {
            decimal totalRent = 0;
            foreach (ITenantType tenantType in tenantTypes)
            {
                totalRent += tenantType.BaseRent;
            }
            return totalRent / tenantTypes.Count;
        }
    }
}

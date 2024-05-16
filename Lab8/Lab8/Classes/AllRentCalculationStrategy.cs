using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Classes
{
    class AllRentCalculationStrategy : IRentCalculationStrategy
    {
        public decimal CalculateAverageRent(List<ITenantType> tenantTypes)
        {
            decimal totalRent = 0;
            foreach (ITenantType tenantType in tenantTypes)
            {
                totalRent += tenantType.BaseRent - (tenantType.BaseRent * tenantType.Discount / 100);
            }
            return totalRent / tenantTypes.Count;
        }
    }
}

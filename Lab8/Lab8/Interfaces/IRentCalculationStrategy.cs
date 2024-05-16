using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Interfaces
{
    interface IRentCalculationStrategy
    {
        decimal CalculateAverageRent(List<ITenantType> tenantTypes);
    }
}

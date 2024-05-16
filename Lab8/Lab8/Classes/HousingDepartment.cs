using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Classes
{
    class HousingDepartment
    {
        private List<ITenantType> _tenantTypes = new List<ITenantType>();
        private IRentCalculator _rentCalculator;

        public HousingDepartment(IRentCalculator rentCalculator)
        {
            _rentCalculator = rentCalculator;
        }

        public void AddTenantType(ITenantType tenantType)
        {
            _tenantTypes.Add(tenantType);
        }

        public decimal CalculateAverageRent()
        {
            return _rentCalculator.CalculateAverageRent(_tenantTypes);
        }
    }
}

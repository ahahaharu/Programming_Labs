using Lab8.Classes;
using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITenantType tenantType1 = new TenantType { Name = "Льготник", BaseRent = 1000, Discount = 10 };
            ITenantType tenantType2 = new TenantType { Name = "Обычный жилец", BaseRent = 1500, Discount = 0 };

            IRentCalculator allRentCalculator = new RentCalculator(new AllRentCalculationStrategy());
            HousingDepartment housingDepartment1 = new HousingDepartment(allRentCalculator);

            housingDepartment1.AddTenantType(tenantType1);
            housingDepartment1.AddTenantType(tenantType2);

            decimal averageRent1 = housingDepartment1.CalculateAverageRent();
            Console.WriteLine($"Средняя стоимость аренды для всех типов жильцов: {averageRent1}");

            IRentCalculator baseRentCalculator = new RentCalculator(new BaseRentCalculationStrategy());
            HousingDepartment housingDepartment2 = new HousingDepartment(baseRentCalculator);

            housingDepartment2.AddTenantType(tenantType1);
            housingDepartment2.AddTenantType(tenantType2);

            decimal averageRent2 = housingDepartment2.CalculateAverageRent();
            Console.WriteLine($"Средняя стоимость аренды без учета льгот: {averageRent2}");

            Console.ReadKey();
        }
    }
}

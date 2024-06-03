using Lab9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class MonolithicWallsCompany : BuildingCompanyBase, ICustomerConsultant
    {
        public MonolithicWallsCompany(string name, CompanyType type, IWallBuilder wallBuilder)
            : base(name, type, wallBuilder) { }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} - это компания типа {Type}, которая строит монолитные стены.");
        }

        public void ConsultCustomer()
        {
            Console.WriteLine($"{Name} консультирует заказчика.");
        }
    }
}

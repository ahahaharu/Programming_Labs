using Lab9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class BrickWallsCompany : BuildingCompanyBase, IMaterialSupplier
    {
        public BrickWallsCompany(string name, CompanyType type, IWallBuilder wallBuilder)
            : base(name, type, wallBuilder) { }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} - это компания типа {Type}, которая строит кирпичные стены.");
        }

        public void SupplyMaterials()
        {
            Console.WriteLine($"{Name} поставляет материалы для строительства.");
        }
    }
}

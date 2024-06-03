using Lab9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class FoamBlocksCompany : BuildingCompanyBase, IProjectDeveloper
    {
        public FoamBlocksCompany(string name, CompanyType type, IWallBuilder wallBuilder)
            : base(name, type, wallBuilder) { }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} - это компания типа {Type}, которая строит стены из пеноблоков.");
        }

        public void DevelopProject()
        {
            Console.WriteLine($"{Name} разрабатывает строительный проект.");
        }
    }
}

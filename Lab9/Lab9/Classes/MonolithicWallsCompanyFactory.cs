using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class MonolithicWallsCompanyFactory : BuildingCompanyFactory
    {
        public override BuildingCompanyBase CreateCompany(string name, CompanyType type)
        {
            return new MonolithicWallsCompany(name, type, new MonolithicWallBuilder());
        }
    }
}

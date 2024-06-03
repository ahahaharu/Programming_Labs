using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class BrickWallsCompanyFactory : BuildingCompanyFactory
    {
        public override BuildingCompanyBase CreateCompany(string name, CompanyType type)
        {
            return new BrickWallsCompany(name, type, new BrickWallBuilder());
        }
    }
}

using Lab9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public abstract class BuildingCompanyBase : IBuildingCompany
    {
        public string Name { get; set; }
        public CompanyType Type { get; set; }
        protected IWallBuilder WallBuilder { get; set; }

        protected BuildingCompanyBase(string name, CompanyType type, IWallBuilder wallBuilder)
        {
            Name = name;
            Type = type;
            WallBuilder = wallBuilder;
        }

        public abstract void GetInfo();

        public void BuildWalls()
        {
            WallBuilder.BuildWalls(Name);
        }
    }
}

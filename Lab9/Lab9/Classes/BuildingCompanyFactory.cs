﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public abstract class BuildingCompanyFactory
    {
        public abstract BuildingCompanyBase CreateCompany(string name, CompanyType type);
    }
}

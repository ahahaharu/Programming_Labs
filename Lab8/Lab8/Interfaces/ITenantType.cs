using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Interfaces
{
    interface ITenantType
    {
        string Name { get; set; }
        decimal BaseRent { get; set; }
        decimal Discount { get; set; }
    }
}

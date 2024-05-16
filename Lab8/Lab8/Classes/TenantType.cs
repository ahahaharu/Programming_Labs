using Lab8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Classes
{
    public class TenantType : ITenantType
    {
        public string Name { get; set; }
        public decimal BaseRent { get; set; }
        public decimal Discount { get; set; }
    }
}

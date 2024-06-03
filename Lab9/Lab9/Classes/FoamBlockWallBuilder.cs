using Lab9.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Classes
{
    public class FoamBlockWallBuilder : IWallBuilder
    {
        public void BuildWalls(string companyName)
        {
            Console.WriteLine($"{companyName} строит стены из пеноблоков.");
        }
    }
}

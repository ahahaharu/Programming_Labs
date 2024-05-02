using System;
using System.Text;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Beer beer = new Beer("Miller", 5.0, "Тёмное");
            beer.DisplayInfo();
            beer.Serve();
            beer.Open();

            Console.Write("\n");

            Wine wine = new Wine("Martini", 13.5, "Белое сухое");
            wine.DisplayInfo();
            wine.Open();

            Console.Write("\n");

            ((AlcoholicBeverage)wine).Open();
        }
    }
}

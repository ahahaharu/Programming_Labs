using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class VES
    {
        private static VES instance = null;
        private string district;
        private int number;
        private int numOfResidents;
        private int numOfPaid;
        public Tarif tarif;

        private VES() { }

        public static VES GetInstance()
        {
                if (instance == null)
                {
                    instance = new VES();
                }
                return instance;
        }

        public void SetDisctrict(string disctrict)
        {
            this.district = disctrict;
        }

        public string GetDisctrict() { 
            return this.district;
        }

        public void SetNumber(int number) {
            this.number = number;
        }

        public int GetNumber() { 
            return this.number;
        }

        public void setNumOfResidents(int numOfResidents)
        {
            this.numOfResidents = numOfResidents;
        }

        public int GetNumOfResidents()
        {
            return this.numOfResidents;
        }

        public void SetNumOfPaid(int numOfPaid)
        {
            this.numOfPaid = numOfPaid;
        }

        public int GetNumOfPaid() { 
            return this.numOfPaid;
        }

        public void SetTarif(Tarif tarif)
        {
            this.tarif = tarif;
        }
        
        public double getPayMentPerMounth()
        {
            return tarif.GetPaymentPerMonth();
        }

        public double TotalDebt()
        {
            return (numOfResidents - numOfPaid)*tarif.GetPaymentPerMonth();
        }

        public void PrintInfo()
        {
            Console.WriteLine("ЖЭС");
            Console.WriteLine("\tУлица: "+district);
            Console.WriteLine("\tНомер ЖЭСа: " + number);
            Console.WriteLine("\tЧисло жильцов: "+numOfResidents);
            Console.WriteLine("\tЧисло оплативших: " + numOfPaid);
            Console.WriteLine("\tОплата тарифа в месяц (в рублях): " + tarif.GetPaymentPerMonth());
        }

        public static bool isValidNumber(int number)
        {
            if (number < 0)
            {
                return false;
            }
            else return true;
        }
    }
}

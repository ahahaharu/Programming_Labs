using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Tarif
    {
        private double paymentPerMonth;

        public void SetPaymentPerMonth(double paymentPerMonth)
        {
            this.paymentPerMonth = paymentPerMonth;
        }
        public double GetPaymentPerMonth()
        {
            return paymentPerMonth;
        }
        public void TariffIncrease(double increase)
        {
            paymentPerMonth += increase;
        }

        public void TariffIncrease()
        {
            paymentPerMonth += 5;
        }
        public void TariffReduction(double reduction)
        {
            paymentPerMonth -= reduction;
        }

        public void TariffReduction()
        {
            paymentPerMonth -= 5;
        }
        
        
    }
}

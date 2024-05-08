using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Exercitii.PaymentMethod
{
    public class Cash
    {
        public double Amount { get; private set; }

        public Cash(double amount)
        {
            Amount = amount;
        }
    }
}

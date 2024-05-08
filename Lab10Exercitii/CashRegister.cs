using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Exercitii.PaymentMethod;

namespace Lab10Exercitii
{
    public class CashRegister
    {
        private CashPayment cashPayment;
        private Pos pos;

        public CashRegister()
        {
            pos = new Pos();
        }

        public void ScanProduct(string productName)
        {
            Console.WriteLine($"Scanning product: {productName}");
        }

        public void AcceptCashPayment(double amount)
        {
            Cash cash = new Cash(amount);
            cashPayment = new CashPayment(cash);
            cashPayment.ProcessPayment(amount);
            Console.WriteLine($"Opening safe...");
            Console.WriteLine($"Inserting ${amount} into the safe...");
            Console.WriteLine($"Closing safe...");
            Console.WriteLine($"Printing receipt...\n");
        }

        public IPos GetPos()
        {
            return pos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Exercitii.PaymentMethod;

namespace Lab10Exercitii
{
    public class CashPayment : Payment
    {
        public CashPayment(Cash amount) : base(amount)
        {
        }
    }
}



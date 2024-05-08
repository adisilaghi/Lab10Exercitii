using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Exercitii.PaymentMethod
{
    public class Contactless : Payment
    {
        public Contactless(Cash amount) : base(amount)
        {
        }
    }
}

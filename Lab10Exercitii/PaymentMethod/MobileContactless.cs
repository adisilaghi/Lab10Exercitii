using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Exercitii.PaymentMethod
{
    public class MobileContactless : Contactless
    {
        public MobileContactless(Cash amount) : base(amount)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class PurchaseItem//:Product
    {
        private float itemQuantity;
        private float itemSubtotal;

        public float ItemQuantity { get => itemQuantity; set => itemQuantity = value; }
        public float ItemSubtotal { get => itemSubtotal; set => itemSubtotal = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class PurchaseCart
    {
        private static List<PurchaseItem> purchaseCartList;

        internal static List<PurchaseItem> PurchaseCartList { get => purchaseCartList; set => purchaseCartList = value; }
    }
}

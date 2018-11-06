using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingSystem
{
    class ItemInTable: PurchaseItem
    {
        private int slNo;

        public int SlNo { get => slNo; set => slNo = value; }
    }
}
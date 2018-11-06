using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BillingSystem
{
    public class Sales
    {
        private static int transactionId = 0;
        private int employeeId;
        private int customerId;
        private float totalPrice;

        PurchaseCart purchaseCart;

        private DateTime dateOfPurchase;

        public Sales()
        {
            transactionId += 1;
            totalPrice = 0;
        }

        public void processSales(Table table)
        {
            
            PurchaseCart.PurchaseCartList = new List<PurchaseItem>();
            SalesDB.salesList.Add(generateSalesObject(table));
        }

        //TODO
        //Get Employee id from pradeep and decide where to get customer id
        public Sales generateSalesObject(Table table)
        {
            employeeId = 100;
            customerId = 1234567890;
            dateOfPurchase = DateTime.Now.Date;

            GetDataFromTableIntoPurchaseItem(table);
            CalculateTotalPrice();

            return this;
        }

        public void GetDataFromTableIntoPurchaseItem(Table table)
        {
            int rowNumber = 0;
            int columnNumber = 0;

            SalesStart salesStart = new SalesStart();

            TableRowCollection salesTableRows = table.Rows;

            for (int i = 1; i < salesTableRows.Count; i++)
            {
                TableRow tableRow = salesTableRows[i];

                rowNumber += 1;

                PurchaseItem purchaseItem = new PurchaseItem();
                ArrayList arrayList = new ArrayList(); 

                TableCellCollection tableCellCollection = tableRow.Cells;
            
                foreach (TableCell tableCell in tableCellCollection)
                {
                    columnNumber += 1;
                    System.Web.UI.WebControls.TextBox textBox = (System.Web.UI.WebControls.TextBox)tableCell.FindControl("TextBox0" + rowNumber + columnNumber);
                    arrayList.Add(textBox.Text);
                }

                purchaseItem.ItemQuantity = Int32.Parse((string)arrayList[3]);
                purchaseItem.ItemSubtotal = Int32.Parse((string)arrayList[5]);

                PurchaseCart.PurchaseCartList.Add(purchaseItem);
            }
        }

        public void CalculateTotalPrice()
        {
            totalPrice = 0;

            foreach (PurchaseItem item in PurchaseCart.PurchaseCartList)
            {
                totalPrice += item.ItemSubtotal;
            }
        }
    }
}
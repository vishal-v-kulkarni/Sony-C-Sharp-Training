using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class Bill_Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            custname.Text = "Suresh";
            billnum.Text = "2";
            date.Text = DateTime.Now.ToLongDateString().ToString();
            time.Text = DateTime.Now.ToShortTimeString().ToString();

            List<PurchaseItem> pc = new List<PurchaseItem>();
            pc = PurchaseCart.PurchaseCartList;

            Table a = (Table)FindControl("billtable");
            int i = 0;
            
            for(int iCounter=0;iCounter<4;iCounter++)
            {
                
                //Create a tablerow
                TableRow tablerow = new TableRow();

                //Create the table cells 
                TableCell tableCell1 = new TableCell();
                tableCell1.Text = i.ToString();
                TableCell tableCell2 = new TableCell();
                tableCell2.Text = "Book";
                TableCell tableCell3 = new TableCell();
                tableCell3.Text = "2";//pi.ItemQuantity.ToString();
                TableCell tableCell4 = new TableCell();
                tableCell4.Text = "30";
                TableCell tableCell5 = new TableCell();
                tableCell5.Text = "9%";
                TableCell tableCell6 = new TableCell();
                tableCell6.Text = "60";//pi.ItemSubtotal.ToString();

                tablerow.Cells.Add(tableCell1);
                tablerow.Cells.Add(tableCell2);
                tablerow.Cells.Add(tableCell3);
                tablerow.Cells.Add(tableCell4);
                tablerow.Cells.Add(tableCell5);
                tablerow.Cells.Add(tableCell6);

                a.Rows.Add(tablerow);

                i++;
            }
           
        }
    }
}
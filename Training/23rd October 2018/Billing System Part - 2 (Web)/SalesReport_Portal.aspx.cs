using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class SalesReport_Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Sales> sales = new List<Sales>();
            sales = SalesDB.salesList;

            Table a = (Table)FindControl("salestable");
            int i = 0;

            foreach (Sales s in sales)
            {
                //Create a tablerow
                TableRow tablerow = new TableRow();

                //Create the table cells 
                TableCell tableCell1 = new TableCell();
                tableCell1.Text = i.ToString();
                TableCell tableCell2 = new TableCell();
                tableCell2.Text = "Vishal";
                TableCell tableCell3 = new TableCell();
                tableCell3.Text = "Book";//pi.ItemQuantity.ToString();
                TableCell tableCell4 = new TableCell();
                tableCell4.Text = "3";
                TableCell tableCell5 = new TableCell();
                tableCell5.Text = "30";
                TableCell tableCell6 = new TableCell();
                tableCell6.Text = "12th Sep 2018";//pi.ItemSubtotal.ToString();

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

        protected void searchdate_Click(object sender, EventArgs e)
        {
            List<Sales> sales = new List<Sales>();
            sales = SalesDB.salesList;

            Table a = (Table)FindControl("salestable");
            int i = 0;


        }
    }
}
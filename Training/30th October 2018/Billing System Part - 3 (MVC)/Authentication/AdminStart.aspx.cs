using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class AdminStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ManageUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageUser.aspx");
        }

        protected void SalesReort_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Report/SalesReport_Portal.aspx");
        }

        protected void EmployeeReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Report/EmployeeReport_Portal.aspx");
        }

        protected void DoSales_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Sales/SalesStart.aspx");
        }

        protected void Inventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Inventory/Inventory.aspx");
        }
    }
}
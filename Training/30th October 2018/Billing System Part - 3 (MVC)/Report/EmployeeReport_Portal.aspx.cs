using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class EmployeeReport_Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Sales> salesList = new List<Sales>();
            salesList = SalesDB.salesList;

            /*int empCount = (from sales in salesList
                           where sales.employeeId == "Vishal"
                           select sales).Count();*/

            
        }
    }
}
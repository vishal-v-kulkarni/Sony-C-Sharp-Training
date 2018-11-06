using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Manage(object sender, EventArgs e)
        {
            Response.Redirect("ManageProducts.aspx");
        }

        protected void listproducts_Click(object sender, EventArgs e)
        {
            DBConnection dbcon = new DBConnection();

            string modquerrypid = string.Format("Select p.pid,p.pname,p.price,p.pgst,i.Quantity,i.Expiry from [Billing_DB].[dbo].[Product_Table] p join [Billing_DB].[dbo].[Inventory_Table] i on p.pid=i.pid");

            SqlCommand sqlCommand = new SqlCommand(modquerrypid, dbcon.sqlcon);
            SqlDataReader sr = sqlCommand.ExecuteReader();

            DataTable tt = new DataTable();

            tt.Load(sr);

            GridView1.DataSource = tt;

            GridView1.DataBind();

        }
    }
}
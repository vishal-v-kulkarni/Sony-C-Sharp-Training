using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class DBConnection : System.Web.UI.Page
    {
        public DBConnection()
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["Billing_DBConnectionString2"].ConnectionString);
            sqlcon.Open();
        }
        ~DBConnection()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
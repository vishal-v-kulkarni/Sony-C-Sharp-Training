using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connect to the database

        }
         protected void userId_TextChanged(object sender, EventArgs e)
        {


        }

        protected void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UserLogin(object sender, EventArgs e)
        {
            //Add validations to the input fields
            string query = string.Format("select uID,uPassword,utype from User_Table where uid={0}",userid.Text);

            DBConnection dbcon = new DBConnection();
            SqlCommand sqlCommand = new SqlCommand(query, dbcon.sqlcon);

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (!dr.HasRows)
            {
                Response.Write("UserID does not exist");
                return;
            }
            while (dr.Read())
            {
                //Response.Write(dr["uid"].ToString() + "<br/>");

                if(dr["uid"].ToString()==userid.Text && dr["upassword"].ToString() == password.Value)
                {
                    if (Convert.ToInt32(dr["utype"]) == 1)
                    {
                        Response.Redirect("AdminStart.aspx");
                    }
                    else
                    {
                        Response.Redirect("../Sales/SalesStart.aspx");
                    }
                }
                else
                {
                    Response.Write("Invalid Credentials");
                }

            }

            Session["userid"] = userid.Text;
            Session["password"] = password.Value;

            //Fetch the database records to check whether userid is present, if present then create the object
            //Object.uType is Admin open Admin portal else User Portal

            //Response.Redirect("AdminStart.aspx");
        }
    }
}
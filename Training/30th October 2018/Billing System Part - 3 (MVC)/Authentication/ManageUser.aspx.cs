using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class ManageUser : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adduserbtn_Click(object sender, EventArgs e)
        {
            string addUserQuery = string.Format("Insert into User_Table values({0},'{1}','{2}','{3}','{4}',{5})", userid.Text, username.Text,
                email.Text, mobile.Text, password.Text, utype.Text);

            DBConnection dbcon = new DBConnection();

            SqlCommand sqlCommand = new SqlCommand(addUserQuery, dbcon.sqlcon);
            sqlCommand.ExecuteNonQuery();


            //Fetch the details of the user and INSERT into database
        }

        protected void updateuserbtn_Click(object sender, EventArgs e)
        {
            string updateUserQuery = string.Format("Update User_Table set uName='{0}',uEmail='{1}',uPhone='{2}',uPassword='{3}',uType={4} where uID = {5}",username.Text,
                email.Text, mobile.Text, password.Text, utype.Text,userid.Text);

            DBConnection dbcon = new DBConnection();

            SqlCommand sqlCommand = new SqlCommand(updateUserQuery, dbcon.sqlcon);
            sqlCommand.ExecuteNonQuery();
            //Fetch the details of the user for particular ID and UPDATE the row in database
        }

        protected void deleteuserbtn_Click(object sender, EventArgs e)
        {
            string deleteUserQuery = string.Format("Delete from User_Table where uID={0}",userid.Text);
            DBConnection dbcon = new DBConnection();

            SqlCommand sqlCommand = new SqlCommand(deleteUserQuery,dbcon.sqlcon);
            sqlCommand.ExecuteNonQuery();

            //Fetch the details of the user for particular ID and DELETE the row in database
        }


    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BillingSystem
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Btn_Click(object sender, EventArgs e)
        {
            DBConnection dbcon = new DBConnection();

            bool pidexist = false;
            string querrypid = string.Format("Select * from Product_Table where pid={0}", pid.Text);

            SqlCommand sqlCommand = new SqlCommand(querrypid, dbcon.sqlcon);
            SqlDataReader sr=sqlCommand.ExecuteReader();

            if (sr.HasRows)
            {
                string querryiid = string.Format("Select quantity from Inventory_Table where pid={0}", pid.Text);
                sr.Close();
                sqlCommand = new SqlCommand(querryiid, dbcon.sqlcon);
                SqlDataReader sd = sqlCommand.ExecuteReader();
                sd.Read();
                int exquant =(int) sd["quantity"];
                pidexist = true;

                string UpdateQuerry = string.Format("Update Inventory_Table set quantity={0},expiry='{1}' where pid={2}", Int32.Parse(quantity.Text)+exquant, expiry.Text, pid.Text);
                sd.Close();
                sqlCommand = new SqlCommand(UpdateQuerry, dbcon.sqlcon);
                sqlCommand.ExecuteNonQuery();

            }


            else
            {
                sr.Close();
                string addProductQuery = string.Format("Insert into Product_Table values({0},'{1}',{2},{3})", pid.Text, pname.Text,
                    price.Text, gst.Text);


                string addInventoryQuery = string.Format("Insert into Inventory_Table values({0},{1},'{2}')", pid.Text, quantity.Text,
                    expiry.Text);



                sqlCommand = new SqlCommand(addProductQuery, dbcon.sqlcon);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand(addInventoryQuery, dbcon.sqlcon);
                sqlCommand.ExecuteNonQuery();
            }
        }

        protected void pid_TextChanged(object sender, EventArgs e)
        {
                
        }

        protected void Del_Btn_Click(object sender, EventArgs e)
        {
            DBConnection dbcon = new DBConnection();

            bool pidexist = false;
            string querrypid = string.Format("Select * from Product_Table where pid={0}", pid.Text);

            SqlCommand sqlCommand = new SqlCommand(querrypid, dbcon.sqlcon);
            SqlDataReader sr = sqlCommand.ExecuteReader();

            if (sr.HasRows)
            {
                string querryiid = string.Format("Select quantity from Inventory_Table where pid={0}", pid.Text);
                sr.Close();
                sqlCommand = new SqlCommand(querryiid, dbcon.sqlcon);
                SqlDataReader sd = sqlCommand.ExecuteReader();
                sd.Read();
                int exquant = (int)sd["quantity"];
                pidexist = true;
                int newquant = exquant - Int32.Parse(quantity.Text);
                if(newquant<0)
                {
                    newquant = 0;
                }
                string UpdateQuerry = string.Format("Update Inventory_Table set quantity={0} where pid={1}", newquant,pid.Text);
                sd.Close();
                sqlCommand = new SqlCommand(UpdateQuerry, dbcon.sqlcon);
                sqlCommand.ExecuteNonQuery();

            }

        }

        protected void Mod_Btn_Click(object sender, EventArgs e)
        {
            DBConnection dbcon = new DBConnection();

            string modquerrypid = string.Format("Update Product_Table set pname='{0}',price={1},pgst={2} where pid={3}", pname.Text,price.Text,gst.Text,pid.Text);

            SqlCommand sqlCommand = new SqlCommand(modquerrypid, dbcon.sqlcon);
            sqlCommand.ExecuteNonQuery();

        }
    }
}
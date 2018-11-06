using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseTablesView
{
    public partial class Tables : System.Web.UI.Page
    {
        static public int flag = 0; 
        SqlConnection sqlcon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["SalesConnectionString"].ConnectionString);
            sqlcon.Open();
            if (!IsPostBack) //for previous programs delete this
            {

                //SQL Select query using ExecuteScalar() //its for count(),sum()
                string query1 = "select * from Product";
                //string nonquery = "insert into product values(5,'Pencil',10)";
                SqlCommand sql = new SqlCommand(query1, sqlcon);
                //int count = (int)sql.ExecuteScalar();
                //Response.Write("No of Rows in the table:" + count);

                //SQL Select query using ExecuteReader()

                /*SqlDataReader result;
                result = sql.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                       Response.Write(result[0].ToString() + result[1].ToString() + result[2].ToString() + "<br/>");
                    }
                }
                */

                //SQL Insert query using ExecuteNonQuery()
                //int count = sql.ExecuteNonQuery();

                // Response.Write("No. of rows affected : " + count);


                //Load the table into a Local DataTable and print
                /*SqlDataReader result;
                result = sql.ExecuteReader();
                DataTable tb1 = new DataTable();
                tb1.Load(result);

                var rows = tb1.AsEnumerable().Where(n => n.Field<int>(2) > 10);

                DataTable tb2 = rows.CopyToDataTable();

                foreach(DataRow r in tb2.Rows)
                {
                    Response.Write(r.Field<int>(0) + r.Field<string>(1) + r.Field<int>(2) + "<br/>");
                }*/

                //Program for printing/inserting/updating/deleting products

                SqlDataReader result;
                result = sql.ExecuteReader();
                DataTable tb1 = new DataTable();
                tb1.Load(result);

                Application["DataTable"] = tb1;
                Application["index"] = 0;

                sqlcon.Close();
            }
            if(flag == 0)
            {
                DataTable tb2 = (DataTable)Application["DataTable"];
                int index = (int)Application["index"];

                if (index == 0)
                {
                    prev.Enabled = false;
                }
                else
                {
                    prev.Enabled = true;
                }

                pid.Text = tb2.Rows[index].Field<int>(0).ToString();
                pname.Text = tb2.Rows[index].Field<string>(1).ToString();
                price.Text = tb2.Rows[index].Field<int>(2).ToString();


            }
           
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control c = new Control();
            c = FindControl("div1");
            Label label = new Label();
            label.Text = "Price of the item : " + ListBox1.SelectedItem.Text + " is " + ListBox1.SelectedItem.Value;
            c.Controls.Add(label);
        }

        protected void prev_Click(object sender, EventArgs e)
        {
            DataTable tb2 = (DataTable)Application["DataTable"];
            int index = (int)Application["index"];
            index--;
            Application["index"] = index;

            EnableDisableButtons(index, tb2.Rows.Count);

            pid.Text = tb2.Rows[index].Field<int>(0).ToString();
            pname.Text = tb2.Rows[index].Field<string>(1).ToString();
            price.Text = tb2.Rows[index].Field<int>(2).ToString();
        }

        protected void next_Click(object sender, EventArgs e)
        {
            DataTable tb2 = (DataTable)Application["DataTable"];
            int index = (int)Application["index"];
            index++;
            Application["index"] = index;

            EnableDisableButtons(index, tb2.Rows.Count);

            pid.Text = tb2.Rows[index].Field<int>(0).ToString();
            pname.Text = tb2.Rows[index].Field<string>(1).ToString();
            price.Text = tb2.Rows[index].Field<int>(2).ToString();
        }

        public void EnableDisableButtons(int index,int rowcount)
        {
            if (index == 0)
            {
                prev.Enabled = false;
            }
            else
            {
                prev.Enabled = true;
            }
            if (index == rowcount-1)
            {
                next.Enabled = false;
            }
            else
            {
                next.Enabled = true;
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            if (edit.Text=="Edit")
            {
                pname.ReadOnly = false;
                price.ReadOnly = false;

                edit.Text = "Update";
                flag = 1;
            }
            else
            {
                string updateQuery = "UPDATE Product SET pname='" + pname.Text + "',price=" + price.Text + "WHERE pid=" + pid.Text;
                SqlCommand sql = new SqlCommand(updateQuery, sqlcon);

                int count = sql.ExecuteNonQuery();

                text1.Text = count.ToString();

                edit.Text = "Edit";
                pname.ReadOnly = true;
                price.ReadOnly = true;

                flag = 0;
            }
            

        }
    }
}
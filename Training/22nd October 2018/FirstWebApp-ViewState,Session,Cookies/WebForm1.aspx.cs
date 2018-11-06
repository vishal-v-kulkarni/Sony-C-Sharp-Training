using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //static int result1=0;
        static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                num1.Text = "0";
                num2.Text = "0";
            }
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            int oldvalue = 0, newvalue = 0;

            // Using View State
            /*
            if (ViewState["oldsum"] != null)
            {
                oldvalue = int.Parse(ViewState["oldsum"].ToString());

            }
            newvalue = oldvalue + int.Parse(num1.Text) + int.Parse(num2.Text);
            Result.Text = (newvalue).ToString();
            ViewState["oldsum"] = newvalue;
            */

            //Using Session Object

            /*if (Session["oldsum"] != null)
            {
                oldvalue = int.Parse(Session["oldsum"].ToString());

            }
            newvalue = oldvalue + int.Parse(num1.Text) + int.Parse(num2.Text);
            Result.Text = (newvalue).ToString();
            Session["oldsum"] = newvalue;*/

            if (Request.Cookies["key"] != null)
            {
                oldvalue = int.Parse(Request.Cookies["key"]["value"].ToString());
            }
            newvalue = oldvalue + int.Parse(num1.Text) + int.Parse(num2.Text);

            if (flag == 0)
            {
                Response.Cookies["key"]["value"] = "100";
                Response.Cookies["key"].Expires = DateTime.Now.AddMinutes(5);
                flag = 1;
            }

            Result.Text = newvalue.ToString();
            
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            Result.Text = (int.Parse(num1.Text) - int.Parse(num2.Text)).ToString();
            Response.Redirect("http://localhost:60931/NextPage.aspx");
        }

        protected void Mul_Click(object sender, EventArgs e)
        {
            Result.Text = (int.Parse(num1.Text) * int.Parse(num2.Text)).ToString();
        }

        protected void Div_Click(object sender, EventArgs e)
        {
            try
            {
                Result.Text = (int.Parse(num1.Text) / int.Parse(num2.Text)).ToString();
            }catch(DivideByZeroException ex)
            {
                Result.Text= "Cannot divide a number by zero";
            }

            
        }


       
         
    }
}
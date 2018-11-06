using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BillingSystem
{
    //TODO:
    //Persist state
    public partial class SalesStart : System.Web.UI.Page
    {
        List<ItemInTable> itemInTables = new List<ItemInTable>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox012.Focus();
            }
        }

        // TODO:
        // Get product from Tejas
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            //Product product = Inventory.GetProduct(SearchLabel.Text);

            MessageBox.Show("Product found");
        }

        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.processSales(SalesTable);
            Response.Redirect("../Report/Bill_Portal.aspx");
        }

        protected void ProductId_TextChange(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.TextBox textBox = (System.Web.UI.WebControls.TextBox)sender;
            int productId = Int32.Parse(textBox.Text);

            SetProductDetails(productId, textBox);
        }

        protected void Quantity_TextChange(object sender, EventArgs e)
        {
            CalculateSubTotal((System.Web.UI.WebControls.TextBox)sender);
            MessageBox.Show(((System.Web.UI.WebControls.TextBox)sender).Text);

            //itemInTables.Add(GetRowData((System.Web.UI.WebControls.TextBox)sender));
            
            AddNewRowWithFocus();
        }

        //TODO:
        //Get from Pradeep
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out Successfully");
        }

        //TODO:
        //Get product from Tejas
        protected void SetProductDetails(int productId, System.Web.UI.WebControls.TextBox textBox)
        {
            //Product object from Tejas

            string rowNumber = GetRowNumber(textBox);

            TableCell tableCell = (TableCell)textBox.Parent;
            TableRow tableRow = (TableRow)tableCell.Parent;

            // Column number of product name is 3
            System.Web.UI.WebControls.TextBox productNameTextBox = (System.Web.UI.WebControls.TextBox)tableRow.FindControl("TextBox" + rowNumber + 3);
            productNameTextBox.Text = "Bread"; //Get data from product

            // Column number of price per unit is 5
            System.Web.UI.WebControls.TextBox priceTextBox = (System.Web.UI.WebControls.TextBox)tableRow.FindControl("TextBox" + rowNumber + 5);
            priceTextBox.Text = "10"; //Get data from product

            // Column number of gst is 6
            System.Web.UI.WebControls.TextBox gstTextBox = (System.Web.UI.WebControls.TextBox)tableRow.FindControl("TextBox" + rowNumber + 6);
            gstTextBox.Text = "12"; //Get data from product
        }

        protected void CalculateSubTotal(System.Web.UI.WebControls.TextBox textBox)
        {
            int quantity = Int32.Parse(textBox.Text);

            string rowNumber = GetRowNumber(textBox);

            TableCell tableCell = (TableCell)textBox.Parent;
            TableRow tableRow = (TableRow)tableCell.Parent;

            // Column number of price per unit is 5
            System.Web.UI.WebControls.TextBox priceTextBox = (System.Web.UI.WebControls.TextBox)tableRow.FindControl("TextBox" + rowNumber + 5);
            int price = Int32.Parse(priceTextBox.Text);

            System.Web.UI.WebControls.TextBox subtotalTextBox = (System.Web.UI.WebControls.TextBox)tableRow.FindControl("TextBox" + rowNumber + 7);
            subtotalTextBox.Text = (quantity * price).ToString();
        }

        /*protected ItemInTable GetRowData(System.Web.UI.WebControls.TextBox textBox)
        {
            string rowNumber = GetRowNumber(textBox);
            return new ItemInTable();
        }*/

        //TODO:
        //Sl No. automatic generation
        protected void AddNewRowWithFocus()
        {
            TableRow tableRow = new TableRow();

            int rowNumber = SalesTable.Rows.Count;

            for (int i = 1; i <= 7; i++)
            {
                System.Web.UI.WebControls.TextBox textBox = new System.Web.UI.WebControls.TextBox();
                textBox.ID = "TextBox0" + rowNumber + i;

                if(!(i == 2 || i == 4))
                {
                    textBox.Enabled = false;
                }
                else if(i == 2)
                {
                    textBox.TextChanged += new EventHandler(ProductId_TextChange);
                    textBox.AutoPostBack = true;
                }
                else
                {
                    textBox.TextChanged += new EventHandler(Quantity_TextChange);
                    textBox.AutoPostBack = true;
                }

                TableCell tableCell = new TableCell();
                tableCell.Controls.Add(textBox);

                tableRow.Cells.Add(tableCell);
            }

            SalesTable.Rows.Add(tableRow);
            tableRow.Focus();
        }

        protected string GetRowNumber(System.Web.UI.WebControls.TextBox textBox)
        {
            string controlId = textBox.ID;

            //TODO:
            //Capture rownumber even for double digit row numbers
            int index = controlId.IndexOf('0');

            string rowNumber = controlId.Substring(index, 2);

            return rowNumber;
        }
    }
}
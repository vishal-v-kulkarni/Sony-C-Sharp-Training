using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test1_DisplayDirectory
{
    public partial class ListWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                DropDownList drop = (DropDownList)FindControl("listdrives");

                foreach (var a in drives)
                {
                    ListItem li = new ListItem();
                    li.Text = a.ToString();

                    drop.Items.Add(li);
                }

                string[] directories = Directory.GetDirectories(listdrives.Text);

                ListBox lb = (ListBox)FindControl("listbox");
                lb.Items.Clear();

                foreach (var a in directories)
                {
                    ListItem li = new ListItem();
                    li.Text = a.ToString();

                    lb.Items.Add(li);
                }
            }



        }

        protected void listdrives_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] directories = Directory.GetDirectories(listdrives.Text);

            ListBox lb = (ListBox)FindControl("listbox");
            lb.Items.Clear();

            foreach (var a in directories)
            {
                ListItem li = new ListItem();
                li.Text = a.ToString();

                lb.Items.Add(li);
            }

        }

        protected void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListBox lb = (ListBox)FindControl("listbox");

            FileAttributes attr = File.GetAttributes(lb.SelectedItem.Text);
            //Response.Write(lb.SelectedItem.Text);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                string[] directories = Directory.GetDirectories(lb.SelectedItem.Text);

                DirectoryInfo d = new DirectoryInfo(lb.SelectedItem.Text);
                FileInfo[] files = d.GetFiles("*.cs");

                lb.Items.Clear();


                foreach (var a in directories)
                {
                    ListItem li = new ListItem();
                    li.Text = a.ToString();

                    lb.Items.Add(li);
                }
                foreach (var f in files)
                {
                    ListItem li = new ListItem();
                    li.Text = d.FullName+"\\"+f.ToString();

                    lb.Items.Add(li);
                }
            }
            else
            {
                FileInfo f = new FileInfo(lb.SelectedItem.Text);
                string fullpath = Path.GetFullPath(lb.SelectedItem.Text);

                string contents = File.ReadAllText(fullpath);


                TextArea1.InnerText = contents;

                Process.Start("notepad.exe",fullpath);


            }

           

            

        }
    }
}
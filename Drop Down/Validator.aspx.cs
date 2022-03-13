using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentASP
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string[] str = new string[] { "Asus", "Lenovo", "Dell", "Mac","HP" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }
       

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".JPG";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Asus")
            {
                TextBox1.Text = "45000";
            }
            else if (DropDownList1.SelectedValue == "Lenovo")
            {
                TextBox1.Text = "50000";
            }
            else if (DropDownList1.SelectedValue == "Dell")
            {
                TextBox1.Text = "56000";
            }
            else if (DropDownList1.SelectedValue == "Mac")
            {
                TextBox1.Text = "70000";
            }

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
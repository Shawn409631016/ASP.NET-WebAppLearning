using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = "";
            
            if (RadioButton1.Checked)
            {
                r = r + "Mr.";
            }
            else
            {
                r = r + "Miss ";
            }
            
            r = r + TextBox1.Text + "<br>";

            if (CheckBox1.Checked)
            {
                r = r + CheckBox1.Text + "<br>";
            }
            if (CheckBox2.Checked)
            {
                r = r + CheckBox2.Text + "<br>";
            }
            if (CheckBox3.Checked)
            {
                r = r + CheckBox3.Text + "<br>";
            }

            Label1.Text = r;
        }
    }
}
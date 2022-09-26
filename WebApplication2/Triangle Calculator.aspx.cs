using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Triangle_Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Triangle a = new Triangle();
            a.Base = Double.Parse(TextBox1.Text);
            a.Height = Double.Parse(TextBox2.Text);
            Label1.Text = a.Area().ToString();
        }
    }
}
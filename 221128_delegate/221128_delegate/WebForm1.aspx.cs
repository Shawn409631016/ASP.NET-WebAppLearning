using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _221128_delegate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.radius = Int32.Parse(TextBox1.Text);
            Label1.Text = c.Area(x => x * x * Math.PI).ToString();
        }
    }
}
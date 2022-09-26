using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Circle_Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Circle c = new Circle();
                c.Radius = Double.Parse(TextBox1.Text);
                Label1.Text = c.Area().ToString();
                Label2.Text = c.Circumferece().ToString();
            }
            catch(Exception err)
            {
                Label1.Text = err.Message.ToString();
            }

        }
    }
}
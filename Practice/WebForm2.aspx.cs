using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random rr = new Random();
            int a;
            a = rr.Next(1, 11);
            Label1.Text = a.ToString();
            if (a >= 5)
            {
                Label2.Text = "Success";
            }
            else
            {
                Label2.Text = "Fail";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace input
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                string r = this.Server.UrlEncode(TextBox1.Text);
                Response.Redirect("WebForm2.aspx?a=" + r);
            }
        }
    }
}
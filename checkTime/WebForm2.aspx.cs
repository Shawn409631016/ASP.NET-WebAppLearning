using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checkTime
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int c;
            if (this.ViewState["counter"] == null)
            {
                c = 1;
            }
            else
            {
                c = (int)this.ViewState["counter"] + 1;
            }
            this.ViewState["counter"] = c;
            Label1.Text = c.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("WebForm3");
        }
    }
}
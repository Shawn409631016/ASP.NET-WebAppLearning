using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace checkTime
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter;
            if (ViewState["counter"] == null)
            {
                counter = 1;
            }
            else
            {
                counter = (int)ViewState["counter"] + 1;
            }
            ViewState["counter"] = counter;
            Label1.Text = counter.ToString();
        }
    }
}
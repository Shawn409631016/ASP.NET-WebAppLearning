using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace name
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            int cc;
            if (Application["count"] is null)
            {
                cc = 1;
            }
            else
            {
                cc = (int)Application["count"] + 1;
            }
            Label1.Text = cc.ToString();
            Application["count"] = cc;
            Application.UnLock();
        }
    }
}
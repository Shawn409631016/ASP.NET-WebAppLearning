using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = TextBox2.Text;
            r = r.Replace("\r\n", "<br>"); //replace Enter to <br>
            r = "<hr>" + DateTime.Now + "<br>" + TextBox1.Text + "<br>" + r;
            Label1.Text = r + Label1.Text;
        }
    }
}
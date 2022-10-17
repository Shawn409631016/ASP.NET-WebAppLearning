using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieLearning
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //cookie
            /*HttpCookie cc = new HttpCookie("Hello");
            /cc["name"] = TextBox1.Text;
            cc.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cc);*/

            //Url
            string r = this.Server.UrlEncode(TextBox1.Text);
            string s = this.Server.UrlEncode(TextBox2.Text);
            this.Server.Transfer("WebForm2.aspx?a="+r + "&b="+s);

            
        }
    }
}
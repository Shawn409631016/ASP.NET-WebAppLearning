using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                string r;
                a = Int32.Parse(TextBox1.Text);
                r = "";
                for(int i=2; i<=a; i++)
                {
                    for(int j=2; j<=9; j++)
                    {
                        b = i * j;
                        r = r + i + "*" + j + "=" + b + "<br>";
                    }
                }
                Label1.Text = r;
            }
            catch (Exception err)
            {
                Label1.Text = err.Message.ToString();
            }
        }
    }
}
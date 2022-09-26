using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string[] b = a.Split(',');
            string r = "";
            double[] c = new double[b.Length];

            for(int i= 0; i < b.Length; i++)
            {
                c[i] = double.Parse(b[i]);
            }
            
            Array.Sort(c);
            foreach(double abc in c)
            {
                r = r + abc.ToString() + "<br>";
            }
            Label1.Text = r;
        }
    }
}
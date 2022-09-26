using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double[] b = new double[5];
            string itemID;
            string r = "";

            for(int i=1; i<=5; i++)
            {
                TextBox a;
                itemID = "TextBox" + i.ToString();
                a = (TextBox) this.FindControl(itemID);
                b[i-1] = Double.Parse(a.Text);
            }

            Array.Sort(b);
            /*for(int i=0; i<5; i++)
            {
                for(int j=i+1; j<5; j++)
                {
                    if(b[j] < b[i])
                    {
                        double temp = b[i];
                        b[i] = b[j];
                        b[j] = temp;
                    }
                }
            }*/

            for (int i=0; i<5; i++)
            {
                r = r + b[i].ToString() + "<br>";
            }
            Label1.Text = r;


        }
    }
}
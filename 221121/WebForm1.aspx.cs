using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _221121
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            int total = 0;
            int tmpPrice = 0;
            int tmpQuantity = 0;
            foreach (GridViewRow i in GridView1.Rows)
            {
                tmpPrice = Int32.Parse(i.Cells[2].Text);
                if (((TextBox)i.Cells[4].FindControl("TextBox2")).Text == "")
                {
                    tmpQuantity = 0;
                }
                else
                {
                    tmpQuantity = Int32.Parse(((TextBox)i.Cells[4].FindControl("TextBox2")).Text);
                }
                total += tmpQuantity * tmpPrice;
            }
            Label1.Text = total.ToString();
        }
    }
}
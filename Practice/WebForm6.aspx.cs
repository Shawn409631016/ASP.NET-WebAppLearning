using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int[] n = new int[5] { 1, 2, 3, 4, 5 };
            int[] n = { 1, 2, 3, 4, 5 };
            string s = "";
            for(int i= 0; i < n.Length; i++)
            {
                s = s + n[i].ToString();
            }
            Label1.Text = s;
        }
    }
}
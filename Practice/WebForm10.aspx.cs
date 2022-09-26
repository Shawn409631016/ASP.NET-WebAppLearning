using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string r = "";
            //ArrayList myArray = new ArrayList();
            List<int> myArray = new List<int>();
            myArray.Add(5);
            myArray.Add(10);
            myArray.Add(3);
            myArray.Sort();
            foreach (int num in myArray)
            {
                r = r + num.ToString() + "<br>";
            }
            Label1.Text = r;
        }
    }
}
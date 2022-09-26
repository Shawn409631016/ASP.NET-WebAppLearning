using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Product_Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Price = 100;
                Label1.Text = p.Total_Sales(Int32.Parse(TextBox1.Text)).ToString();
            }
            catch (Exception err)
            {
                Label1.Text = err.Message.ToString();
            }
        }
    }
}
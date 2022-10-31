using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace searchProduct
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = WebConfigurationManager.ConnectionStrings["imConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "insert into product (id, name, price) values (@id, @name, @price)";
            sqlcmd.Parameters.AddWithValue("@id", TextBox1.Text);
            sqlcmd.Parameters.AddWithValue("@name", TextBox2.Text);
            sqlcmd.Parameters.AddWithValue("@price", TextBox3.Text);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            Response.Redirect("WebForm1.aspx");
            
        }
    }
}
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
    public partial class WebForm1 : System.Web.UI.Page
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
            sqlcmd.CommandText = "select name, price from product where id=" + TextBox1.Text;
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            if (sqldr.Read())
            {
                Label1.Text = sqldr.GetString(0);
                Label2.Text = sqldr.GetInt32(1).ToString();
            }
            else
            {
                Label1.Text = "Not Found";
                Label2.Text = "Not Found";
            }
        }
    }
}
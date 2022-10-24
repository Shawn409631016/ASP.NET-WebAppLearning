using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=im;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "select uid, upass from uaccount where uid='" + TextBox1.Text + "'";
            SqlDataReader sqldr = sqlcmd.ExecuteReader();

            if (sqldr.HasRows)
            {
                sqldr.Read();
                if (sqldr.GetString(1).Equals(TextBox2.Text))
                {
                    Response.Redirect("WebForm2.aspx");
                }
            }
            sqlcon.Close();
        }
    }
}
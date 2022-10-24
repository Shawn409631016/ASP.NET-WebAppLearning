using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace customerDatabase
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string strcon = WebConfigurationManager.ConnectionStrings["imConnectionString"].ConnectionString;
                try
                {
                    SqlConnection sqlcon = new SqlConnection();
                    sqlcon.ConnectionString = strcon;
                    sqlcon.Open();
                    
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select cid, cname from customer";

                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    ListBox1.DataSource = sqldr;
                    ListBox1.DataTextField = "cname";
                    ListBox1.DataValueField = "cid";
                    ListBox1.DataBind();
                    sqldr.Close();
                }
                catch(SqlException err)
                {

                }
            }
        }
    }
}
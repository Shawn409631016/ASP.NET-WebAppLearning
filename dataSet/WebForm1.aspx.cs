using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace dataSet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string strcon = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=im;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                SqlDataAdapter sqldr = new SqlDataAdapter("select cid, cname from customer", sqlcon);
                DataSet ds = new DataSet();
                sqldr.Fill(ds,"cust");
                ListBox1.DataSource = ds.Tables["cust"];
                ListBox1.DataTextField = "cname";
                ListBox1.DataValueField = "cname";
                ListBox1.DataBind();
                sqlcon.Close();
            }
        }
    }
}
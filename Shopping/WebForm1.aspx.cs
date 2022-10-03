using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shopping
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListItem a = new ListItem();
            double p = 0;
            a.Text = ListBox1.SelectedItem.Text;
            a.Value = ListBox1.SelectedItem.Value;
            ListBox2.Items.Add(a);
            foreach(ListItem i in ListBox2.Items)
            {
                p = p + Double.Parse(i.Value);
            }
            Label1.Text = p.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double p = 0;
            ListBox2.Items.Remove(ListBox2.SelectedItem);
            foreach (ListItem i in ListBox2.Items)
            {
                p = p + Double.Parse(i.Value);
            }  
            Label1.Text = p.ToString();
        }
    }
}
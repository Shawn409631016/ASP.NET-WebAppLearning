using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Emcployee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            List<string> ss = new List<string>();
            ee.Name = TextBox1.Text;
            
            if(RadioButtonList1.SelectedValue == "Male")
            {
                ee.Gender = true;
            }
            else
            {
                ee.Gender = false;
            }

            foreach(ListItem i in CheckBoxList1.Items)
            {
                if (i.Selected)
                {
                    ss.Add(i.Value);
                }
            }
            ee.Skills = ss;
            Label1.Text = ee.get_info();
        }
    }
}
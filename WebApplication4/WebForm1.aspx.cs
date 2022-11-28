using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.DynamicData;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Label = System.Web.UI.WebControls.Label;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            int baseSalary;
            foreach(GridViewRow i in GridView1.Rows)
            {
                string level = i.Cells[1].Text;
                
                if(level == "A")
                {
                    baseSalary = 1500;
                }
                else if(level == "B"){
                    baseSalary = 1800;
                }
                else
                {
                    baseSalary = 2000;
                }
                int hours = Int32.Parse(((TextBox)i.Cells[3].FindControl("TextBox1")).Text);
                int Salary = baseSalary * hours;
                ((Label)i.Cells[4].FindControl("Label1")).Text = Salary.ToString();
            }

        }
    }
}
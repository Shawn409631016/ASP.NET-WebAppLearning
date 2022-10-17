using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BMIApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double height = Double.Parse(TextBox1.Text);
            double weight = Double.Parse(TextBox2.Text);
            double BMI;

            if (DropDownList1.SelectedValue == "inch")
            {
                height = height * 0.0254;
            }else
            {
                height = height / 100;
            }

            if (DropDownList2.SelectedValue == "lb")
            {
                weight = weight * 0.453;
            }

            BMI = Math.Round(weight / (height * height), 2);
            
            Label1.Text = "BMI:" + BMI.ToString();

            if (BMI <= 18.5)
            {
                Label2.Text = "過瘦";
            }
            else if (BMI <= 24.9)
            {
                Label2.Text = "正常";
            }
            else if (BMI <= 29.9)
            {
                Label2.Text = "過重";
            }
            else
            {
                Label2.Text = "超重";
            }

        }
    }
}
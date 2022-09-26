using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(0,6);
            switch (a)
            {
                case 0: 
                    Image1.ImageUrl = "image/1.jpg";
                    break;
                case 1:
                    Image1.ImageUrl = "image/2.jpg";
                    break;
                case 2:
                    Image1.ImageUrl = "image/3.jpg";
                    break;
                case 3:
                    Image1.ImageUrl = "image/4.jpg";
                    break;
                case 4:
                    Image1.ImageUrl = "image/5.jpg";
                    break;
                case 5:
                    Image1.ImageUrl = "image/6.PNG";
                    break;
            }
        }
    }
}
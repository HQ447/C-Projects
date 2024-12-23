using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace helloWolrd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1= int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);
            int sum=num1 + num2;

            TextBox3.Text=sum.ToString();
        }
    }
}
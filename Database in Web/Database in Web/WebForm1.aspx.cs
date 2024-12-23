using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_in_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select * from School";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "insert into School values (" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + "," + TextBox5.Text + ")";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "delete from School  where id=" + TextBox1.Text;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select * from School where name like '" + TextBox1.Text + "%'";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "update School set id=" + TextBox1.Text + ", name='" + TextBox2.Text + "',age='" + TextBox3.Text + "',address=" + TextBox4.Text + ",fee=" + TextBox5.Text + " where id=" + TextBox6.Text;


        }
    }
}
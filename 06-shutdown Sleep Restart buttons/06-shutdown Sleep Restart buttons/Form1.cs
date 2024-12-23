using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_shutdown_Sleep_Restart_buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //shutdown
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-s");
        }

        //sleep/hybernate
        private void button2_Click(object sender, EventArgs e)
        { 
            System.Diagnostics.Process.Start("shutdown", "-h");
        }

        //Restart
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-r");
        }

        //Log off
        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-l");
        }
    }
}

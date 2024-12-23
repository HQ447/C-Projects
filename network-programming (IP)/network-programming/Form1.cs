using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;


namespace network_programming
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int Out;
            if (InternetGetConnectedState(out Out, 0) == true)
            {
                MessageBox.Show("Connected !");
            }
            else
            {
                MessageBox.Show("Not Connected !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    IPHostEntry hostname = Dns.GetHostByName(textBox1.Text);
                    IPAddress[] ip = hostname.AddressList;
                    textBox2.Text = ip[0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Grab a Graphics object via Hwnd.
            Graphics g = Graphics.FromHwnd(this.Handle);
            // Now draw a 10*10 circle at mouse click.
            g.FillRectangle(Brushes.Green, e.X, e.Y, 50, 50);
            g.FillEllipse(Brushes.Firebrick, e.X + 10, e.Y + 10, 25, 25);


            g.DrawLine(new Pen(Color.Blue,20), 60, 80, 200,210);


            Rectangle r = new Rectangle(10, 20, 100, 110);
            g.DrawRectangle(new Pen(Color.Pink), r);
            g.DrawString("Kohat University",new Font("Arial",12),Brushes.Brown,r);

            g.Dispose();


        }
    }
}

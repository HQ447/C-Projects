using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Multi_Document_Interface__MDI__Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Open the other forms inside parent(main) container
            IsMdiContainer = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            //to open form inside the parent
            form2.MdiParent = this;
            form2.Show();
            
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //to open form inside the parent
            form3.MdiParent = this;
            form3.Show();
            
        }

      
    }
}

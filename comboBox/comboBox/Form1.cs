using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace comboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = 0;

            try
            {
                if (comboBox1.SelectedItem.ToString() == "+")
                {
                    c = a + b;
                }
                if (comboBox1.SelectedItem.ToString() == "-")
                {
                    c = a - b;
                }
                if (comboBox1.SelectedItem.ToString() == "*")
                {
                    c = a * b;
                }
                if (comboBox1.SelectedItem.ToString() == "/")
                {
                    c = a / b;
                }
                if (comboBox1.SelectedItem.ToString() == "%")
                {
                    c = a % b;
                }

                textBox3.Text = c.ToString();
            } catch (DivideByZeroException e1)
            {
                MessageBox.Show("Second number cant be zero");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Rate = -2;
            if (comboBox2.SelectedIndex == 0)
                s.Volume = 0;
            if (comboBox2.SelectedIndex == 1)
                s.Volume = 20;
            if (comboBox2.SelectedIndex == 2)
                s.Volume = 40;
            if (comboBox2.SelectedIndex == 3)
                s.Volume = 60;
            if (comboBox2.SelectedIndex == 4)
                s.Volume = 80;
            if (comboBox2.SelectedIndex == 5)
                s.Volume = 100;

            s.Speak("The Result is " + textBox3.Text);

                }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

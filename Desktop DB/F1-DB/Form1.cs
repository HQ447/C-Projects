using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace F1_DB
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.companyDataSet.employees);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData(string selectCommand)
        {
            try
            {
                String connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True;Pooling=False";
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("Exception ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from employees");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from employees where id=" + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("insert into employees values(" + textBox2.Text + ", '" + textBox3.Text + "','" + textBox4.Text + "'" + ")");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("Delete from employees where id=" +textBox5.Text);
        }
    }
}

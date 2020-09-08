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

namespace Hafiz_Marble
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-NMGRJ84\HAFIZSQL;Initial Catalog=Hafiz;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;

            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            // "values (5, '" + "Miyoo" + "')";
            /*Inv_Ordered_Quantity*/
            sql = "Insert into Employee(Emp_Name ,Emp_Age, Emp_Salary, Emp_Contact, Emp_Post, Dept_Name) " +
            "values ('" + Emp_Name.Text + "', '" + Emp_Age.Text + "', '" + Emp_Salary.Text + "', '" + Emp_Contact.Text + "'," +
                " '" + Emp_Post.Text + "', '" + Dept_Name.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Employee ADDED.");

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet3.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hafizDataSet3.Department);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }
    }
}

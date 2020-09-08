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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //The string with the connection database link 
            string connectionString;

            //SqlConnection variable
            SqlConnection cnn;

            //Creating connection to database 
            connectionString = @"Data Source=DESKTOP-NMGRJ84\HAFIZSQL;Initial Catalog=Hafiz;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            //Connection open for use
            cnn.Open();

            SqlDataReader dataReader;
            SqlCommand command;
            string sql = "";

            sql = "Select * from Employee where Emp_ID = '" + Search_ID.Text + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Emp_ID.Text = dataReader.GetValue(0).ToString();
                Emp_Name.Text = dataReader.GetValue(1).ToString();
                Emp_Salary.Text = dataReader.GetValue(2).ToString();
                Emp_Age.Text = dataReader.GetValue(3).ToString();
                Emp_Contact.Text = dataReader.GetValue(4).ToString();
                Dept_Name.Text = dataReader.GetValue(5).ToString();
                Emp_Post.Text = dataReader.GetValue(6).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
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

            //sql = "update Jani set wtf = '" + "Miyoo teri" + "' where jani=5";

            //SQL query that we will send to the adapter to update the data 
            sql = "update Employee set Emp_Name = '" + Emp_Name.Text + "', Emp_Salary = '" + Emp_Salary.Text + "', Emp_Age = '" + Emp_Age.Text + "', Emp_Contact = '" + Emp_Contact.Text + "', Dept_Name = '" + Dept_Name.Text + "', Emp_Post = '" + Emp_Post.Text + "' where Emp_ID = " + Emp_ID.Text + "";


            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Updated");

            command.Dispose();
            cnn.Close();

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hafizDataSet4.Employee);

        }
    }
}

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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
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
            string sql;
            SqlDataAdapter adapter = new SqlDataAdapter();

            sql = "delete from Employee where Emp_ID =" + Emp_ID.Text + "";


            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            MessageBox.Show("Record Deleted!");

            command.Dispose();
            cnn.Close();

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

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }
    }
}

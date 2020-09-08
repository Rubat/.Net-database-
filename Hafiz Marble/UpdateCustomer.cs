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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            sql = "update Customer set Cus_Name = '" + Cus_Name.Text + "', Cus_Address = '" + Cus_Address.Text + "', Cus_Email = '" + Cus_Email.Text + "', Cus_Phone = '" + Cus_Phone.Text + "', Cus_Membership = '" + Cus_Membership.Text + "', Cus_Comments = '" + Cus_Comments.Text + "' where Cus_ID = " + Cus_ID.Text + "";
                                       

            command = new SqlCommand(sql, cnn);            

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Updated");

            command.Dispose();
            cnn.Close();

            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.hafizDataSet1.Customer);

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

            sql = "Select * from Customer where Cus_ID = '" + Search_ID.Text + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //Output = Output + 
                Cus_ID.Text = dataReader.GetValue(0).ToString();
                Cus_Name.Text = dataReader.GetValue(1).ToString();
                Cus_Address.Text = dataReader.GetValue(2).ToString();
                Cus_Email.Text = dataReader.GetValue(3).ToString();
                Cus_Phone.Text = dataReader.GetValue(4).ToString();
                Cus_Membership.Text = dataReader.GetValue(5).ToString();
                Cus_Comments.Text = dataReader.GetValue(6).ToString();

            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}

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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
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

            // "values (5, '" + "Miyoo" + "')";
            sql = "Insert into Customer(Cus_Name, Cus_Address, Cus_Email, Cus_Phone, Cus_Membership, Cus_Comments) " +
            "values ('" + Cus_Name.Text + "', '" + Cus_Address.Text + "', '" + Cus_Email.Text + "'," +
                " '" + Cus_Phone.Text + "', '" + Cus_Membership.Text + "', '" + Cus_Comments.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Customer ADDED!");

            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
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

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.hafizDataSet1.Customer);
            // TODO: This line of code loads data into the 'hafizDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.hafizDataSet.Customer);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Cus_Membership_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

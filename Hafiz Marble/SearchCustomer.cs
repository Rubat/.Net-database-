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
    public partial class SearchCustomer : Form
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.hafizDataSet1.Customer);
            // TODO: This line of code loads data into the 'hafizDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.hafizDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            //connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB Project\FrontEnd\Hafiz Marble\Hafiz Marble\Database1.mdf;Integrated Security=True";
            connectionString = @"Data Source=DESKTOP-NMGRJ84\HAFIZSQL;Initial Catalog=Hafiz;Integrated Security=True";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "Select * from Customer";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(5) + "\n";
            }

            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }
    }
}

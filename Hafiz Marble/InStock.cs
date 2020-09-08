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
    public partial class InStock : Form
    {
        public InStock()
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
            sql = "Insert into Stock(In_Stock_Quantity, Prod_ID) " +
            "values ('" + In_Stock_Quantity.Text + "', '" + Prod_ID.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Product ADDED!");
            Stock order = new Stock();
            order.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stock order = new Stock();
            order.Show();
            this.Hide();
        }

        private void InStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet2.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.hafizDataSet2.Stock);

        }
    }
}

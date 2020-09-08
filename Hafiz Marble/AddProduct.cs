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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
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
            sql = "Insert into Product(Prod_Name, Prod_Design, Prod_Diameter, Prod_Weight, Prod_Category, Prod_Price, Prod_Comment) " +
            "values ('" + Prod_Name.Text + "', '" + Prod_Design.Text + "', '" + Prod_Diameter.Text + "'," +
                " '" + Prod_Weight.Text + "', '" + Prod_Category.Text + "', '" + Prod_Price.Text + "', '" + Prod_Comments.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Product ADDED!");

            //To change the window
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }
    }
}

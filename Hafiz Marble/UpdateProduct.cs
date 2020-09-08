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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
            sql = "update Product set Prod_Name = '" + Prod_Name.Text + "', Prod_Design = '" + Prod_Design.Text + "', Prod_Diameter = '" + Prod_Diameter.Text + "', Prod_Weight = '" + Prod_Weight.Text + "', Prod_Category = '" + Prod_Category.Text + "', Prod_Price = '" + Prod_Price.Text + "', Prod_Comment = '" + Prod_Comments.Text + "'where Prod_ID = " + Prod_ID.Text + "";


            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Updated");

            command.Dispose();
            cnn.Close();



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

        private void Search_ID_Click(object sender, EventArgs e)
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

            sql = "Select * from Product where Prod_ID = '" + Search_ID.Text + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //Output = Output + 
                Prod_ID.Text = dataReader.GetValue(0).ToString();
                Prod_Name.Text = dataReader.GetValue(1).ToString();
                Prod_Design.Text = dataReader.GetValue(2).ToString();
                Prod_Diameter.Text = dataReader.GetValue(3).ToString();
                Prod_Weight.Text = dataReader.GetValue(4).ToString();
                Prod_Category.Text = dataReader.GetValue(5).ToString();
                Prod_Price.Text = dataReader.GetValue(6).ToString();
                Prod_Comments.Text = dataReader.GetValue(7).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSheetProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.hafizDataSheetProduct.Product);

        }
    }
}

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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=DESKTOP-NMGRJ84\HAFIZSQL;Initial Catalog=Hafiz;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            //Add data for the invoice 
            cnn.Open();

            SqlCommand command;

            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            // "values (5, '" + "Miyoo" + "')";`````````````````````````````````````````````````````````````````````````````````````
            /*Inv_Ordered_Quantity*/
            sql = "Insert into Invoice(Prod_ID, Cus_ID ,Inv_Ordered_Quantity, In_Stock_Quantity, Inv_Date, Total_Price) " +
            "values ('" + Prod_ID.Text + "', '" + Cus_ID.Text + "', '" + Inv_Ordered_Quantity.Text + "', '"+ In_Stock_Quantity.Text + "'," +
                " '" + Inv_Date.Text + "', '" + Total_Price.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //command.Dispose();
            cnn.Close();

            //Get the new Invoice ID 
            cnn.Open();
            SqlDataReader dataReader;

            sql = "select Inv_ID from Invoice order by Inv_ID ASC";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Inv_ID.Text = dataReader.GetValue(0).ToString();
            }

            //command.Dispose();
            cnn.Close();

            //Update Sold
            cnn.Open();
            adapter = new SqlDataAdapter();
            sql = "";
            sql = "Insert into Sold  (Inv_ID, Prod_ID)" +
                "values('" + Inv_ID.Text + "', '" + Prod_ID.Text + "')";

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Collect your invoice.");

            //Menu menu = new Menu();
            //menu.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cus_ID_TextChanged(object sender, EventArgs e)
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

            sql = "Select Cus_Membership from Customer where Cus_ID = '" + Cus_ID.Text + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Cus_Membership.Text = dataReader.GetValue(0).ToString();
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        private void Prod_ID_TextChanged(object sender, EventArgs e)
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

            sql = "Select In_Stock_Quantity from Stock where Prod_ID = '" + Prod_ID.Text + "'";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                In_Stock_Quantity.Text = dataReader.GetValue(0).ToString();   
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();

        }

        /*private void Update()
        {
            cnn.Open(); //' where Inv_ID = '" + Invoice_ID.Text + 
            sql = "update Sold set Inv_ID = '" + Invoice_ID.Text + "', Prod_ID= '" + Prod_ID.Text + "'";

            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }*/
    }
}

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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DB Project\FrontEnd\Hafiz Marble\Hafiz Marble\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            MessageBox.Show("You in nigga");

            cnn.Close();

            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafiz_Marble
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveCustomer removeCustomer = new RemoveCustomer();
            removeCustomer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCustomer searchCustomer = new SearchCustomer();
            searchCustomer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }
    }
}

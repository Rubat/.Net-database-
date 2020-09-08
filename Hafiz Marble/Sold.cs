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
    public partial class Sold : Form
    {
        public Sold()
        {
            InitializeComponent();
        }

        private void Sold_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet5.Sold' table. You can move, or remove it, as needed.
            this.soldTableAdapter.Fill(this.hafizDataSet5.Sold);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();
        }
    }
}

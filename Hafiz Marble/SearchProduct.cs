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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSheetProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.hafizDataSheetProduct.Product);

        }
    }
}

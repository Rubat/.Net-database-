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
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafizDataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hafizDataSet4.Employee);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }
    }
}

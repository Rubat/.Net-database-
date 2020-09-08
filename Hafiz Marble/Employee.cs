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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveEmployee removeEmployee = new RemoveEmployee();
            removeEmployee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchEmployee searchEmployee = new SearchEmployee();
            searchEmployee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
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

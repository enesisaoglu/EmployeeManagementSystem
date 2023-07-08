using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        // Event handler for the "Employee" label click
        private void label2_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Employee form and hide the current form
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }
        // Event handler for the "Employee" picture box click
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Employee form and hide the current form
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }
        // Event handler for the "Logout" label click
        private void label5_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Login form and hide the current form
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        // Event handler for the "Logout" picture box click
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Login form and hide the current form
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        // Event handler for the "View Employee" picture box click
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the ViewEmployee form and hide the current form
            ViewEmployee emp = new ViewEmployee();
            emp.Show();
            this.Hide();
        }
        // Event handler for the "Salary" picture box click
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Salary form and hide the current form
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }
        // Event handler for the "Salary" label click
        private void label4_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Salary form and hide the current form
            Salary salary = new Salary();
            salary.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

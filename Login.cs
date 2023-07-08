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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
        // Event handler for the login button click
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                // Display an error message if the user name or password is not entered
                MessageBox.Show("Enter User Name Or User Password");
            }
            else if(UidTb.Text == "Admin" &&  PassTb.Text == "Admin123")
            {
                // If the user name and password match the expected values, hide the login form and show the home form
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                // Display an error message for incorrect user name or password
                MessageBox.Show("Wrong User Name Or Password");
            }
        }
        // Event handler for the clear button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the user name and password textboxes
            UidTb.Text = null;
            PassTb.Text = null;
        }
    }
}

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

namespace EmployeeManagementSystem
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        // SqlConnection object to connect to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enesi\OneDrive\Belgeler\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label10_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
        private void FetchempData()
        {
            if(EmpIDTb.Text == "")
            {
                // Show an error message if Employee ID is not entered
                MessageBox.Show("Enter Employee ID");
            }
            else 
            {
                Con.Open();
                string query = "select * from EmployeeTable where EmpId = '" + EmpIDTb.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // Sync the data with respective textboxes
                    EmpNameTb.Text = dr["EmpName"].ToString();
                    EmpPosTb.Text = dr["EmpPos"].ToString();


                }
                Con.Close();
            }
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Home form and hide the current form
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the FetchempData function to retrieve and display employee data
            FetchempData();
        }
        // Daily base salary for the employee
        int dailyBase;
        // Total calculated salary for the employee
        int total;
        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Show the print preview dialog and print the document when OK is clicked
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Draw the salary document on the print page
            e.Graphics.DrawString("=======SALARY DOCUMENT=======",
              new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(165));
            e.Graphics.DrawString("Employee ID: " + EmpIDTb.Text,
                new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Position: " + EmpPosTb.Text,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Worked Days: " + WorkedTb.Text,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Daily Pay: " + dailyBase,
         new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Total Salary: " +total ,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
          

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (EmpPosTb.Text =="")
            {
                // Show an error message if an employee is not selected
                MessageBox.Show("Select An Employee");
            }
            else if(WorkedTb.Text == "" || Convert.ToInt32(WorkedTb.Text) > 28)
            {
                // Show an error message if the number of days worked is not entered or invalid
                MessageBox.Show("Enter A Valid Number Of Days");
            }
            else
            {
                // Calculate the salary based on the employee position and number of days worked
                if (EmpPosTb.Text == "Manager")
                {
                    dailyBase = 1200;
                }
                else if(EmpPosTb.Text == "Senior Developer")
                {
                    dailyBase = 1000;
                }
                else if(EmpPosTb.Text == "Junior Developer")
                {
                    dailyBase = 950;
                }
                else
                {
                    dailyBase = 850;
                }
                // Update the salary slip textbox with the calculated salary information
                total = dailyBase * Convert.ToInt32(WorkedTb.Text);
                SalarySlip.Text = "Employee ID: " + EmpIDTb.Text + "\n" + "Employee Name: " + EmpNameTb.Text + "\n" + "Employe Position: " +EmpPosTb.Text +
                    "\n" + "Days Worked: " + WorkedTb.Text + "\n" + "Daily Salary: " + dailyBase.ToString() + "\n" + "Total Amount: " + total.ToString();
            }
        }
    }
}

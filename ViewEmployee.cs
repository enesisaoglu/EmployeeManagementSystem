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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmployeeManagementSystem
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        // SqlConnection object to connect to the databas
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enesi\OneDrive\Belgeler\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");

        // Function to fetch and display employee data
        private void FetchempData()
        {
            Con.Open();
            string query = "select * from EmployeeTable where EmpId = '" + empidTb.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // Sync the data with respective labels
                Empidlbl.Text = dr["EmpId"].ToString();
                empnamelbl.Text = dr["Empname"].ToString();
                empaddlbl.Text = dr["EmpAdd"].ToString();
                empposlbl.Text = dr["EmpPos"].ToString();
                empphonelbl.Text = dr["EmpPhone"].ToString();
                empdoblbl.Text = dr["EmpDOB"].ToString();
                empedulbl.Text = dr["EmpEdu"].ToString();
                empgenlbl.Text = dr["EmpGen"].ToString();
                // Make the labels visible
                Empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empposlbl.Visible = true;
                empphonelbl.Visible = true;
                empdoblbl.Visible = true;
                empedulbl.Visible = true;
                empgenlbl.Visible = true;


            }
            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the "Fetch" button click
        private void button5_Click(object sender, EventArgs e)
        {
            // Call the FetchempData function to retrieve and display employee data
            FetchempData();
        }
        // Event handler for the "Home" button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Create and show an instance of the Home form and hide the current form
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
        // Event handler for the "Print" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Show the print preview dialog and print the document when OK is clicked
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
        // Event handler for the "Print Document" print page event
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Draw the employee summary on the print page
            e.Graphics.DrawString("=======EMPLOYEE SUMMARY=======", 
                new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(165));
            e.Graphics.DrawString("Employee ID: "+Empidlbl.Text +"\tEmployee Name: " + empnamelbl.Text,
                new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue,new Point(10,100));
            e.Graphics.DrawString("Employee Address: " + empaddlbl.Text + "\tEmployee Gender: " + empgenlbl.Text,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Employee Position: " + empposlbl.Text + "\tEmployee DOB: " + empdoblbl.Text,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Employee Phone: " + empphonelbl.Text + "\tEmployee Education: " + empedulbl.Text,
               new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));


        }
    }
}

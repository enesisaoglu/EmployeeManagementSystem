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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        // SqlConnection object for connecting to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enesi\OneDrive\Belgeler\MyEmployeeDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Event handler for the "Add" button click
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == ""
                || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
              
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTable values ('" + EmpIDTb.Text + "' ,'" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosCb.SelectedItem.ToString() + "','" + EmpDob.Value.Date + "','" + EmpPhoneTb.Text + "','" + EmpEduCb.SelectedItem.ToString() + "','" + EmpGenCb.SelectedItem.ToString() + "') ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Succesfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Populate the DataGridView with data from the database
        private void populate()
        {
            Con.Open();
            String query = "select * from EmployeeTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        // Event handler for the form load event
    private void Employee_Load(object sender, EventArgs e)
        {
            // Customize the DataGridView header style
            EmpDGV.EnableHeadersVisualStyles = false;
            EmpDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;  // Set the desired color for the header background
            EmpDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;  // Set the desired color for the header text
            EmpDGV.ColumnHeadersDefaultCellStyle.Font = new Font(EmpDGV.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);  // Make the header text bold
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            populate();
        }
        // Event handler for the DataGridView cell content click
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EmpDGV.Rows.Count)
            {
                DataGridViewRow row = EmpDGV.Rows[e.RowIndex];
                EmpIDTb.Text = row.Cells[0].Value.ToString();
                EmpNameTb.Text = row.Cells[1].Value.ToString();
                EmpAddTb.Text = row.Cells[2].Value.ToString();
                EmpEduCb.Text = row.Cells[6].Value.ToString();
                EmpPosCb.Text = row.Cells[3].Value.ToString();
                EmpPhoneTb.Text = row.Cells[5].Value.ToString();
                EmpGenCb.Text = row.Cells[7].Value.ToString();
            }
        }
        // Event handler for the "Delete" button click
        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpIDTb.Text == "")
            {
                MessageBox.Show("Enter The Employee ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTable where Empid = '" + EmpIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        // Event handler for the "Update" button click
        private void button4_Click(object sender, EventArgs e)
        {
            // Check if any required information is missing
            if (EmpIDTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == ""
                || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Construct the SQL query to update the employee information
                    string query = "update EmployeeTable set EmpName = '" + EmpNameTb.Text + "', empadd = '" + EmpAddTb.Text + "', emppos = '" + EmpPosCb.SelectedItem.ToString() + "', EmpDOB = '" + EmpDob.Value.Date + "', EmpPhone = '" + EmpPhoneTb.Text + "', EmpEdu = '" + EmpEduCb.SelectedItem.ToString() + "', EmpGen = '" + EmpGenCb.SelectedItem.ToString() + "' where EmpID= '" + EmpIDTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Event handler for the "Home" button click
        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void EmpIDTb_Click(object sender, EventArgs e)
        {

        }
    }
}
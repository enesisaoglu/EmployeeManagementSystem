using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class Splash : Form
    {
        private Timer timer;
        private int progressValue;

        public Splash()
        {
            InitializeComponent();
            // Create and initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            // Set the progress bar properties
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 15; // 15 seconds
            // Initialize the progress value
            progressValue = 0;
            progressBar1.Value = progressValue;
            // Start the timer
            timer.Start();
        }
        // Event handler for the timer tick event
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the progress value and the progress bar
            progressValue++;
            progressBar1.Value = progressValue;

            if (progressValue == 15)
            {
                // When the progress reaches 15, stop the timer, hide the splash screen, and show the login form
                timer.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }


}

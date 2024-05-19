using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class MyAlert : Form
    {
        private Timer closeTimer;

        public MyAlert()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            // Initialize the timer
            closeTimer = new Timer();
            closeTimer.Interval = 3000; // 3 seconds
            closeTimer.Tick += CloseTimer_Tick;

            // Set button1 properties for transparency
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowAlert(string message)
        {
            label1.Text = message; // Set the text of label1 to the message
            this.Show();
            this.Refresh();

            this.TopMost = true;
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            // Close the form when the timer ticks (after 5 seconds)
            this.Close();
        }
    }
}

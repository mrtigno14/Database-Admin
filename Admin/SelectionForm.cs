﻿using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class SelectionForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private string username;
        private string password;
        private bool isPanelVisible = false;



        public SelectionForm(string username, string password)
        {
            InitializeComponent();
            NotificationPanel.Visible = false;

            this.username = username;
            this.password = password;

            // Set form border style to none
            this.FormBorderStyle = FormBorderStyle.None;

            // Set form location to center of the desktop resolution
            this.StartPosition = FormStartPosition.Manual;
            CenterFormOnScreen();

            // Initialize Firebase client
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Failed to connect to Firebase.");
                }
                else
                {
                    // Start periodic data update task
                    Task.Run(async () =>
                    {
                        while (true)
                        {
                            await UpdateNotificationPanel();
                            await Task.Delay(TimeSpan.FromSeconds(10)); // Adjust the interval as needed
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private async Task UpdateNotificationPanel()
        {
            try
            {
                // Get the value of "available" node inside "Sukli"
                FirebaseResponse response = await client.GetAsync("Sukli/01/available");
                int availableValue = response.ResultAs<int>();

                // Update the UI controls from the UI thread
                Invoke((MethodInvoker)delegate
                {
                    // Clear existing labels in NotificationText panel
                    NotificationText.Controls.Clear();

                    // If available value is less than 30, create/update label in NotificationPanel
                    if (availableValue < 30)
                    {
                        Label label = new Label();
                        label.Text = $"The coin change is {availableValue} left!";
                        label.ForeColor = Color.Red; // Set color as desired
                        NotificationText.Controls.Add(label);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void CenterFormOnScreen()
        {
            // Calculate the center position based on the screen resolution
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int centerX = (screenWidth - formWidth) / 2;
            int centerY = (screenHeight - formHeight) / 2;

            // Set the form's location to the calculated center position
            this.Location = new Point(centerX, centerY);
        }

        

        private void AddOrUpdateNotification(string text)
        {
            // Create or update text label inside NotificationText panel
            Label label = new Label();
            label.Text = text;
            label.AutoSize = true;
            label.ForeColor = Color.Black;
            label.Margin = new Padding(0, 5, 0, 5);
            NotificationText.Controls.Add(label);
        }


        private void suggestionButton_Click(object sender, EventArgs e)
        {
            // Open the SuggestionForm
            SuggestionForm suggestionForm = new SuggestionForm("username", "password");
            suggestionForm.Show();
            this.Hide();
        }

        private void medicineButton_Click(object sender, EventArgs e)
        {
            // Open the MainForm with provided username and password
            MainForm mainForm = new MainForm("username", "password");
            mainForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Clear the username and password fields
            username = "";
            password = "";

            // Close the current form and show the login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            // Add code to detect whether the user is logged in
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // User is logged in
                // Perform necessary actions
            }
            else
            {
                // User is not logged in
                // Redirect to login form or handle accordingly
            }

            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client == null)
                {
                    MessageBox.Show("Failed to connect to Firebase.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            // Open the MainForm with provided username and password
            ImageForm imageForm = new ImageForm("username", "password");
            imageForm.Show();
            this.Hide();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            // Open the MainForm with provided username and password
            SalesForm salesForm = new SalesForm("username", "password");
            salesForm.Show();
            this.Hide();
        }

        private void notifIcon_Click(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                //Sets to false if it was true
                NotificationPanel.Visible = false;
            }
            else
            {
                //Sets to true if it was false
                NotificationPanel.Visible = true;
            }
            //Toggles the visibility
            isPanelVisible = !isPanelVisible;
        }

        private void NotificationText_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

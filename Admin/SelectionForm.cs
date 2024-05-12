using FireSharp.Config;
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
        private List<int> previousValues = new List<int>();

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
                FirebaseResponse sukliResponse = await client.GetAsync("Sukli/01/available");
                int sukliValue = sukliResponse.ResultAs<int>();

                // If available value of Sukli is within range and different from previous values, create/update label in NotificationPanel
                if (sukliValue < 30 && !previousValues.Contains(sukliValue))
                {
                    // Add the new value to the list of previous values
                    previousValues.Add(sukliValue);

                    // Convert sukliValue to string
                    string sukliString = sukliValue.ToString();

                    // Calculate the Y-coordinate position of the new label
                    int newY = 0;
                    if (NotificationText.Controls.Count > 0)
                    {
                        newY = NotificationText.Controls[NotificationText.Controls.Count - 1].Location.Y + NotificationText.Controls[NotificationText.Controls.Count - 1].Height + 5; // Add padding between labels
                    }

                    // Update the UI controls from the UI thread
                    Invoke((MethodInvoker)delegate
                    {
                        // Create and add a new label for Sukli to the panel
                        Label sukliLabel = new Label();
                        sukliLabel.Text = "The coin change is " + sukliString + " left!";
                        sukliLabel.ForeColor = Color.Red; // Set color as desired
                        sukliLabel.AutoSize = true;
                        sukliLabel.Location = new Point(0, newY);

                        // Adjust font size
                        sukliLabel.Font = new Font(sukliLabel.Font.FontFamily, 12, sukliLabel.Font.Style);

                        NotificationText.Controls.Add(sukliLabel);

                        // Show MyAlert form as a pop-up notification
                        MyAlert alertForm = new MyAlert();
                        alertForm.ShowAlert(sukliLabel.Text);
                    });
                }

                // Get the value of "available" node inside "WaterLevel"
                FirebaseResponse waterLevelResponse = await client.GetAsync("WaterLevel/01/available");
                int waterLevelValue = waterLevelResponse.ResultAs<int>();

                // If available value of WaterLevel is within range and different from previous values, create/update label in NotificationPanel
                if (!previousValues.Contains(waterLevelValue))
                {
                    // Add the new value to the list of previous values
                    previousValues.Add(waterLevelValue);

                    // Calculate the Y-coordinate position of the new label
                    int newY = 0;
                    if (NotificationText.Controls.Count > 0)
                    {
                        newY = NotificationText.Controls[NotificationText.Controls.Count - 1].Location.Y + NotificationText.Controls[NotificationText.Controls.Count - 1].Height + 5; // Add padding between labels
                    }

                    // Update the UI controls from the UI thread
                    Invoke((MethodInvoker)delegate
                    {
                        // Create and add a new label for WaterLevel to the panel
                        Label waterLevelLabel = new Label();
                        waterLevelLabel.Text = waterLevelValue == 0 ? "The water tank is EMPTY!" : "The water tank is LOW!";
                        waterLevelLabel.ForeColor = waterLevelValue == 0 ? Color.Red : Color.Blue; // Set color based on water level
                        waterLevelLabel.AutoSize = true;
                        waterLevelLabel.Location = new Point(0, newY);

                        // Adjust font size
                        waterLevelLabel.Font = new Font(waterLevelLabel.Font.FontFamily, 12, waterLevelLabel.Font.Style);

                        NotificationText.Controls.Add(waterLevelLabel);

                        // Show MyAlert form as a pop-up notification
                        MyAlert alertForm = new MyAlert();
                        alertForm.ShowAlert(waterLevelLabel.Text);
                    });
                }
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

        private void coinButton_Click(object sender, EventArgs e)
        {
            // Open the MainForm with provided username and password
            CoinForm coinForm = new CoinForm("username", "password");
            coinForm.Show();
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
    
    }
}

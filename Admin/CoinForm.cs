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
    public partial class CoinForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private Timer updateTimer;

        private string username;
        private string password;
        public CoinForm(string username, string password)
        {
            InitializeComponent();
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
                    // Fetch and update coin amount initially
                    FetchAndUpdateCoinAmount();

                    // Start timer to periodically update coin amount
                    updateTimer = new Timer();
                    updateTimer.Interval = 10000; // Update every 10 seconds
                    updateTimer.Tick += UpdateTimer_Tick;
                    updateTimer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Fetch and update coin amount periodically
            FetchAndUpdateCoinAmount();
        }

        private async void FetchAndUpdateCoinAmount()
        {
            try
            {
                // Fetch data from Firebase
                FirebaseResponse response = await client.GetAsync("Sukli/01/available");
                int? availableValue = response.ResultAs<int?>(); // Use int? instead of int

                if (availableValue.HasValue) // Check if the nullable int has a value
                {
                    // Update coinAmount label with fetched data
                    coinAmount.Text = availableValue.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data from Firebase: " + ex.Message);
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

        private void CoinForm_Load(object sender, EventArgs e)
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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the current form and show the SelectinForm
            SelectionForm selectionForm = new SelectionForm("username", "password");
            selectionForm.Show();

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

        private void coinAmount_Click(object sender, EventArgs e)
        {

        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            // Get the input amount from the TextBox
            if (int.TryParse(amount.Text, out int inputValue))
            {
                try
                {
                    // Fetch current value from Firebase
                    FirebaseResponse response = await client.GetAsync("Sukli/01/available");
                    int currentValue = response.ResultAs<int>();

                    // Add input value to the current value
                    int newValue = currentValue + inputValue;

                    // Update the value in Firebase
                    SetResponse setResponse = await client.SetAsync("Sukli/01/available", newValue);
                    if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Update successful
                        MessageBox.Show("Value updated successfully.");

                        // Update the label to reflect the new value
                        coinAmount.Text = newValue.ToString();

                        // Clear the textbox
                        amount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to update value.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating value: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            // Get the input amount from the TextBox
            if (int.TryParse(amount.Text, out int inputValue))
            {
                try
                {
                    // Update the value in Firebase
                    SetResponse setResponse = await client.SetAsync("Sukli/01/available", inputValue);
                    if (setResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        // Update successful
                        MessageBox.Show("Value updated successfully.");

                        // Update the label to reflect the new value
                        coinAmount.Text = inputValue.ToString();

                        // Clear the textbox
                        amount.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to update value.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating value: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value.");
            }
        }

    }
}

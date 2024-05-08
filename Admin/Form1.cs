using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Admin
{
    public partial class Form1 : Form
    {
        private IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        private IFirebaseClient client;

        private bool showPassword = false;
        private bool messageBoxShown = false;
        private SelectionForm selectionForm;

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxPlaceholder();
            textBox2.UseSystemPasswordChar = true;

            // Set form border style to none
            this.FormBorderStyle = FormBorderStyle.None;

            // Set form location to center of the desktop resolution
            this.StartPosition = FormStartPosition.Manual;
            CenterFormOnScreen();
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

        private void InitializeTextBoxPlaceholder()
        {
            // Set the placeholder text
            //textBox1.Text = "Enter Username";
            //textBox2.Text = "Enter Password";

            // Change text color to gray
            //textBox1.ForeColor = Color.Gray;
            //textBox2.ForeColor = Color.Gray;

            // Add event handlers
            textBox1.Enter += TextBox_Enter;
            textBox1.Leave += TextBox_Leave;
            textBox2.Enter += TextBox_Enter;
            textBox2.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when textbox is focused
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Enter Username" || textBox.Text == "Enter Password"))
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText; // Change text color to black
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if textbox is left empty
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == textBox1)
                    textBox.Text = "Enter Username";
                else if (textBox == textBox2)
                    textBox.Text = "Enter Password";

                textBox.ForeColor = Color.Gray; // Change text color to gray
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            this.Click += Form1_Click;
            this.KeyDown += Form1_KeyDown;
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox2.KeyDown += TextBox2_KeyDown;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if message box is already shown, if not, proceed
                if (!messageBoxShown)
                {
                    // Set the flag to true to prevent multiple message boxes from showing
                    messageBoxShown = true;

                    // Execute Firebase operation asynchronously using Task.Run
                    FirebaseResponse response = await Task.Run(() => client.Get("Users/userId_1"));
                    var user = response.ResultAs<Dictionary<string, string>>();

                    // Check if the entered username and password match the credentials in the database
                    string enteredUsername = textBox1.Text;
                    string enteredPassword = textBox2.Text;

                    if (user != null && user.ContainsKey("Username") && user.ContainsKey("Password"))
                    {
                        string storedUsername = user["Username"];
                        string storedPassword = user["Password"];

                        if (enteredUsername == storedUsername && enteredPassword == storedPassword)
                        {
                            // Check if selectionForm is null or not visible, then create/show it
                            if (selectionForm == null || selectionForm.IsDisposed)
                            {
                                selectionForm = new SelectionForm("username", "password");
                                selectionForm.Show();
                            }
                            else
                            {
                                selectionForm.Focus(); // Bring existing form to front
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }

                    // Reset the flag after showing the message box
                    messageBoxShown = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdminLogIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartScreenTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Toggle the showPassword flag
            showPassword = !showPassword;

            // Update the UseSystemPasswordChar property based on the flag
            textBox2.UseSystemPasswordChar = !showPassword;

            // Change the button text accordingly
            showButton.Text = showPassword ? "Hide" : "Show";
        }
    }
}

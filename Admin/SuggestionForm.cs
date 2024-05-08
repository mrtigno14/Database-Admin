using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Admin
{
    public partial class SuggestionForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private string username;
        private string password;

        public SuggestionForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

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

        private void SuggestionForm_Load(object sender, EventArgs e)
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

            loadkeywords();
        }

        public void loadkeywords()
        {
            try
            {
                FirebaseResponse response = client.Get("Keywords/");
                Dictionary<string, Keywords> getKeywords = response.ResultAs<Dictionary<string, Keywords>>();

                foreach (var get in getKeywords)
                {
                    viewsuggestion.Rows.Add(
                        get.Value.ID,
                        get.Value.keyword,
                        get.Value.available,
                        get.Value.unavailable,
                        get.Value.description,
                        get.Value.sourcelink
                        );
                }
            }
            catch
            {
                MessageBox.Show("No data from Firebase.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(keyword.Text) ||
        string.IsNullOrWhiteSpace(available.Text) || string.IsNullOrWhiteSpace(unavailable.Text) || 
        string.IsNullOrWhiteSpace(description.Text) || string.IsNullOrWhiteSpace(sourcelink.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the method if any field is empty
            }

            Keywords key = new Keywords()
            {
                ID = id.Text,
                keyword = keyword.Text,
                available = available.Text,
                unavailable = unavailable.Text,
                description = description.Text,
                sourcelink = sourcelink.Text


            };

            FirebaseResponse response = client.Set("Keywords/" + id.Text, key);
            

            viewsuggestion.DataSource = null;
            viewsuggestion.Rows.Clear();
            loadkeywords();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("Keywords/" + id.Text);
            
            id.Text = string.Empty;
            keyword.Text = string.Empty;
            available.Text = string.Empty;
            unavailable.Text = string.Empty;
            description.Text = string.Empty;
            sourcelink.Text = string.Empty;

            viewsuggestion.DataSource = null;
            viewsuggestion.Rows.Clear();
            loadkeywords();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(keyword.Text) ||
        string.IsNullOrWhiteSpace(available.Text) || string.IsNullOrWhiteSpace(unavailable.Text) ||
        string.IsNullOrWhiteSpace(description.Text) || string.IsNullOrWhiteSpace(sourcelink.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the method if any field is empty
            }

            var key = new Keywords
            {
                ID = id.Text,
                keyword = keyword.Text,
                available = available.Text,
                unavailable = unavailable.Text,
                description = description.Text,
                sourcelink = sourcelink.Text

            };



            FirebaseResponse response = client.Update("Keywords/" + id.Text, key);
            
            id.Text = string.Empty;
            keyword.Text = string.Empty;
            available.Text = string.Empty;
            unavailable.Text = string.Empty;
            description.Text = string.Empty;
            sourcelink.Text = string.Empty;

            viewsuggestion.DataSource = null;
            viewsuggestion.Rows.Clear();
            loadkeywords();

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Keywords/" + id.Text);

            // Check if the response is null
            if (response == null || response.ResultAs<Keywords>() == null)
            {
                // Display a message indicating that the ID does not exist
                MessageBox.Show("Item not found.");
                return;
            }

            Keywords keys = response.ResultAs<Keywords>();

            // Perform further operations only if the response is not null
            if (id.Text.Equals(keys.ID))
            {
                keyword.Text = keys.keyword;
                available.Text = keys.available;
                unavailable.Text = keys.unavailable;
                description.Text = keys.description;
                sourcelink.Text = keys.sourcelink;

                
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

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void unavailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            viewsuggestion.DataSource = null;
            viewsuggestion.Rows.Clear();
            loadkeywords();
        }
    }
}

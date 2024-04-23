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
                MessageBox.Show("WALANG LAMAN LODS");
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
                description = unavailable.Text,
                sourcelink = sourcelink.Text


            };

            FirebaseResponse response = client.Set("Keywords/" + id.Text, key);
            MessageBox.Show("UGH");

            viewsuggestion.DataSource = null;
            viewsuggestion.Rows.Clear();
            loadkeywords();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("Keywords/" + id.Text);
            MessageBox.Show("Nawala na sha :(");
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
            MessageBox.Show("MAGBAGO KA NA RIN");
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

                MessageBox.Show("HULI KA BOI");
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
    }
}

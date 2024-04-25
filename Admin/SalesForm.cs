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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin
{
    public partial class SalesForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private string username;
        private string password;

        public SalesForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;


        }

        private void SalesForm_Load(object sender, EventArgs e)
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

            
            loadsales();
            
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            // Check if there is text in the TextBox
            if (!string.IsNullOrEmpty(id.Text))
            {
                // If there is text, make the ListBox visible and update its content
                idListBox.Visible = true;
                loadsales(id.Text);
            }
            else
            {
                // If there is no text, hide the ListBox
                idListBox.Visible = false;
            }
        }

        public void loadsales(string searchQuery = "")
        {
            try
            {
                FirebaseResponse response = client.Get("Sales/");
                Dictionary<string, Sales> getSales = response.ResultAs<Dictionary<string, Sales>>();

                // Clear previous items in the ListBox
                idListBox.Items.Clear();
                // Clear previous items in the DataGridView
                viewsale.Rows.Clear();

                bool found = false; // Flag to check if any matching item is found

                foreach (var get in getSales)
                {
                    // Check if the ID contains the search query
                    if (get.Value.ID.Contains(searchQuery))
                    {
                        // Add the ID to the ListBox
                        idListBox.Items.Add(get.Value.ID);
                        found = true;
                    }

                    viewsale.Rows.Add(
                        get.Value.ID,
                        get.Value.productName,
                        get.Value.price,
                        get.Value.quantity,
                        get.Value.salesPrice
                    );
                }
                // If no matching item is found, hide the ListBox
                if (!found)
                {
                    idListBox.Visible = false;
                }

            }

            catch
            {
                MessageBox.Show("WALANG LAMAN LODS");
            }
        }

        private void idListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (idListBox.SelectedItem != null)
            {
                // Set the text of TextBox to the selected item in the ListBox
                id.Text = idListBox.SelectedItem.ToString();

                // Hide the ListBox
                idListBox.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}

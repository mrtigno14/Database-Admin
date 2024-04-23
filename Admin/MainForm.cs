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
    public partial class MainForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        private string username;
        private string password;

        public MainForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Form2_Load(object sender, EventArgs e)
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

            purchased.Enabled = false;
            loadmedicines();
        }

        public void loadmedicines()
        {
            try
            {
                FirebaseResponse response = client.Get("VendingMachine/");
                Dictionary<string, VendingMachine> getMedicines = response.ResultAs<Dictionary<string, VendingMachine>>();

                foreach (var get in getMedicines)
                {
                    viewmedicine.Rows.Add(
                        get.Value.ID,
                        get.Value.itemName,
                        get.Value.itemPrice,
                        get.Value.itemQuantity,
                        get.Value.itemSold
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
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(name.Text) ||
        string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(quantity.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the method if any field is empty
            }

            VendingMachine med = new VendingMachine()
            {
                ID = id.Text,
                itemName = name.Text,
                itemPrice = price.Text,
                itemQuantity = quantity.Text,
                itemSold = "XD"
                

            };

            FirebaseResponse response = client.Set("VendingMachine/" + id.Text, med);
            MessageBox.Show("UGH");

            viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            loadmedicines();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("VendingMachine/" + id.Text);
            MessageBox.Show("Nawala na sha :(");
            id.Text = string.Empty;
            name.Text = string.Empty;
            price.Text = string.Empty;
            quantity.Text = string.Empty;
            purchased.Text = string.Empty;

            viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            loadmedicines();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(name.Text) ||
        string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(quantity.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the method if any field is empty
            }

            var med = new VendingMachine
            {
                ID = id.Text,
                itemName = name.Text,
                itemPrice = price.Text,
                itemQuantity = quantity.Text,
                itemSold = purchased.Text
            };

            

            FirebaseResponse response = client.Update("VendingMachine/" + id.Text, med);
            MessageBox.Show("MAGBAGO KA NA RIN");
            id.Text = string.Empty;
            name.Text = string.Empty;
            price.Text = string.Empty;
            quantity.Text = string.Empty;
            purchased.Text = string.Empty;

            viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            loadmedicines();

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("VendingMachine/" + id.Text);

            // Check if the response is null
            if (response == null || response.ResultAs<VendingMachine>() == null)
            {
                // Display a message indicating that the ID does not exist
                MessageBox.Show("Item not found.");
                return;
            }

            VendingMachine meds = response.ResultAs<VendingMachine>();

            // Perform further operations only if the response is not null
            if (id.Text.Equals(meds.ID))
            {
                name.Text = meds.itemName;
                price.Text = meds.itemPrice;
                quantity.Text = meds.itemQuantity;
                purchased.Text = meds.itemSold;
                MessageBox.Show("HULI KA BOI");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
           /* viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            
            loadmedicines();*/
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

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the current form and show the SelectinForm
            SelectionForm selectionForm = new SelectionForm("username", "password");
            selectionForm.Show();

            this.Hide();
        }
    }
}

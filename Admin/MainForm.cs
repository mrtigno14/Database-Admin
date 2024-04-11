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
            AuthSecret = "6R9gVfx8BoxVn5pIx9jaLQ5Are0WTTfB8OwaNzos",
            BasePath = "https://vending-machine-8d123-default-rtdb.firebaseio.com/",
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
                FirebaseResponse response = client.Get("Medicines/");
                Dictionary<string, Medicines> getMedicines = response.ResultAs<Dictionary<string, Medicines>>();

                foreach (var get in getMedicines)
                {
                    viewmedicine.Rows.Add(
                        get.Value.ID,
                        get.Value.Name,
                        get.Value.Price,
                        get.Value.Quantity,
                        get.Value.Purchased
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

            Medicines med = new Medicines()
            {
                ID = id.Text,
                Name = name.Text,
                Price = price.Text,
                Quantity = quantity.Text,
                Purchased = "XD"
                

            };

            FirebaseResponse response = client.Set("Medicines/" + id.Text, med);
            MessageBox.Show("UGH");

            viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            loadmedicines();

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("Medicines/" + id.Text);
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

            var med = new Medicines
            {
                ID = id.Text,
                Name = name.Text,
                Price = price.Text,
                Quantity = quantity.Text,
                Purchased = purchased.Text
            };

            

            FirebaseResponse response = client.Update("Medicines/" + id.Text, med);
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
            FirebaseResponse response = client.Get("Medicines/" + id.Text);

            Medicines meds = response.ResultAs<Medicines>();

            if (id.Text.Equals(meds.ID))
            {
                name.Text = meds.Name;
                price.Text = meds.Price;
                quantity.Text = meds.Quantity;
                purchased.Text = meds.Purchased;
                MessageBox.Show("HULI KA BOI");

            }

            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
           /* viewmedicine.DataSource = null;
            viewmedicine.Rows.Clear();
            
            loadmedicines();*/
        }
    }
}

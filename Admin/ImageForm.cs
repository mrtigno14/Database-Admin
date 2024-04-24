
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Firebase.Storage; // Add this namespace for Firebase Storage


namespace Admin
{
    public partial class ImageForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "imsTC4f93bN40grmNjB6Piyiq5tOaqRjVVeuOU42",
            BasePath = "https://keywords-e2507-default-rtdb.firebaseio.com/",
        };

        
        IFirebaseClient client;

        private string username;
        private string password;

      


        public ImageForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

        }

        private void ImageForm_Load(object sender, EventArgs e)
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

        //Image img = new Bitmap(ofd.FileName);
        //imageBox.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());
        private async void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image to Upload";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                //Image img = new Bitmap(ofd.FileName);
                //imageBox.Image = img.GetThumbnailImage(350, 200, null, new IntPtr());

                try
                {
                    await UploadFile(filePath, fileName);
                    MessageBox.Show("Image uploaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}");
                }
            }
        }

        private async Task UploadFile(string filePath, string fileName)
        {
            try
            {
                // Initialize Firebase Storage with your FirebaseApp
                FirebaseStorage storage = new FirebaseStorage("keywords-e2507.appspot.com");

                // Upload the file
                var task = storage
                    .Child("Images")
                    .Child(fileName)
                    .PutAsync(File.OpenRead(filePath));

                // Wait for the upload to complete
                var downloadUrl = await task;

                // The downloadUrl variable now contains the URL of the uploaded file
                MessageBox.Show("Image uploaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading image: {ex.Message}");
            }
        }




        private void insertButton_Click(object sender, EventArgs e)
        {

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {

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

        
    }
}


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
        private string filePath; // Declare class-level variable to store file path
        private string fileName;




        public ImageForm(string username, string password)
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

            url.Enabled = false;
            loadimages();
        }

        public void loadimages()
        {
            try
            {
                FirebaseResponse response = client.Get("Files/");

                // Check if the response is null or empty
                if (response != null && response.Body != "null")
                {
                    // Deserialize the response to Dictionary<string, Images>
                    Dictionary<string, Images> getImages = response.ResultAs<Dictionary<string, Images>>();

                    // Check if getImages is not null
                    if (getImages != null)
                    {
                        foreach (var get in getImages)
                        {
                            viewimage.Rows.Add(
                                get.Value.ID,
                                get.Value.fileName,
                                get.Value.fileUrl
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("No images found.");
                    }
                }
                else
                {
                    MessageBox.Show("No data from Firebase.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image to Upload";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileName = Path.GetFileName(filePath);

                // Load the selected image
                Image selectedImage = Image.FromFile(filePath);

                // Stretch the image to fit into the imageBox control
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBox.Image = selectedImage;
            }
        }

        private async void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id.Text) || string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Exit the method if any field is empty
            }

            if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(fileName))
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

                    

                    // Set the URL text box with the download URL
                    url.Text = downloadUrl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select an image to upload.");
            }

            Images image = new Images()
            {
                ID = id.Text,
                fileName = name.Text,
                fileUrl = url.Text,
            };

            FirebaseResponse response = client.Set("Files/" + id.Text, image);
            

            viewimage.DataSource = null;
            viewimage.Rows.Clear();
            loadimages();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("Files/" + id.Text);

            // Check if the response is null
            if (response == null || response.ResultAs<Images>() == null)
            {
                // Display a message indicating that the ID does not exist
                MessageBox.Show("Item not found.");
                return;
            }

            Images images = response.ResultAs<Images>();

            // Perform further operations only if the response is not null
            if (id.Text.Equals(images.ID))
            {
                name.Text = images.fileName;
                url.Text = images.fileUrl;
                

                
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

        private void copyButton_Click(object sender, EventArgs e)
        {
            // Check if the URL text box is not empty
            if (!string.IsNullOrEmpty(url.Text))
            {
                // Copy the text inside the URL text box to the clipboard
                Clipboard.SetText(url.Text);

                // Show a message to indicate that the URL has been copied
                MessageBox.Show("URL copied to clipboard.");
            }
            else
            {
                // Show a message if the URL text box is empty
                MessageBox.Show("No URL to copy.");
            }
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            // Check if the ID and URL text boxes are not empty
            if (!string.IsNullOrWhiteSpace(id.Text) && !string.IsNullOrWhiteSpace(url.Text))
            {
                // Extract the file name from the URL
                Uri uri = new Uri(url.Text);
                string fileNameToDelete = Path.GetFileName(uri.LocalPath);

                // Delete the file information from the database
                FirebaseResponse response = client.Delete("Files/" + id.Text);
                MessageBox.Show("File information deleted from database.");

                // Check if the response from deleting the file information is successful
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Delete the corresponding file from Firebase Storage
                    try
                    {
                        FirebaseStorage storage = new FirebaseStorage("keywords-e2507.appspot.com");
                        await storage.Child("Images").Child(fileNameToDelete).DeleteAsync();
                        MessageBox.Show("File deleted from Firebase Storage.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file from Firebase Storage: {ex.Message}");
                    }
                }

                // Clear the text boxes and reload the images
                id.Text = string.Empty;
                name.Text = string.Empty;
                url.Text = string.Empty;

                viewimage.DataSource = null;
                viewimage.Rows.Clear();
                loadimages();
            }
            else
            {
                // Show a message if the ID or URL text boxes are empty
                MessageBox.Show("Please enter both the ID and URL of the file to be removed.");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            viewimage.DataSource = null;
            viewimage.Rows.Clear();
            loadimages();
        }
    }
}

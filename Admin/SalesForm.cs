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
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
                FirebaseResponse response = client.Get("TotalSales/");

                // Check if the response is not null and contains data
                if (response != null && response.Body != "null")
                {
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
                            get.Value.itemName,  
                            get.Value.itemSold,
                            get.Value.totalPrice
                            
                        );
                    }
                    // If no matching item is found, hide the ListBox
                    if (!found)
                    {
                        idListBox.Visible = false;
                    }
                }
                else
                {
                    // Handle the case when there is no data in the "Sales/" node
                    MessageBox.Show("No sales data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
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



        private void savethisButton_Click(object sender, EventArgs e)
        {
            // Get the ID from the id TextBox
            string ID = id.Text;

            // Check if the ID is not empty
            if (!string.IsNullOrEmpty(ID))
            {
                // Call the ExportRowAsPDF method with the DataGridView and the ID
                ExportRowAsPDF(viewsale, ID);
            }
            else
            {
                MessageBox.Show("Please enter an ID.");
            }
        }

        private void ExportRowAsPDF(DataGridView dataGridView, string ID)
        {
            // Find the row index corresponding to the given ID value
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Column1"].Value.ToString() == ID)
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            // If the row index is valid, export the row as a PDF
            if (rowIndex >= 0)
            {
                // Create a SaveFileDialog for selecting the PDF file path
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";

                // Show the SaveFileDialog and get the selected file path
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Create a new PDF document
                    Document doc = new Document();
                    try
                    {
                        // Create a PdfWriter to write to the specified file path
                        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                        // Open the document
                        doc.Open();

                        // Add a header label "LMMN"
                        Paragraph header = new Paragraph("LMMN");
                        header.Alignment = Element.ALIGN_CENTER;
                        doc.Add(header);

                        // Add a line break
                        doc.Add(new Chunk("\n"));

                        // Create a PdfPTable with the same number of columns as the DataGridView
                        PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

                        // Add column headers to the table
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            table.AddCell(new Phrase(column.HeaderText));
                        }

                        // Add row data to the table
                        foreach (DataGridViewCell cell in dataGridView.Rows[rowIndex].Cells)
                        {
                            table.AddCell(new Phrase(cell.Value.ToString()));
                        }

                        // Add the table to the document
                        doc.Add(table);

                        MessageBox.Show("Row exported as PDF: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting to PDF: " + ex.Message);
                    }
                    finally
                    {
                        // Close the document
                        doc.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("ID not found in the DataGridView.");
            }
        }

        private void saveallButton_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save CSV File";

            // Show the SaveFileDialog and get the selected file path
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Call the ExportToCSV method with the selected file path
                ExportToCSV(viewsale, filePath);
            }
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            try
            {
                // Create a StringBuilder to store the CSV data
                StringBuilder csvContent = new StringBuilder();

                // Append column headers
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    csvContent.Append(column.HeaderText + ",");
                }
                csvContent.AppendLine();

                // Append rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Replace commas in cell values with spaces to avoid CSV formatting issues
                        string cellValue = cell.Value.ToString().Replace(",", " ");
                        csvContent.Append(cellValue + ",");
                    }
                    csvContent.AppendLine();
                }

                // Write the CSV data to the file
                File.WriteAllText(filePath, csvContent.ToString());

                MessageBox.Show("CSV file saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to CSV: " + ex.Message);
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

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete everything inside the "Sales/" node
                FirebaseResponse response = client.Delete("TotalSales/" + id.Text);

                // Inform the user that the data has been removed
                MessageBox.Show("All sales data has been removed successfully.");

                // Clear any displayed information or input fields
                id.Text = string.Empty;

                viewsale.DataSource = null;
                viewsale.Rows.Clear();

                // Reload sales data to reflect the changes
                loadsales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing sales data: " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            viewsale.DataSource = null;
            viewsale.Rows.Clear();
            loadsales();
        }
    }
}

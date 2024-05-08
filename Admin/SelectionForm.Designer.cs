namespace Admin
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.suggestionButton = new System.Windows.Forms.Button();
            this.medicineButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.notifIcon = new System.Windows.Forms.PictureBox();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // suggestionButton
            // 
            this.suggestionButton.BackColor = System.Drawing.Color.White;
            this.suggestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.suggestionButton.Location = new System.Drawing.Point(546, 369);
            this.suggestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.suggestionButton.Name = "suggestionButton";
            this.suggestionButton.Size = new System.Drawing.Size(281, 75);
            this.suggestionButton.TabIndex = 4;
            this.suggestionButton.Text = "SUGGESTION";
            this.suggestionButton.UseVisualStyleBackColor = false;
            this.suggestionButton.Click += new System.EventHandler(this.suggestionButton_Click);
            // 
            // medicineButton
            // 
            this.medicineButton.BackColor = System.Drawing.Color.White;
            this.medicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.medicineButton.Location = new System.Drawing.Point(546, 257);
            this.medicineButton.Margin = new System.Windows.Forms.Padding(4);
            this.medicineButton.Name = "medicineButton";
            this.medicineButton.Size = new System.Drawing.Size(281, 75);
            this.medicineButton.TabIndex = 5;
            this.medicineButton.Text = "MEDICINES";
            this.medicineButton.UseVisualStyleBackColor = false;
            this.medicineButton.Click += new System.EventHandler(this.medicineButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.logoutButton.Location = new System.Drawing.Point(1239, 24);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(113, 37);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.imageButton.Location = new System.Drawing.Point(546, 488);
            this.imageButton.Margin = new System.Windows.Forms.Padding(4);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(281, 75);
            this.imageButton.TabIndex = 18;
            this.imageButton.Text = "IMAGES";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.salesButton.Location = new System.Drawing.Point(546, 601);
            this.salesButton.Margin = new System.Windows.Forms.Padding(4);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(281, 75);
            this.salesButton.TabIndex = 19;
            this.salesButton.Text = "SALES";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(401, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(574, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select the database you want to access";
            // 
            // notifIcon
            // 
            this.notifIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notifIcon.BackgroundImage")));
            this.notifIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notifIcon.InitialImage = null;
            this.notifIcon.Location = new System.Drawing.Point(1084, 10);
            this.notifIcon.Name = "notifIcon";
            this.notifIcon.Size = new System.Drawing.Size(94, 86);
            this.notifIcon.TabIndex = 21;
            this.notifIcon.TabStop = false;
            this.notifIcon.Click += new System.EventHandler(this.notifIcon_Click);
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.BackColor = System.Drawing.Color.White;
            this.NotificationPanel.Location = new System.Drawing.Point(981, 120);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(371, 671);
            this.NotificationPanel.TabIndex = 22;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1365, 838);
            this.Controls.Add(this.NotificationPanel);
            this.Controls.Add(this.notifIcon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.medicineButton);
            this.Controls.Add(this.suggestionButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button suggestionButton;
        private System.Windows.Forms.Button medicineButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox notifIcon;
        private System.Windows.Forms.Panel NotificationPanel;
    }
}
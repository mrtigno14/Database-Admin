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
            this.suggestionButton = new System.Windows.Forms.Button();
            this.medicineButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suggestionButton
            // 
            this.suggestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.suggestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionButton.Location = new System.Drawing.Point(330, 205);
            this.suggestionButton.Name = "suggestionButton";
            this.suggestionButton.Size = new System.Drawing.Size(120, 33);
            this.suggestionButton.TabIndex = 4;
            this.suggestionButton.Text = "SUGGESTION";
            this.suggestionButton.UseVisualStyleBackColor = false;
            this.suggestionButton.Click += new System.EventHandler(this.suggestionButton_Click);
            // 
            // medicineButton
            // 
            this.medicineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.medicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineButton.Location = new System.Drawing.Point(330, 148);
            this.medicineButton.Name = "medicineButton";
            this.medicineButton.Size = new System.Drawing.Size(120, 33);
            this.medicineButton.TabIndex = 5;
            this.medicineButton.Text = "MEDICINES";
            this.medicineButton.UseVisualStyleBackColor = false;
            this.medicineButton.Click += new System.EventHandler(this.medicineButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(703, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(85, 30);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(330, 259);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(120, 33);
            this.imageButton.TabIndex = 18;
            this.imageButton.Text = "IMAGES";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.medicineButton);
            this.Controls.Add(this.suggestionButton);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button suggestionButton;
        private System.Windows.Forms.Button medicineButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button imageButton;
    }
}
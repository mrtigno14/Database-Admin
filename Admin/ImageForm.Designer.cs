﻿namespace Admin
{
    partial class ImageForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.viewimage = new System.Windows.Forms.DataGridView();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.RichTextBox();
            this.url = new System.Windows.Forms.RichTextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(136, 48);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.logoutButton.Location = new System.Drawing.Point(878, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(136, 48);
            this.logoutButton.TabIndex = 23;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // viewimage
            // 
            this.viewimage.AllowUserToAddRows = false;
            this.viewimage.AllowUserToDeleteRows = false;
            this.viewimage.BackgroundColor = System.Drawing.Color.White;
            this.viewimage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewimage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.viewimage.Location = new System.Drawing.Point(352, 100);
            this.viewimage.Name = "viewimage";
            this.viewimage.ReadOnly = true;
            this.viewimage.RowHeadersWidth = 51;
            this.viewimage.Size = new System.Drawing.Size(644, 479);
            this.viewimage.TabIndex = 24;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imageBox.Location = new System.Drawing.Point(50, 100);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(265, 226);
            this.imageBox.TabIndex = 25;
            this.imageBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.White;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.browseButton.Location = new System.Drawing.Point(86, 504);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(85, 30);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.White;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.insertButton.Location = new System.Drawing.Point(196, 504);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(85, 30);
            this.insertButton.TabIndex = 27;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // retrieveButton
            // 
            this.retrieveButton.BackColor = System.Drawing.Color.White;
            this.retrieveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.retrieveButton.Location = new System.Drawing.Point(86, 540);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(85, 30);
            this.retrieveButton.TabIndex = 28;
            this.retrieveButton.Text = "Retrieve";
            this.retrieveButton.UseVisualStyleBackColor = false;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.White;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.copyButton.Location = new System.Drawing.Point(196, 540);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(85, 30);
            this.copyButton.TabIndex = 29;
            this.copyButton.Text = "Copy Link";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(95, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(147, 21);
            this.name.TabIndex = 30;
            this.name.Text = "";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(94, 84);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(147, 21);
            this.url.TabIndex = 31;
            this.url.Text = "";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(94, 28);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(148, 20);
            this.id.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "File Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "File Url";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.removeButton.Location = new System.Drawing.Point(145, 577);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 30);
            this.removeButton.TabIndex = 36;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.refreshButton.Location = new System.Drawing.Point(912, 586);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(85, 30);
            this.refreshButton.TabIndex = 37;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.url);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 125);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 51);
            this.panel2.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(376, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "fileName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "fileUrl";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 387;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.viewimage);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.backButton);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView viewimage;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.RichTextBox name;
        private System.Windows.Forms.RichTextBox url;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
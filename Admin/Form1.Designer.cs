﻿namespace Admin
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminLoginDesc = new System.Windows.Forms.Label();
            this.AdminLogIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 304);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(239, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLoginDesc
            // 
            this.AdminLoginDesc.AutoSize = true;
            this.AdminLoginDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.AdminLoginDesc.Location = new System.Drawing.Point(160, 237);
            this.AdminLoginDesc.Name = "AdminLoginDesc";
            this.AdminLoginDesc.Size = new System.Drawing.Size(276, 25);
            this.AdminLoginDesc.TabIndex = 1;
            this.AdminLoginDesc.Text = "Please enter your login details.";
            // 
            // AdminLogIn
            // 
            this.AdminLogIn.AutoSize = true;
            this.AdminLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.AdminLogIn.Location = new System.Drawing.Point(171, 191);
            this.AdminLogIn.Name = "AdminLogIn";
            this.AdminLogIn.Size = new System.Drawing.Size(265, 46);
            this.AdminLogIn.TabIndex = 0;
            this.AdminLogIn.Text = "Admin Login ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(376, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 51);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.showButton);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.AdminLoginDesc);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.AdminLogIn);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(200, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 439);
            this.panel3.TabIndex = 19;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(431, 304);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(43, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(171, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.exitButton.Location = new System.Drawing.Point(886, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(69, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(69, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 35;
            this.elipseControl3.TargetControl = this.button1;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this.panel3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AdminLogIn;
        private System.Windows.Forms.Label AdminLoginDesc;
        private ElipseToolDemo.ElipseControl elipseControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


namespace Admin
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
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.SignInPanel2 = new System.Windows.Forms.Panel();
            this.AdminLoginDesc = new System.Windows.Forms.Label();
            this.AdminLogIn = new System.Windows.Forms.Label();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.elipseControl3 = new ElipseToolDemo.ElipseControl();
            this.label2 = new System.Windows.Forms.Label();
            this.StartScreenFooter = new System.Windows.Forms.Label();
            this.StartScreenTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInPanel.SuspendLayout();
            this.SignInPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.BackColor = System.Drawing.Color.White;
            this.SignInPanel.Controls.Add(this.textBox1);
            this.SignInPanel.Controls.Add(this.button1);
            this.SignInPanel.Controls.Add(this.textBox2);
            this.SignInPanel.Location = new System.Drawing.Point(209, 165);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(371, 210);
            this.SignInPanel.TabIndex = 4;
            // 
            // SignInPanel2
            // 
            this.SignInPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(222)))), ((int)(((byte)(88)))));
            this.SignInPanel2.Controls.Add(this.AdminLoginDesc);
            this.SignInPanel2.Controls.Add(this.AdminLogIn);
            this.SignInPanel2.Location = new System.Drawing.Point(223, 131);
            this.SignInPanel2.Name = "SignInPanel2";
            this.SignInPanel2.Size = new System.Drawing.Size(342, 68);
            this.SignInPanel2.TabIndex = 5;
            // 
            // AdminLoginDesc
            // 
            this.AdminLoginDesc.AutoSize = true;
            this.AdminLoginDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginDesc.Location = new System.Drawing.Point(75, 41);
            this.AdminLoginDesc.Name = "AdminLoginDesc";
            this.AdminLoginDesc.Size = new System.Drawing.Size(203, 17);
            this.AdminLoginDesc.TabIndex = 1;
            this.AdminLoginDesc.Text = "Please enter your login details.";
            // 
            // AdminLogIn
            // 
            this.AdminLogIn.AutoSize = true;
            this.AdminLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogIn.Location = new System.Drawing.Point(84, 9);
            this.AdminLogIn.Name = "AdminLogIn";
            this.AdminLogIn.Size = new System.Drawing.Size(182, 31);
            this.AdminLogIn.TabIndex = 0;
            this.AdminLogIn.Text = "Admin Login ";
            this.AdminLogIn.Click += new System.EventHandler(this.AdminLogIn_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 35;
            this.elipseControl1.TargetControl = this.SignInPanel;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 35;
            this.elipseControl2.TargetControl = this.SignInPanel2;
            // 
            // elipseControl3
            // 
            this.elipseControl3.CornerRadius = 35;
            this.elipseControl3.TargetControl = this.button1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Streamlined Over-the-Counter Medicine Dispensing Innovation";
            // 
            // StartScreenFooter
            // 
            this.StartScreenFooter.AutoSize = true;
            this.StartScreenFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(66)))));
            this.StartScreenFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenFooter.ForeColor = System.Drawing.Color.White;
            this.StartScreenFooter.Location = new System.Drawing.Point(272, 510);
            this.StartScreenFooter.Name = "StartScreenFooter";
            this.StartScreenFooter.Size = new System.Drawing.Size(310, 20);
            this.StartScreenFooter.TabIndex = 14;
            this.StartScreenFooter.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.StartScreenFooter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartScreenTitle
            // 
            this.StartScreenTitle.AutoSize = true;
            this.StartScreenTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.StartScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenTitle.ForeColor = System.Drawing.Color.White;
            this.StartScreenTitle.Location = new System.Drawing.Point(92, 35);
            this.StartScreenTitle.Name = "StartScreenTitle";
            this.StartScreenTitle.Size = new System.Drawing.Size(582, 46);
            this.StartScreenTitle.TabIndex = 13;
            this.StartScreenTitle.Text = "SMART Pharmaceutical Kiosk";
            this.StartScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "© 2024 LMMN, Inc. All rights reserved";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(84)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartScreenFooter);
            this.Controls.Add(this.StartScreenTitle);
            this.Controls.Add(this.SignInPanel2);
            this.Controls.Add(this.SignInPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.SignInPanel2.ResumeLayout(false);
            this.SignInPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SignInPanel;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel SignInPanel2;
        private System.Windows.Forms.Label AdminLogIn;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private System.Windows.Forms.Label AdminLoginDesc;
        private ElipseToolDemo.ElipseControl elipseControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StartScreenFooter;
        private System.Windows.Forms.Label StartScreenTitle;
        private System.Windows.Forms.Label label1;
    }
}


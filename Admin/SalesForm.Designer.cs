namespace Admin
{
    partial class SalesForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.viewsale = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.idListBox = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.TextBox();
            this.saveallButton = new System.Windows.Forms.Button();
            this.savethisButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewsale)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.logoutButton.Location = new System.Drawing.Point(832, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(136, 48);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // viewsale
            // 
            this.viewsale.AllowUserToAddRows = false;
            this.viewsale.AllowUserToDeleteRows = false;
            this.viewsale.BackgroundColor = System.Drawing.Color.White;
            this.viewsale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewsale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.viewsale.Location = new System.Drawing.Point(352, 100);
            this.viewsale.Name = "viewsale";
            this.viewsale.ReadOnly = true;
            this.viewsale.RowHeadersWidth = 51;
            this.viewsale.Size = new System.Drawing.Size(644, 474);
            this.viewsale.TabIndex = 24;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.removeButton.Location = new System.Drawing.Point(128, 544);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 30);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // idListBox
            // 
            this.idListBox.FormattingEnabled = true;
            this.idListBox.Location = new System.Drawing.Point(70, 62);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(125, 43);
            this.idListBox.TabIndex = 27;
            this.idListBox.Visible = false;
            this.idListBox.SelectedIndexChanged += new System.EventHandler(this.idListBox_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(70, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(125, 20);
            this.id.TabIndex = 28;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // saveallButton
            // 
            this.saveallButton.BackColor = System.Drawing.Color.White;
            this.saveallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveallButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.saveallButton.Location = new System.Drawing.Point(352, 580);
            this.saveallButton.Name = "saveallButton";
            this.saveallButton.Size = new System.Drawing.Size(100, 30);
            this.saveallButton.TabIndex = 29;
            this.saveallButton.Text = "Save All Data";
            this.saveallButton.UseVisualStyleBackColor = false;
            this.saveallButton.Click += new System.EventHandler(this.saveallButton_Click);
            // 
            // savethisButton
            // 
            this.savethisButton.BackColor = System.Drawing.Color.White;
            this.savethisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savethisButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.savethisButton.Location = new System.Drawing.Point(128, 507);
            this.savethisButton.Name = "savethisButton";
            this.savethisButton.Size = new System.Drawing.Size(103, 30);
            this.savethisButton.TabIndex = 30;
            this.savethisButton.Text = "Save This Data";
            this.savethisButton.UseVisualStyleBackColor = false;
            this.savethisButton.Click += new System.EventHandler(this.savethisButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.refreshButton.Location = new System.Drawing.Point(894, 580);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(103, 30);
            this.refreshButton.TabIndex = 31;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.idListBox);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(49, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 377);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 51);
            this.panel2.TabIndex = 33;
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
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 262;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sold";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.savethisButton);
            this.Controls.Add(this.saveallButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.viewsale);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Location = new System.Drawing.Point(470, 123);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewsale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView viewsale;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox idListBox;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button saveallButton;
        private System.Windows.Forms.Button savethisButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
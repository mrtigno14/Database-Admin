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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.idListBox = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewsale)).BeginInit();
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
            this.Column4,
            this.Column5});
            this.viewsale.Location = new System.Drawing.Point(331, 66);
            this.viewsale.Name = "viewsale";
            this.viewsale.ReadOnly = true;
            this.viewsale.Size = new System.Drawing.Size(523, 442);
            this.viewsale.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sale Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 69;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.White;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.removeButton.Location = new System.Drawing.Point(105, 376);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(85, 30);
            this.removeButton.TabIndex = 25;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // idListBox
            // 
            this.idListBox.FormattingEnabled = true;
            this.idListBox.Location = new System.Drawing.Point(105, 209);
            this.idListBox.Name = "idListBox";
            this.idListBox.Size = new System.Drawing.Size(125, 43);
            this.idListBox.TabIndex = 27;
            this.idListBox.Visible = false;
            this.idListBox.SelectedIndexChanged += new System.EventHandler(this.idListBox_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(105, 183);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(125, 20);
            this.id.TabIndex = 28;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 658);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.viewsale);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewsale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView viewsale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox idListBox;
        private System.Windows.Forms.TextBox id;
    }
}
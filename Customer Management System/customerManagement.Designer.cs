namespace Customer_Management_System
{
    partial class CustomerManagement
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
            this.Title = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dgvinformation = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.errorEmptyInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(193, 9);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title.Size = new System.Drawing.Size(482, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "Patrick\'s Customer Management System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(118, 306);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(167, 20);
            this.txtContact.TabIndex = 8;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.Color.White;
            this.Contact.Location = new System.Drawing.Point(23, 307);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(84, 19);
            this.Contact.TabIndex = 4;
            this.Contact.Text = "Contact No";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 219);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(167, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLastName_KeyPress);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.White;
            this.lastName.Location = new System.Drawing.Point(23, 220);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(79, 19);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(118, 175);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFirstName_KeyPress);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.Location = new System.Drawing.Point(23, 176);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(81, 19);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.Location = new System.Drawing.Point(23, 260);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(58, 19);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(118, 261);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(167, 21);
            this.txtGender.TabIndex = 7;
            this.txtGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGender_KeyPress);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addButton.FlatAppearance.BorderSize = 4;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(27, 361);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 36);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 5;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(107, 361);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 36);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Orange;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 5;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(193, 361);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // dgvinformation
            // 
            this.dgvinformation.AllowUserToAddRows = false;
            this.dgvinformation.AllowUserToDeleteRows = false;
            this.dgvinformation.BackgroundColor = System.Drawing.Color.White;
            this.dgvinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinformation.GridColor = System.Drawing.SystemColors.Control;
            this.dgvinformation.Location = new System.Drawing.Point(323, 175);
            this.dgvinformation.Name = "dgvinformation";
            this.dgvinformation.Size = new System.Drawing.Size(527, 222);
            this.dgvinformation.TabIndex = 14;
            this.dgvinformation.DoubleClick += new System.EventHandler(this.Dgvinformation_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(323, 136);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(453, 33);
            this.txtSearch.TabIndex = 12;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Blue;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 5;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(782, 136);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(68, 33);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // errorEmptyInfo
            // 
            this.errorEmptyInfo.AutoSize = true;
            this.errorEmptyInfo.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmptyInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorEmptyInfo.Location = new System.Drawing.Point(24, 136);
            this.errorEmptyInfo.Name = "errorEmptyInfo";
            this.errorEmptyInfo.Size = new System.Drawing.Size(297, 13);
            this.errorEmptyInfo.TabIndex = 25;
            this.errorEmptyInfo.Text = "Please make sure to fill out all the different information needed.";
            this.errorEmptyInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "Using C#/.Net Winform";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(868, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorEmptyInfo);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvinformation);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(884, 485);
            this.MinimumSize = new System.Drawing.Size(884, 485);
            this.Name = "CustomerManagement";
            this.Text = "Customer Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerManagement_FormClosing);
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label errorEmptyInfo;
        private System.Windows.Forms.DataGridView dgvinformation;
        private System.Windows.Forms.Label label1;
    }
}


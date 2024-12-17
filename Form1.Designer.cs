namespace University_Library
{

    partial class Form1
    {
        private Button btnGenerateExcel;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAdminID = new Label();
            txtAdminID = new TextBox();
            txtAdminUsername = new TextBox();
            txtAdminPassword = new TextBox();
            txtAdminFirstName = new TextBox();
            txtAdminLastName = new TextBox();
            txtAdminEmail = new TextBox();
            txtAdminPhone = new TextBox();
            lblAdminUsername = new Label();
            lblAdminPassword = new Label();
            lblAdminFirstName = new Label();
            lblAdminLastName = new Label();
            lblAdminEmail = new Label();
            lblAdminPhone = new Label();
            btnInsertAdmin = new Button();
            lblBookPublisherId = new Label();
            lblBookAdminId = new Label();
            lblBookPublicationYear = new Label();
            lblBookTitle = new Label();
            lblBookAuthor = new Label();
            lblBookID = new Label();
            txtBookPublisherId = new TextBox();
            txtBookAdminId = new TextBox();
            txtBookPublicationYear = new TextBox();
            txtBookTitle = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookID = new TextBox();
            btnInsertBook = new Button();
            lblDeleteAdminID = new Label();
            txtDeleteAdminID = new TextBox();
            btnDeleteAdmin = new Button();
            lblDeleteBookID = new Label();
            txtDeleteBookID = new TextBox();
            btnDeleteBook = new Button();
            lblUpdateAdminEmail = new Label();
            lblUpdateAdminID = new Label();
            txtUpdateAdminEmail = new TextBox();
            txtUpdateAdminID = new TextBox();
            btnUpdateAdminEmail = new Button();
            lblUpdateBookTitle = new Label();
            lblUpdateBookID = new Label();
            txtUpdateBookTitle = new TextBox();
            txtUpdateBookID = new TextBox();
            btnUpdateBookTitle = new Button();
            btnSelectAdmins = new Button();
            listBoxAdmins = new ListBox();
            lblPublisherId = new Label();
            txtPublisherId = new TextBox();
            btnSelectBooksByPublisher = new Button();
            listBoxBooks = new ListBox();
            btnSelectBooksAndAdmins = new Button();
            listBoxBooksAndAdmins = new ListBox();
            btnGenerateExcel = new Button();
            btnShowUsers = new Button();
            Show_All_Books_Grid = new DataGridView();
            btn_to_Dashboard = new Button();
            ((System.ComponentModel.ISupportInitialize)Show_All_Books_Grid).BeginInit();
            SuspendLayout();
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Location = new Point(59, 32);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(88, 25);
            lblAdminID.TabIndex = 0;
            lblAdminID.Text = "Admin ID";
            // 
            // txtAdminID
            // 
            txtAdminID.Location = new Point(28, 60);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(150, 31);
            txtAdminID.TabIndex = 1;
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.Location = new Point(234, 60);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(150, 31);
            txtAdminUsername.TabIndex = 2;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(424, 60);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(150, 31);
            txtAdminPassword.TabIndex = 3;
            // 
            // txtAdminFirstName
            // 
            txtAdminFirstName.Location = new Point(623, 60);
            txtAdminFirstName.Name = "txtAdminFirstName";
            txtAdminFirstName.Size = new Size(150, 31);
            txtAdminFirstName.TabIndex = 4;
            // 
            // txtAdminLastName
            // 
            txtAdminLastName.Location = new Point(830, 60);
            txtAdminLastName.Name = "txtAdminLastName";
            txtAdminLastName.Size = new Size(150, 31);
            txtAdminLastName.TabIndex = 5;
            // 
            // txtAdminEmail
            // 
            txtAdminEmail.Location = new Point(1012, 60);
            txtAdminEmail.Name = "txtAdminEmail";
            txtAdminEmail.Size = new Size(150, 31);
            txtAdminEmail.TabIndex = 6;
            // 
            // txtAdminPhone
            // 
            txtAdminPhone.Location = new Point(1211, 60);
            txtAdminPhone.Name = "txtAdminPhone";
            txtAdminPhone.Size = new Size(150, 31);
            txtAdminPhone.TabIndex = 7;
            // 
            // lblAdminUsername
            // 
            lblAdminUsername.AutoSize = true;
            lblAdminUsername.Location = new Point(264, 32);
            lblAdminUsername.Name = "lblAdminUsername";
            lblAdminUsername.Size = new Size(91, 25);
            lblAdminUsername.TabIndex = 8;
            lblAdminUsername.Text = "Username";
            // 
            // lblAdminPassword
            // 
            lblAdminPassword.AutoSize = true;
            lblAdminPassword.Location = new Point(452, 32);
            lblAdminPassword.Name = "lblAdminPassword";
            lblAdminPassword.Size = new Size(87, 25);
            lblAdminPassword.TabIndex = 9;
            lblAdminPassword.Text = "Password";
            // 
            // lblAdminFirstName
            // 
            lblAdminFirstName.AutoSize = true;
            lblAdminFirstName.Location = new Point(657, 32);
            lblAdminFirstName.Name = "lblAdminFirstName";
            lblAdminFirstName.Size = new Size(97, 25);
            lblAdminFirstName.TabIndex = 10;
            lblAdminFirstName.Text = "First Name";
            // 
            // lblAdminLastName
            // 
            lblAdminLastName.AutoSize = true;
            lblAdminLastName.Location = new Point(852, 32);
            lblAdminLastName.Name = "lblAdminLastName";
            lblAdminLastName.Size = new Size(95, 25);
            lblAdminLastName.TabIndex = 11;
            lblAdminLastName.Text = "Last Name";
            // 
            // lblAdminEmail
            // 
            lblAdminEmail.AutoSize = true;
            lblAdminEmail.Location = new Point(1052, 32);
            lblAdminEmail.Name = "lblAdminEmail";
            lblAdminEmail.Size = new Size(54, 25);
            lblAdminEmail.TabIndex = 12;
            lblAdminEmail.Text = "Email";
            // 
            // lblAdminPhone
            // 
            lblAdminPhone.AutoSize = true;
            lblAdminPhone.Location = new Point(1249, 32);
            lblAdminPhone.Name = "lblAdminPhone";
            lblAdminPhone.Size = new Size(62, 25);
            lblAdminPhone.TabIndex = 13;
            lblAdminPhone.Text = "Phone";
            // 
            // btnInsertAdmin
            // 
            btnInsertAdmin.Location = new Point(657, 125);
            btnInsertAdmin.Name = "btnInsertAdmin";
            btnInsertAdmin.Size = new Size(164, 34);
            btnInsertAdmin.TabIndex = 14;
            btnInsertAdmin.Text = "Insert Admin";
            btnInsertAdmin.UseVisualStyleBackColor = true;
            btnInsertAdmin.Click += btnInsertAdmin_Click;
            // 
            // lblBookPublisherId
            // 
            lblBookPublisherId.AutoSize = true;
            lblBookPublisherId.Location = new Point(1037, 205);
            lblBookPublisherId.Name = "lblBookPublisherId";
            lblBookPublisherId.Size = new Size(107, 25);
            lblBookPublisherId.TabIndex = 15;
            lblBookPublisherId.Text = "Publisher ID";
            // 
            // lblBookAdminId
            // 
            lblBookAdminId.AutoSize = true;
            lblBookAdminId.Location = new Point(859, 205);
            lblBookAdminId.Name = "lblBookAdminId";
            lblBookAdminId.Size = new Size(88, 25);
            lblBookAdminId.TabIndex = 16;
            lblBookAdminId.Text = "Admin ID";
            // 
            // lblBookPublicationYear
            // 
            lblBookPublicationYear.AutoSize = true;
            lblBookPublicationYear.Location = new Point(623, 205);
            lblBookPublicationYear.Name = "lblBookPublicationYear";
            lblBookPublicationYear.Size = new Size(136, 25);
            lblBookPublicationYear.TabIndex = 17;
            lblBookPublicationYear.Text = "Publication Year";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(471, 205);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(44, 25);
            lblBookTitle.TabIndex = 18;
            lblBookTitle.Text = "Title";
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new Point(278, 205);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(67, 25);
            lblBookAuthor.TabIndex = 19;
            lblBookAuthor.Text = "Author";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(59, 205);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(76, 25);
            lblBookID.TabIndex = 20;
            lblBookID.Text = "Book ID";
            // 
            // txtBookPublisherId
            // 
            txtBookPublisherId.Location = new Point(1012, 233);
            txtBookPublisherId.Name = "txtBookPublisherId";
            txtBookPublisherId.Size = new Size(150, 31);
            txtBookPublisherId.TabIndex = 21;
            // 
            // txtBookAdminId
            // 
            txtBookAdminId.Location = new Point(830, 233);
            txtBookAdminId.Name = "txtBookAdminId";
            txtBookAdminId.Size = new Size(150, 31);
            txtBookAdminId.TabIndex = 22;
            // 
            // txtBookPublicationYear
            // 
            txtBookPublicationYear.Location = new Point(623, 233);
            txtBookPublicationYear.Name = "txtBookPublicationYear";
            txtBookPublicationYear.Size = new Size(150, 31);
            txtBookPublicationYear.TabIndex = 23;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(424, 233);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(150, 31);
            txtBookTitle.TabIndex = 24;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(234, 233);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(150, 31);
            txtBookAuthor.TabIndex = 25;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(28, 233);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(150, 31);
            txtBookID.TabIndex = 26;
            // 
            // btnInsertBook
            // 
            btnInsertBook.Location = new Point(657, 298);
            btnInsertBook.Name = "btnInsertBook";
            btnInsertBook.Size = new Size(164, 34);
            btnInsertBook.TabIndex = 27;
            btnInsertBook.Text = "Insert Book";
            btnInsertBook.UseVisualStyleBackColor = true;
            btnInsertBook.Click += btnInsertBook_Click_1;
            // 
            // lblDeleteAdminID
            // 
            lblDeleteAdminID.AutoSize = true;
            lblDeleteAdminID.Location = new Point(133, 363);
            lblDeleteAdminID.Name = "lblDeleteAdminID";
            lblDeleteAdminID.Size = new Size(88, 25);
            lblDeleteAdminID.TabIndex = 28;
            lblDeleteAdminID.Text = "Admin ID";
            // 
            // txtDeleteAdminID
            // 
            txtDeleteAdminID.Location = new Point(112, 391);
            txtDeleteAdminID.Name = "txtDeleteAdminID";
            txtDeleteAdminID.Size = new Size(150, 31);
            txtDeleteAdminID.TabIndex = 29;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.Location = new Point(414, 388);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(222, 34);
            btnDeleteAdmin.TabIndex = 30;
            btnDeleteAdmin.Text = "Delete Admin";
            btnDeleteAdmin.UseVisualStyleBackColor = true;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // lblDeleteBookID
            // 
            lblDeleteBookID.AutoSize = true;
            lblDeleteBookID.Location = new Point(998, 363);
            lblDeleteBookID.Name = "lblDeleteBookID";
            lblDeleteBookID.Size = new Size(76, 25);
            lblDeleteBookID.TabIndex = 31;
            lblDeleteBookID.Text = "Book ID";
            // 
            // txtDeleteBookID
            // 
            txtDeleteBookID.Location = new Point(956, 391);
            txtDeleteBookID.Name = "txtDeleteBookID";
            txtDeleteBookID.Size = new Size(150, 31);
            txtDeleteBookID.TabIndex = 32;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(1257, 382);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(222, 34);
            btnDeleteBook.TabIndex = 33;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click_1;
            // 
            // lblUpdateAdminEmail
            // 
            lblUpdateAdminEmail.AutoSize = true;
            lblUpdateAdminEmail.Location = new Point(234, 501);
            lblUpdateAdminEmail.Name = "lblUpdateAdminEmail";
            lblUpdateAdminEmail.Size = new Size(94, 25);
            lblUpdateAdminEmail.TabIndex = 34;
            lblUpdateAdminEmail.Text = "New Email";
            // 
            // lblUpdateAdminID
            // 
            lblUpdateAdminID.AutoSize = true;
            lblUpdateAdminID.Location = new Point(28, 501);
            lblUpdateAdminID.Name = "lblUpdateAdminID";
            lblUpdateAdminID.Size = new Size(88, 25);
            lblUpdateAdminID.TabIndex = 35;
            lblUpdateAdminID.Text = "Admin ID";
            // 
            // txtUpdateAdminEmail
            // 
            txtUpdateAdminEmail.Location = new Point(216, 529);
            txtUpdateAdminEmail.Name = "txtUpdateAdminEmail";
            txtUpdateAdminEmail.Size = new Size(150, 31);
            txtUpdateAdminEmail.TabIndex = 36;
            // 
            // txtUpdateAdminID
            // 
            txtUpdateAdminID.Location = new Point(10, 529);
            txtUpdateAdminID.Name = "txtUpdateAdminID";
            txtUpdateAdminID.Size = new Size(150, 31);
            txtUpdateAdminID.TabIndex = 37;
            // 
            // btnUpdateAdminEmail
            // 
            btnUpdateAdminEmail.Location = new Point(414, 526);
            btnUpdateAdminEmail.Name = "btnUpdateAdminEmail";
            btnUpdateAdminEmail.Size = new Size(222, 34);
            btnUpdateAdminEmail.TabIndex = 38;
            btnUpdateAdminEmail.Text = "Update Admin Email";
            btnUpdateAdminEmail.UseVisualStyleBackColor = true;
            btnUpdateAdminEmail.Click += btnUpdateAdminEmail_Click;
            // 
            // lblUpdateBookTitle
            // 
            lblUpdateBookTitle.AutoSize = true;
            lblUpdateBookTitle.Location = new Point(1078, 501);
            lblUpdateBookTitle.Name = "lblUpdateBookTitle";
            lblUpdateBookTitle.Size = new Size(84, 25);
            lblUpdateBookTitle.TabIndex = 39;
            lblUpdateBookTitle.Text = "New Title";
            // 
            // lblUpdateBookID
            // 
            lblUpdateBookID.AutoSize = true;
            lblUpdateBookID.Location = new Point(880, 501);
            lblUpdateBookID.Name = "lblUpdateBookID";
            lblUpdateBookID.Size = new Size(76, 25);
            lblUpdateBookID.TabIndex = 40;
            lblUpdateBookID.Text = "Book ID";
            // 
            // txtUpdateBookTitle
            // 
            txtUpdateBookTitle.Location = new Point(1051, 529);
            txtUpdateBookTitle.Name = "txtUpdateBookTitle";
            txtUpdateBookTitle.Size = new Size(150, 31);
            txtUpdateBookTitle.TabIndex = 41;
            // 
            // txtUpdateBookID
            // 
            txtUpdateBookID.Location = new Point(845, 529);
            txtUpdateBookID.Name = "txtUpdateBookID";
            txtUpdateBookID.Size = new Size(150, 31);
            txtUpdateBookID.TabIndex = 42;
            // 
            // btnUpdateBookTitle
            // 
            btnUpdateBookTitle.Location = new Point(1249, 529);
            btnUpdateBookTitle.Name = "btnUpdateBookTitle";
            btnUpdateBookTitle.Size = new Size(222, 34);
            btnUpdateBookTitle.TabIndex = 43;
            btnUpdateBookTitle.Text = "Update Book Title";
            btnUpdateBookTitle.UseVisualStyleBackColor = true;
            btnUpdateBookTitle.Click += btnUpdateBookTitle_Click_1;
            // 
            // btnSelectAdmins
            // 
            btnSelectAdmins.Location = new Point(1187, 635);
            btnSelectAdmins.Name = "btnSelectAdmins";
            btnSelectAdmins.Size = new Size(222, 34);
            btnSelectAdmins.TabIndex = 44;
            btnSelectAdmins.Text = "Select Admins";
            btnSelectAdmins.UseVisualStyleBackColor = true;
            btnSelectAdmins.Click += btnSelectAdmins_Click;
            // 
            // listBoxAdmins
            // 
            listBoxAdmins.FormattingEnabled = true;
            listBoxAdmins.ItemHeight = 25;
            listBoxAdmins.Location = new Point(1096, 693);
            listBoxAdmins.Name = "listBoxAdmins";
            listBoxAdmins.Size = new Size(414, 204);
            listBoxAdmins.TabIndex = 45;
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(610, 610);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(107, 25);
            lblPublisherId.TabIndex = 46;
            lblPublisherId.Text = "Publisher ID";
            // 
            // txtPublisherId
            // 
            txtPublisherId.Location = new Point(585, 638);
            txtPublisherId.Name = "txtPublisherId";
            txtPublisherId.Size = new Size(150, 31);
            txtPublisherId.TabIndex = 47;
            // 
            // btnSelectBooksByPublisher
            // 
            btnSelectBooksByPublisher.Location = new Point(758, 638);
            btnSelectBooksByPublisher.Name = "btnSelectBooksByPublisher";
            btnSelectBooksByPublisher.Size = new Size(222, 34);
            btnSelectBooksByPublisher.TabIndex = 48;
            btnSelectBooksByPublisher.Text = "Select Books";
            btnSelectBooksByPublisher.UseVisualStyleBackColor = true;
            btnSelectBooksByPublisher.Click += btnSelectBooksByPublisher_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 25;
            listBoxBooks.Location = new Point(566, 693);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(414, 204);
            listBoxBooks.TabIndex = 49;
            // 
            // btnSelectBooksAndAdmins
            // 
            btnSelectBooksAndAdmins.Location = new Point(106, 635);
            btnSelectBooksAndAdmins.Name = "btnSelectBooksAndAdmins";
            btnSelectBooksAndAdmins.Size = new Size(222, 34);
            btnSelectBooksAndAdmins.TabIndex = 50;
            btnSelectBooksAndAdmins.Text = "Select Books and Admins";
            btnSelectBooksAndAdmins.UseVisualStyleBackColor = true;
            btnSelectBooksAndAdmins.Click += btnSelectBooksAndAdmins_Click;
            // 
            // listBoxBooksAndAdmins
            // 
            listBoxBooksAndAdmins.FormattingEnabled = true;
            listBoxBooksAndAdmins.ItemHeight = 25;
            listBoxBooksAndAdmins.Location = new Point(23, 693);
            listBoxBooksAndAdmins.Name = "listBoxBooksAndAdmins";
            listBoxBooksAndAdmins.Size = new Size(414, 204);
            listBoxBooksAndAdmins.TabIndex = 51;
            // 
            // btnGenerateExcel
            // 
            btnGenerateExcel.Location = new Point(1791, 569);
            btnGenerateExcel.Name = "btnGenerateExcel";
            btnGenerateExcel.Size = new Size(209, 33);
            btnGenerateExcel.TabIndex = 1;
            btnGenerateExcel.Text = "Generate Excel Report";
            btnGenerateExcel.Click += btnGenerateExcel_Click_1;
            // 
            // btnShowUsers
            // 
            btnShowUsers.Location = new Point(1697, 125);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(428, 34);
            btnShowUsers.TabIndex = 52;
            btnShowUsers.Text = "Show All Books and Which Admin added them";
            btnShowUsers.UseVisualStyleBackColor = true;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // Show_All_Books_Grid
            // 
            Show_All_Books_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Show_All_Books_Grid.Location = new Point(1697, 182);
            Show_All_Books_Grid.Name = "Show_All_Books_Grid";
            Show_All_Books_Grid.RowHeadersWidth = 62;
            Show_All_Books_Grid.Size = new Size(428, 326);
            Show_All_Books_Grid.TabIndex = 53;
            Show_All_Books_Grid.CellContentClick += Show_Users_Grid_CellContentClick;
            // 
            // btn_to_Dashboard
            // 
            btn_to_Dashboard.Location = new Point(1791, 718);
            btn_to_Dashboard.Name = "btn_to_Dashboard";
            btn_to_Dashboard.Size = new Size(209, 34);
            btn_to_Dashboard.TabIndex = 54;
            btn_to_Dashboard.Text = "Dashboard";
            btn_to_Dashboard.UseVisualStyleBackColor = true;
            btn_to_Dashboard.Click += btn_to_Dashboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2245, 952);
            Controls.Add(btn_to_Dashboard);
            Controls.Add(Show_All_Books_Grid);
            Controls.Add(btnShowUsers);
            Controls.Add(btnGenerateExcel);
            Controls.Add(listBoxBooksAndAdmins);
            Controls.Add(btnSelectBooksAndAdmins);
            Controls.Add(listBoxBooks);
            Controls.Add(btnSelectBooksByPublisher);
            Controls.Add(txtPublisherId);
            Controls.Add(lblPublisherId);
            Controls.Add(listBoxAdmins);
            Controls.Add(btnSelectAdmins);
            Controls.Add(btnUpdateBookTitle);
            Controls.Add(txtUpdateBookID);
            Controls.Add(txtUpdateBookTitle);
            Controls.Add(lblUpdateBookID);
            Controls.Add(lblUpdateBookTitle);
            Controls.Add(btnUpdateAdminEmail);
            Controls.Add(txtUpdateAdminID);
            Controls.Add(txtUpdateAdminEmail);
            Controls.Add(lblUpdateAdminID);
            Controls.Add(lblUpdateAdminEmail);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtDeleteBookID);
            Controls.Add(lblDeleteBookID);
            Controls.Add(btnDeleteAdmin);
            Controls.Add(txtDeleteAdminID);
            Controls.Add(lblDeleteAdminID);
            Controls.Add(btnInsertBook);
            Controls.Add(txtBookID);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookTitle);
            Controls.Add(txtBookPublicationYear);
            Controls.Add(txtBookAdminId);
            Controls.Add(txtBookPublisherId);
            Controls.Add(lblBookID);
            Controls.Add(lblBookAuthor);
            Controls.Add(lblBookTitle);
            Controls.Add(lblBookPublicationYear);
            Controls.Add(lblBookAdminId);
            Controls.Add(lblBookPublisherId);
            Controls.Add(btnInsertAdmin);
            Controls.Add(lblAdminPhone);
            Controls.Add(lblAdminEmail);
            Controls.Add(lblAdminLastName);
            Controls.Add(lblAdminFirstName);
            Controls.Add(lblAdminPassword);
            Controls.Add(lblAdminUsername);
            Controls.Add(txtAdminPhone);
            Controls.Add(txtAdminEmail);
            Controls.Add(txtAdminLastName);
            Controls.Add(txtAdminFirstName);
            Controls.Add(txtAdminPassword);
            Controls.Add(txtAdminUsername);
            Controls.Add(txtAdminID);
            Controls.Add(lblAdminID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Show_All_Books_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminID;
        private TextBox txtAdminID;
        private TextBox txtAdminUsername;
        private TextBox txtAdminPassword;
        private TextBox txtAdminFirstName;
        private TextBox txtAdminLastName;
        private TextBox txtAdminEmail;
        private TextBox txtAdminPhone;
        private Label lblAdminUsername;
        private Label lblAdminPassword;
        private Label lblAdminFirstName;
        private Label lblAdminLastName;
        private Label lblAdminEmail;
        private Label lblAdminPhone;
        private Button btnInsertAdmin;
        private Label lblBookPublisherId;
        private Label lblBookAdminId;
        private Label lblBookPublicationYear;
        private Label lblBookTitle;
        private Label lblBookAuthor;
        private Label lblBookID;
        private TextBox txtBookPublisherId;
        private TextBox txtBookAdminId;
        private TextBox txtBookPublicationYear;
        private TextBox txtBookTitle;
        private TextBox txtBookAuthor;
        private TextBox txtBookID;
        private Button btnInsertBook;
        private Label lblDeleteAdminID;
        private TextBox txtDeleteAdminID;
        private Button btnDeleteAdmin;
        private Label lblDeleteBookID;
        private TextBox txtDeleteBookID;
        private Button btnDeleteBook;
        private Label lblUpdateAdminEmail;
        private Label lblUpdateAdminID;
        private TextBox txtUpdateAdminEmail;
        private TextBox txtUpdateAdminID;
        private Button btnUpdateAdminEmail;
        private Label lblUpdateBookTitle;
        private Label lblUpdateBookID;
        private TextBox txtUpdateBookTitle;
        private TextBox txtUpdateBookID;
        private Button btnUpdateBookTitle;
        private Button btnSelectAdmins;
        private ListBox listBoxAdmins;
        private Label lblPublisherId;
        private TextBox txtPublisherId;
        private Button btnSelectBooksByPublisher;
        private ListBox listBoxBooks;
        private Button btnSelectBooksAndAdmins;
        private ListBox listBoxBooksAndAdmins;
        private Button btnShowUsers;
        private DataGridView Show_All_Books_Grid;
        private Button btn_to_Dashboard;
    }

}

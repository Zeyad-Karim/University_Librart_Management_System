namespace University_Library
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Show_Users_Grid = new DataGridView();
            btnShowUsers = new Button();
            Grid_Show_Show_Books = new DataGridView();
            btn_Show_Books = new Button();
            Grid_Show_Publishers = new DataGridView();
            btn_Show_Publishers = new Button();
            Grid_Show_Borrow = new DataGridView();
            btn_Borrow_Status = new Button();
            Grid_Show_Admins = new DataGridView();
            btn_Show_Admins = new Button();
            Grid_Show_Copys = new DataGridView();
            btn_Show_Book_Copy = new Button();
            ((System.ComponentModel.ISupportInitialize)Show_Users_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Show_Books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Publishers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Borrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Admins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Copys).BeginInit();
            SuspendLayout();
            // 
            // Show_Users_Grid
            // 
            Show_Users_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Show_Users_Grid.Location = new Point(1701, 1085);
            Show_Users_Grid.Name = "Show_Users_Grid";
            Show_Users_Grid.RowHeadersWidth = 62;
            Show_Users_Grid.Size = new Size(677, 262);
            Show_Users_Grid.TabIndex = 55;
            // 
            // btnShowUsers
            // 
            btnShowUsers.Location = new Point(1959, 1045);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(209, 34);
            btnShowUsers.TabIndex = 54;
            btnShowUsers.Text = "Show Users";
            btnShowUsers.UseVisualStyleBackColor = true;
            btnShowUsers.Click += btnShowUsers_Click;
            // 
            // Grid_Show_Show_Books
            // 
            Grid_Show_Show_Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Show_Show_Books.Location = new Point(874, 52);
            Grid_Show_Show_Books.Name = "Grid_Show_Show_Books";
            Grid_Show_Show_Books.RowHeadersWidth = 62;
            Grid_Show_Show_Books.Size = new Size(677, 262);
            Grid_Show_Show_Books.TabIndex = 57;
            // 
            // btn_Show_Books
            // 
            btn_Show_Books.Location = new Point(1089, 12);
            btn_Show_Books.Name = "btn_Show_Books";
            btn_Show_Books.Size = new Size(209, 34);
            btn_Show_Books.TabIndex = 56;
            btn_Show_Books.Text = "Show Books";
            btn_Show_Books.UseVisualStyleBackColor = true;
            btn_Show_Books.Click += btn_Show_Books_Click;
            // 
            // Grid_Show_Publishers
            // 
            Grid_Show_Publishers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Show_Publishers.Location = new Point(1701, 649);
            Grid_Show_Publishers.Name = "Grid_Show_Publishers";
            Grid_Show_Publishers.RowHeadersWidth = 62;
            Grid_Show_Publishers.Size = new Size(677, 262);
            Grid_Show_Publishers.TabIndex = 59;
            // 
            // btn_Show_Publishers
            // 
            btn_Show_Publishers.Location = new Point(1959, 605);
            btn_Show_Publishers.Name = "btn_Show_Publishers";
            btn_Show_Publishers.Size = new Size(209, 34);
            btn_Show_Publishers.TabIndex = 58;
            btn_Show_Publishers.Text = "Show Publishers";
            btn_Show_Publishers.UseVisualStyleBackColor = true;
            btn_Show_Publishers.Click += button2_Click;
            // 
            // Grid_Show_Borrow
            // 
            Grid_Show_Borrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Show_Borrow.Location = new Point(1701, 46);
            Grid_Show_Borrow.Name = "Grid_Show_Borrow";
            Grid_Show_Borrow.RowHeadersWidth = 62;
            Grid_Show_Borrow.Size = new Size(677, 262);
            Grid_Show_Borrow.TabIndex = 61;
            // 
            // btn_Borrow_Status
            // 
            btn_Borrow_Status.Location = new Point(1959, 12);
            btn_Borrow_Status.Name = "btn_Borrow_Status";
            btn_Borrow_Status.Size = new Size(209, 34);
            btn_Borrow_Status.TabIndex = 60;
            btn_Borrow_Status.Text = "Show Borrow Status";
            btn_Borrow_Status.UseVisualStyleBackColor = true;
            btn_Borrow_Status.Click += btn_Borrow_Status_Click;
            // 
            // Grid_Show_Admins
            // 
            Grid_Show_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Show_Admins.Location = new Point(874, 1085);
            Grid_Show_Admins.Name = "Grid_Show_Admins";
            Grid_Show_Admins.RowHeadersWidth = 62;
            Grid_Show_Admins.Size = new Size(677, 262);
            Grid_Show_Admins.TabIndex = 63;
            // 
            // btn_Show_Admins
            // 
            btn_Show_Admins.Location = new Point(1093, 1041);
            btn_Show_Admins.Name = "btn_Show_Admins";
            btn_Show_Admins.Size = new Size(209, 34);
            btn_Show_Admins.TabIndex = 62;
            btn_Show_Admins.Text = "Show Admins";
            btn_Show_Admins.UseVisualStyleBackColor = true;
            btn_Show_Admins.Click += btn_Show_Admins_Click;
            // 
            // Grid_Show_Copys
            // 
            Grid_Show_Copys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Show_Copys.Location = new Point(874, 645);
            Grid_Show_Copys.Name = "Grid_Show_Copys";
            Grid_Show_Copys.RowHeadersWidth = 62;
            Grid_Show_Copys.Size = new Size(677, 262);
            Grid_Show_Copys.TabIndex = 65;
            // 
            // btn_Show_Book_Copy
            // 
            btn_Show_Book_Copy.Location = new Point(1089, 605);
            btn_Show_Book_Copy.Name = "btn_Show_Book_Copy";
            btn_Show_Book_Copy.Size = new Size(209, 34);
            btn_Show_Book_Copy.TabIndex = 64;
            btn_Show_Book_Copy.Text = "Show Book Copys";
            btn_Show_Book_Copy.UseVisualStyleBackColor = true;
            btn_Show_Book_Copy.Click += btn_Show_Book_Copy_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2379, 1359);
            Controls.Add(Grid_Show_Copys);
            Controls.Add(btn_Show_Book_Copy);
            Controls.Add(Grid_Show_Admins);
            Controls.Add(btn_Show_Admins);
            Controls.Add(Grid_Show_Borrow);
            Controls.Add(btn_Borrow_Status);
            Controls.Add(Grid_Show_Publishers);
            Controls.Add(btn_Show_Publishers);
            Controls.Add(Grid_Show_Show_Books);
            Controls.Add(btn_Show_Books);
            Controls.Add(Show_Users_Grid);
            Controls.Add(btnShowUsers);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)Show_Users_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Show_Books).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Publishers).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Borrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Admins).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid_Show_Copys).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Show_Users_Grid;
        private Button btnShowUsers;
        private DataGridView Grid_Show_Show_Books;
        private Button btn_Show_Books;
        private DataGridView Grid_Show_Publishers;
        private Button btn_Show_Publishers;
        private DataGridView Grid_Show_Borrow;
        private Button btn_Borrow_Status;
        private DataGridView Grid_Show_Admins;
        private Button btn_Show_Admins;
        private DataGridView Grid_Show_Copys;
        private Button btn_Show_Book_Copy;
    }
}
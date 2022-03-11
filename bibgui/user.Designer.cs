namespace bibgui
{
    partial class user
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
            this.components = new System.ComponentModel.Container();
            this.bibliotekdbDataSet = new bibgui.bibliotekdbDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new bibgui.bibliotekdbDataSetTableAdapters.itemsTableAdapter();
            this.AllBooksGridView = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.Label();
            this.ReservedBooks = new System.Windows.Forms.DataGridView();
            this.AreYouAdmin = new System.Windows.Forms.CheckBox();
            this.AdminAccess = new System.Windows.Forms.Button();
            this.AllbooksAtHome = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetBookButton = new System.Windows.Forms.Button();
            this.AllBooksDataGrid = new System.Windows.Forms.DataGridView();
            this.ReservBookButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.OutstandingsDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.OutstandingsButton = new System.Windows.Forms.Button();
            this.GetReservedBookHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllbooksAtHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutstandingsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekdbDataSet
            // 
            this.bibliotekdbDataSet.DataSetName = "bibliotekdbDataSet";
            this.bibliotekdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.bibliotekdbDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // AllBooksGridView
            // 
            this.AllBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksGridView.Location = new System.Drawing.Point(12, 23);
            this.AllBooksGridView.Name = "AllBooksGridView";
            this.AllBooksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllBooksGridView.Size = new System.Drawing.Size(1092, 121);
            this.AllBooksGridView.TabIndex = 0;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(1150, 397);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(35, 13);
            this.userID.TabIndex = 1;
            this.userID.Text = "label1";
            this.userID.Visible = false;
            // 
            // ReservedBooks
            // 
            this.ReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservedBooks.Location = new System.Drawing.Point(12, 161);
            this.ReservedBooks.Name = "ReservedBooks";
            this.ReservedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReservedBooks.Size = new System.Drawing.Size(506, 119);
            this.ReservedBooks.TabIndex = 2;
            // 
            // AreYouAdmin
            // 
            this.AreYouAdmin.AutoSize = true;
            this.AreYouAdmin.Location = new System.Drawing.Point(1083, 419);
            this.AreYouAdmin.Name = "AreYouAdmin";
            this.AreYouAdmin.Size = new System.Drawing.Size(102, 17);
            this.AreYouAdmin.TabIndex = 3;
            this.AreYouAdmin.Text = "Are You Admin?";
            this.AreYouAdmin.UseVisualStyleBackColor = true;
            this.AreYouAdmin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AdminAccess
            // 
            this.AdminAccess.Location = new System.Drawing.Point(1094, 442);
            this.AdminAccess.Name = "AdminAccess";
            this.AdminAccess.Size = new System.Drawing.Size(86, 23);
            this.AdminAccess.TabIndex = 4;
            this.AdminAccess.Text = "Admin Access";
            this.AdminAccess.UseVisualStyleBackColor = true;
            this.AdminAccess.Click += new System.EventHandler(this.AdminAccess_Click);
            // 
            // AllbooksAtHome
            // 
            this.AllbooksAtHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllbooksAtHome.Location = new System.Drawing.Point(524, 161);
            this.AllbooksAtHome.Name = "AllbooksAtHome";
            this.AllbooksAtHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllbooksAtHome.Size = new System.Drawing.Size(661, 233);
            this.AllbooksAtHome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Books at Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "All Books Available";
            // 
            // GetBookButton
            // 
            this.GetBookButton.Location = new System.Drawing.Point(972, 400);
            this.GetBookButton.Name = "GetBookButton";
            this.GetBookButton.Size = new System.Drawing.Size(75, 23);
            this.GetBookButton.TabIndex = 9;
            this.GetBookButton.Text = "Get Book";
            this.GetBookButton.UseVisualStyleBackColor = true;
            this.GetBookButton.Click += new System.EventHandler(this.GetBookButton_Click);
            // 
            // AllBooksDataGrid
            // 
            this.AllBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksDataGrid.Location = new System.Drawing.Point(12, 315);
            this.AllBooksDataGrid.Name = "AllBooksDataGrid";
            this.AllBooksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllBooksDataGrid.Size = new System.Drawing.Size(506, 150);
            this.AllBooksDataGrid.TabIndex = 10;
            // 
            // ReservBookButton
            // 
            this.ReservBookButton.Location = new System.Drawing.Point(215, 474);
            this.ReservBookButton.Name = "ReservBookButton";
            this.ReservBookButton.Size = new System.Drawing.Size(94, 23);
            this.ReservBookButton.TabIndex = 11;
            this.ReservBookButton.Text = "Reserv A Book";
            this.ReservBookButton.UseVisualStyleBackColor = true;
            this.ReservBookButton.Click += new System.EventHandler(this.ReservBookButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "All Books";
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(1110, 71);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnBookButton.TabIndex = 13;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // OutstandingsDataGrid
            // 
            this.OutstandingsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutstandingsDataGrid.Location = new System.Drawing.Point(524, 419);
            this.OutstandingsDataGrid.Name = "OutstandingsDataGrid";
            this.OutstandingsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutstandingsDataGrid.Size = new System.Drawing.Size(428, 78);
            this.OutstandingsDataGrid.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Outstandings";
            // 
            // OutstandingsButton
            // 
            this.OutstandingsButton.Location = new System.Drawing.Point(709, 507);
            this.OutstandingsButton.Name = "OutstandingsButton";
            this.OutstandingsButton.Size = new System.Drawing.Size(75, 23);
            this.OutstandingsButton.TabIndex = 16;
            this.OutstandingsButton.Text = "Pay up";
            this.OutstandingsButton.UseVisualStyleBackColor = true;
            this.OutstandingsButton.Click += new System.EventHandler(this.OutstandingsButton_Click);
            // 
            // GetReservedBookHome
            // 
            this.GetReservedBookHome.Location = new System.Drawing.Point(200, 286);
            this.GetReservedBookHome.Name = "GetReservedBookHome";
            this.GetReservedBookHome.Size = new System.Drawing.Size(128, 23);
            this.GetReservedBookHome.TabIndex = 17;
            this.GetReservedBookHome.Text = "Fecth Reserved Book";
            this.GetReservedBookHome.UseVisualStyleBackColor = true;
            this.GetReservedBookHome.Click += new System.EventHandler(this.GetReservedBookHome_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 542);
            this.Controls.Add(this.GetReservedBookHome);
            this.Controls.Add(this.OutstandingsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutstandingsDataGrid);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReservBookButton);
            this.Controls.Add(this.AllBooksDataGrid);
            this.Controls.Add(this.GetBookButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllbooksAtHome);
            this.Controls.Add(this.AdminAccess);
            this.Controls.Add(this.AreYouAdmin);
            this.Controls.Add(this.ReservedBooks);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.AllBooksGridView);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllbooksAtHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutstandingsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bibliotekdbDataSet bibliotekdbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private bibliotekdbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView AllBooksGridView;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.DataGridView ReservedBooks;
        private System.Windows.Forms.CheckBox AreYouAdmin;
        private System.Windows.Forms.Button AdminAccess;
        private System.Windows.Forms.DataGridView AllbooksAtHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetBookButton;
        private System.Windows.Forms.DataGridView AllBooksDataGrid;
        private System.Windows.Forms.Button ReservBookButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.DataGridView OutstandingsDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OutstandingsButton;
        private System.Windows.Forms.Button GetReservedBookHome;
    }
}
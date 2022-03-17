namespace bibgui
{
    partial class Admin
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
            this.AllBooksEver = new System.Windows.Forms.DataGridView();
            this.AllPeople = new System.Windows.Forms.DataGridView();
            this.mediatext = new System.Windows.Forms.TextBox();
            this.statustext = new System.Windows.Forms.TextBox();
            this.isnbtext = new System.Windows.Forms.TextBox();
            this.dk5text = new System.Windows.Forms.TextBox();
            this.titeltext = new System.Windows.Forms.TextBox();
            this.descriptiontext = new System.Windows.Forms.TextBox();
            this.authortext = new System.Windows.Forms.TextBox();
            this.createItemButton = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.FindUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.publishertext = new System.Windows.Forms.TextBox();
            this.lenttimetext = new System.Windows.Forms.TextBox();
            this.osvtext = new System.Windows.Forms.TextBox();
            this.cprtext = new System.Windows.Forms.TextBox();
            this.idtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.phonetext = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.Label();
            this.PersonHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.ILiedButton = new System.Windows.Forms.Button();
            this.userID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksEver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksEver
            // 
            this.AllBooksEver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksEver.Location = new System.Drawing.Point(13, 13);
            this.AllBooksEver.Name = "AllBooksEver";
            this.AllBooksEver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllBooksEver.Size = new System.Drawing.Size(775, 173);
            this.AllBooksEver.TabIndex = 0;
            this.AllBooksEver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllBooksEver_CellClick);
            this.AllBooksEver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllBooksEver_CellContentClick);
            // 
            // AllPeople
            // 
            this.AllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPeople.Location = new System.Drawing.Point(412, 206);
            this.AllPeople.Name = "AllPeople";
            this.AllPeople.Size = new System.Drawing.Size(376, 198);
            this.AllPeople.TabIndex = 1;
            this.AllPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPeople_CellClick);
            this.AllPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllPeople_CellContentClick);
            // 
            // mediatext
            // 
            this.mediatext.Location = new System.Drawing.Point(85, 206);
            this.mediatext.Name = "mediatext";
            this.mediatext.Size = new System.Drawing.Size(100, 20);
            this.mediatext.TabIndex = 2;
            // 
            // statustext
            // 
            this.statustext.Location = new System.Drawing.Point(85, 232);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(100, 20);
            this.statustext.TabIndex = 3;
            // 
            // isnbtext
            // 
            this.isnbtext.Location = new System.Drawing.Point(85, 258);
            this.isnbtext.Name = "isnbtext";
            this.isnbtext.Size = new System.Drawing.Size(100, 20);
            this.isnbtext.TabIndex = 4;
            // 
            // dk5text
            // 
            this.dk5text.Location = new System.Drawing.Point(85, 284);
            this.dk5text.Name = "dk5text";
            this.dk5text.Size = new System.Drawing.Size(100, 20);
            this.dk5text.TabIndex = 5;
            // 
            // titeltext
            // 
            this.titeltext.Location = new System.Drawing.Point(85, 310);
            this.titeltext.Name = "titeltext";
            this.titeltext.Size = new System.Drawing.Size(100, 20);
            this.titeltext.TabIndex = 6;
            // 
            // descriptiontext
            // 
            this.descriptiontext.Location = new System.Drawing.Point(85, 336);
            this.descriptiontext.Name = "descriptiontext";
            this.descriptiontext.Size = new System.Drawing.Size(100, 20);
            this.descriptiontext.TabIndex = 7;
            // 
            // authortext
            // 
            this.authortext.Location = new System.Drawing.Point(85, 362);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(100, 20);
            this.authortext.TabIndex = 8;
            // 
            // createItemButton
            // 
            this.createItemButton.Location = new System.Drawing.Point(15, 410);
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(75, 23);
            this.createItemButton.TabIndex = 9;
            this.createItemButton.Text = "Create";
            this.createItemButton.UseVisualStyleBackColor = true;
            this.createItemButton.Click += new System.EventHandler(this.createItemButton_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(175, 410);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteItemButton.TabIndex = 10;
            this.DeleteItemButton.Text = "Delete";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.Location = new System.Drawing.Point(96, 410);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateItemButton.TabIndex = 11;
            this.UpdateItemButton.Text = "Update";
            this.UpdateItemButton.UseVisualStyleBackColor = true;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // FindUserButton
            // 
            this.FindUserButton.Location = new System.Drawing.Point(296, 410);
            this.FindUserButton.Name = "FindUserButton";
            this.FindUserButton.Size = new System.Drawing.Size(75, 23);
            this.FindUserButton.TabIndex = 12;
            this.FindUserButton.Text = "Find User";
            this.FindUserButton.UseVisualStyleBackColor = true;
            this.FindUserButton.Click += new System.EventHandler(this.FindUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ISNB. nr.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DK5 nr.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Titel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Publisher";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lent Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "OSV";
            // 
            // publishertext
            // 
            this.publishertext.Location = new System.Drawing.Point(271, 206);
            this.publishertext.Name = "publishertext";
            this.publishertext.Size = new System.Drawing.Size(100, 20);
            this.publishertext.TabIndex = 23;
            // 
            // lenttimetext
            // 
            this.lenttimetext.Location = new System.Drawing.Point(271, 232);
            this.lenttimetext.Name = "lenttimetext";
            this.lenttimetext.Size = new System.Drawing.Size(100, 20);
            this.lenttimetext.TabIndex = 24;
            // 
            // osvtext
            // 
            this.osvtext.Location = new System.Drawing.Point(271, 258);
            this.osvtext.Name = "osvtext";
            this.osvtext.Size = new System.Drawing.Size(100, 20);
            this.osvtext.TabIndex = 25;
            // 
            // cprtext
            // 
            this.cprtext.Location = new System.Drawing.Point(271, 284);
            this.cprtext.Name = "cprtext";
            this.cprtext.Size = new System.Drawing.Size(100, 20);
            this.cprtext.TabIndex = 26;
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(271, 310);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(100, 20);
            this.idtext.TabIndex = 27;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(271, 336);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(100, 20);
            this.emailtext.TabIndex = 28;
            // 
            // phonetext
            // 
            this.phonetext.Location = new System.Drawing.Point(271, 362);
            this.phonetext.Name = "phonetext";
            this.phonetext.Size = new System.Drawing.Size(100, 20);
            this.phonetext.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "CPR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(191, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(191, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "TLF.nr.";
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Location = new System.Drawing.Point(12, 189);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(41, 13);
            this.itemID.TabIndex = 34;
            this.itemID.Text = "label15";
            this.itemID.Visible = false;
            // 
            // PersonHistoryDataGrid
            // 
            this.PersonHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonHistoryDataGrid.Location = new System.Drawing.Point(794, 13);
            this.PersonHistoryDataGrid.Name = "PersonHistoryDataGrid";
            this.PersonHistoryDataGrid.Size = new System.Drawing.Size(395, 391);
            this.PersonHistoryDataGrid.TabIndex = 35;
            // 
            // ILiedButton
            // 
            this.ILiedButton.Location = new System.Drawing.Point(1114, 415);
            this.ILiedButton.Name = "ILiedButton";
            this.ILiedButton.Size = new System.Drawing.Size(75, 23);
            this.ILiedButton.TabIndex = 36;
            this.ILiedButton.Text = "I Lied";
            this.ILiedButton.UseVisualStyleBackColor = true;
            this.ILiedButton.Click += new System.EventHandler(this.ILiedButton_Click);
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(60, 188);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(41, 13);
            this.userID.TabIndex = 37;
            this.userID.Text = "label15";
            this.userID.Visible = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.ILiedButton);
            this.Controls.Add(this.PersonHistoryDataGrid);
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phonetext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.cprtext);
            this.Controls.Add(this.osvtext);
            this.Controls.Add(this.lenttimetext);
            this.Controls.Add(this.publishertext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindUserButton);
            this.Controls.Add(this.UpdateItemButton);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.createItemButton);
            this.Controls.Add(this.authortext);
            this.Controls.Add(this.descriptiontext);
            this.Controls.Add(this.titeltext);
            this.Controls.Add(this.dk5text);
            this.Controls.Add(this.isnbtext);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.mediatext);
            this.Controls.Add(this.AllPeople);
            this.Controls.Add(this.AllBooksEver);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksEver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllBooksEver;
        private System.Windows.Forms.DataGridView AllPeople;
        private System.Windows.Forms.TextBox mediatext;
        private System.Windows.Forms.TextBox statustext;
        private System.Windows.Forms.TextBox isnbtext;
        private System.Windows.Forms.TextBox dk5text;
        private System.Windows.Forms.TextBox titeltext;
        private System.Windows.Forms.TextBox descriptiontext;
        private System.Windows.Forms.TextBox authortext;
        private System.Windows.Forms.Button createItemButton;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Button FindUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox publishertext;
        private System.Windows.Forms.TextBox lenttimetext;
        private System.Windows.Forms.TextBox osvtext;
        private System.Windows.Forms.TextBox cprtext;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox phonetext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label itemID;
        private System.Windows.Forms.DataGridView PersonHistoryDataGrid;
        private System.Windows.Forms.Button ILiedButton;
        private System.Windows.Forms.Label userID;
    }
}
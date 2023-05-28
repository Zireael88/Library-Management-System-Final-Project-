namespace Library_Management_System__Final_Project_
{
    partial class UC_BookLists
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Borrrow = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.loginDBDataSet = new Library_Management_System__Final_Project_.LoginDBDataSet();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Library_Management_System__Final_Project_.LoginDBDataSetTableAdapters.AccountTableAdapter();
            this.booksDatabaseDataSet = new Library_Management_System__Final_Project_.BooksDatabaseDataSet();
            this.hahahaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hahahaTableAdapter = new Library_Management_System__Final_Project_.BooksDatabaseDataSetTableAdapters.hahahaTableAdapter();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dg_Booklist = new System.Windows.Forms.DataGridView();
            this.booksDatabaseDataSet1 = new Library_Management_System__Final_Project_.BooksDatabaseDataSet1();
            this.bookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookListTableAdapter = new Library_Management_System__Final_Project_.BooksDatabaseDataSet1TableAdapters.BookListTableAdapter();
            this.booksDatabaseDataSet2 = new Library_Management_System__Final_Project_.BooksDatabaseDataSet2();
            this.bookListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookListTableAdapter1 = new Library_Management_System__Final_Project_.BooksDatabaseDataSet2TableAdapters.BookListTableAdapter();
            this.btn_BookListRefresh = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.lbl_BookListTimesBorrowed = new System.Windows.Forms.Label();
            this.lbl_BookListStatus = new System.Windows.Forms.Label();
            this.lbl_BookListPublishedDate = new System.Windows.Forms.Label();
            this.lbl_BookListAuthor = new System.Windows.Forms.Label();
            this.lbl_BookListISBN = new System.Windows.Forms.Label();
            this.lbl_BookListBookTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hahahaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Booklist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(656, 363);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 42);
            this.btn_Delete.TabIndex = 48;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Maroon;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(397, 363);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(119, 42);
            this.btn_Edit.TabIndex = 47;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Borrrow
            // 
            this.btn_Borrrow.BackColor = System.Drawing.Color.Maroon;
            this.btn_Borrrow.FlatAppearance.BorderSize = 0;
            this.btn_Borrrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrrow.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrrow.ForeColor = System.Drawing.Color.White;
            this.btn_Borrrow.Location = new System.Drawing.Point(121, 363);
            this.btn_Borrrow.Name = "btn_Borrrow";
            this.btn_Borrrow.Size = new System.Drawing.Size(119, 42);
            this.btn_Borrrow.TabIndex = 46;
            this.btn_Borrrow.Text = "BORROW";
            this.btn_Borrrow.UseVisualStyleBackColor = false;
            this.btn_Borrrow.Click += new System.EventHandler(this.btn_Borrrow_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Maroon;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(408, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 23);
            this.label23.TabIndex = 45;
            this.label23.Text = "BOOK LIST";
            // 
            // loginDBDataSet
            // 
            this.loginDBDataSet.DataSetName = "LoginDBDataSet";
            this.loginDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.loginDBDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // booksDatabaseDataSet
            // 
            this.booksDatabaseDataSet.DataSetName = "BooksDatabaseDataSet";
            this.booksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hahahaBindingSource
            // 
            this.hahahaBindingSource.DataMember = "hahaha";
            this.hahahaBindingSource.DataSource = this.booksDatabaseDataSet;
            // 
            // hahahaTableAdapter
            // 
            this.hahahaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Location = new System.Drawing.Point(15, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(882, 38);
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(15, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(882, 407);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // dg_Booklist
            // 
            this.dg_Booklist.AllowUserToAddRows = false;
            this.dg_Booklist.AllowUserToDeleteRows = false;
            this.dg_Booklist.AllowUserToResizeColumns = false;
            this.dg_Booklist.AllowUserToResizeRows = false;
            this.dg_Booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Booklist.Location = new System.Drawing.Point(15, 50);
            this.dg_Booklist.Name = "dg_Booklist";
            this.dg_Booklist.ReadOnly = true;
            this.dg_Booklist.RowHeadersWidth = 51;
            this.dg_Booklist.RowTemplate.Height = 24;
            this.dg_Booklist.Size = new System.Drawing.Size(882, 294);
            this.dg_Booklist.TabIndex = 49;
            // 
            // booksDatabaseDataSet1
            // 
            this.booksDatabaseDataSet1.DataSetName = "BooksDatabaseDataSet1";
            this.booksDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookListBindingSource
            // 
            this.bookListBindingSource.DataMember = "BookList";
            this.bookListBindingSource.DataSource = this.booksDatabaseDataSet1;
            // 
            // bookListTableAdapter
            // 
            this.bookListTableAdapter.ClearBeforeFill = true;
            // 
            // booksDatabaseDataSet2
            // 
            this.booksDatabaseDataSet2.DataSetName = "BooksDatabaseDataSet2";
            this.booksDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookListBindingSource1
            // 
            this.bookListBindingSource1.DataMember = "BookList";
            this.bookListBindingSource1.DataSource = this.booksDatabaseDataSet2;
            // 
            // bookListTableAdapter1
            // 
            this.bookListTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_BookListRefresh
            // 
            this.btn_BookListRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btn_BookListRefresh.FlatAppearance.BorderSize = 0;
            this.btn_BookListRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BookListRefresh.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookListRefresh.ForeColor = System.Drawing.Color.White;
            this.btn_BookListRefresh.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_refresh_32;
            this.btn_BookListRefresh.Location = new System.Drawing.Point(857, 13);
            this.btn_BookListRefresh.Name = "btn_BookListRefresh";
            this.btn_BookListRefresh.Size = new System.Drawing.Size(39, 33);
            this.btn_BookListRefresh.TabIndex = 50;
            this.btn_BookListRefresh.UseVisualStyleBackColor = false;
            this.btn_BookListRefresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(109, 487);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(694, 307);
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(109, 451);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(694, 38);
            this.pictureBox9.TabIndex = 52;
            this.pictureBox9.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(430, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 28);
            this.label15.TabIndex = 53;
            this.label15.Text = "VIEW";
            // 
            // BookCover
            // 
            this.BookCover.BackColor = System.Drawing.Color.LightGray;
            this.BookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover.Location = new System.Drawing.Point(140, 513);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(160, 256);
            this.BookCover.TabIndex = 54;
            this.BookCover.TabStop = false;
            // 
            // lbl_BookListTimesBorrowed
            // 
            this.lbl_BookListTimesBorrowed.AutoSize = true;
            this.lbl_BookListTimesBorrowed.BackColor = System.Drawing.Color.White;
            this.lbl_BookListTimesBorrowed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListTimesBorrowed.Location = new System.Drawing.Point(578, 712);
            this.lbl_BookListTimesBorrowed.Name = "lbl_BookListTimesBorrowed";
            this.lbl_BookListTimesBorrowed.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListTimesBorrowed.TabIndex = 66;
            this.lbl_BookListTimesBorrowed.Text = "Hunger Games";
            // 
            // lbl_BookListStatus
            // 
            this.lbl_BookListStatus.AutoSize = true;
            this.lbl_BookListStatus.BackColor = System.Drawing.Color.White;
            this.lbl_BookListStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListStatus.Location = new System.Drawing.Point(578, 635);
            this.lbl_BookListStatus.Name = "lbl_BookListStatus";
            this.lbl_BookListStatus.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListStatus.TabIndex = 65;
            this.lbl_BookListStatus.Text = "Hunger Games";
            // 
            // lbl_BookListPublishedDate
            // 
            this.lbl_BookListPublishedDate.AutoSize = true;
            this.lbl_BookListPublishedDate.BackColor = System.Drawing.Color.White;
            this.lbl_BookListPublishedDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListPublishedDate.Location = new System.Drawing.Point(578, 559);
            this.lbl_BookListPublishedDate.Name = "lbl_BookListPublishedDate";
            this.lbl_BookListPublishedDate.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListPublishedDate.TabIndex = 64;
            this.lbl_BookListPublishedDate.Text = "Hunger Games";
            // 
            // lbl_BookListAuthor
            // 
            this.lbl_BookListAuthor.AutoSize = true;
            this.lbl_BookListAuthor.BackColor = System.Drawing.Color.White;
            this.lbl_BookListAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListAuthor.Location = new System.Drawing.Point(353, 712);
            this.lbl_BookListAuthor.Name = "lbl_BookListAuthor";
            this.lbl_BookListAuthor.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListAuthor.TabIndex = 63;
            this.lbl_BookListAuthor.Text = "Hunger Games";
            // 
            // lbl_BookListISBN
            // 
            this.lbl_BookListISBN.AutoSize = true;
            this.lbl_BookListISBN.BackColor = System.Drawing.Color.White;
            this.lbl_BookListISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListISBN.Location = new System.Drawing.Point(353, 635);
            this.lbl_BookListISBN.Name = "lbl_BookListISBN";
            this.lbl_BookListISBN.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListISBN.TabIndex = 62;
            this.lbl_BookListISBN.Text = "Hunger Games";
            // 
            // lbl_BookListBookTitle
            // 
            this.lbl_BookListBookTitle.AutoSize = true;
            this.lbl_BookListBookTitle.BackColor = System.Drawing.Color.White;
            this.lbl_BookListBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookListBookTitle.Location = new System.Drawing.Point(353, 559);
            this.lbl_BookListBookTitle.Name = "lbl_BookListBookTitle";
            this.lbl_BookListBookTitle.Size = new System.Drawing.Size(124, 23);
            this.lbl_BookListBookTitle.TabIndex = 61;
            this.lbl_BookListBookTitle.Text = "Hunger Games";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(578, 691);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 23);
            this.label16.TabIndex = 60;
            this.label16.Text = "Times Borrowed: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(578, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 59;
            this.label10.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(578, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "Published Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(353, 691);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Author: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(353, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "ISBN: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(353, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Book Title: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(323, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 256);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // UC_BookLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_BookListTimesBorrowed);
            this.Controls.Add(this.lbl_BookListStatus);
            this.Controls.Add(this.lbl_BookListPublishedDate);
            this.Controls.Add(this.lbl_BookListAuthor);
            this.Controls.Add(this.lbl_BookListISBN);
            this.Controls.Add(this.lbl_BookListBookTitle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookCover);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btn_BookListRefresh);
            this.Controls.Add(this.dg_Booklist);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Borrrow);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Name = "UC_BookLists";
            this.Size = new System.Drawing.Size(913, 835);
            this.Load += new System.EventHandler(this.UC_BookLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hahahaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Booklist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Borrrow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private LoginDBDataSet loginDBDataSet;
        private LoginDBDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource hahahaBindingSource;
        private BooksDatabaseDataSet booksDatabaseDataSet;
        private BooksDatabaseDataSetTableAdapters.hahahaTableAdapter hahahaTableAdapter;
        private System.Windows.Forms.DataGridView dg_Booklist;
        private System.Windows.Forms.BindingSource bookListBindingSource;
        private BooksDatabaseDataSet1 booksDatabaseDataSet1;
        private BooksDatabaseDataSet1TableAdapters.BookListTableAdapter bookListTableAdapter;
        private System.Windows.Forms.BindingSource bookListBindingSource1;
        private BooksDatabaseDataSet2 booksDatabaseDataSet2;
        private BooksDatabaseDataSet2TableAdapters.BookListTableAdapter bookListTableAdapter1;
        private System.Windows.Forms.Button btn_BookListRefresh;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Label lbl_BookListTimesBorrowed;
        private System.Windows.Forms.Label lbl_BookListStatus;
        private System.Windows.Forms.Label lbl_BookListPublishedDate;
        private System.Windows.Forms.Label lbl_BookListAuthor;
        private System.Windows.Forms.Label lbl_BookListISBN;
        private System.Windows.Forms.Label lbl_BookListBookTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

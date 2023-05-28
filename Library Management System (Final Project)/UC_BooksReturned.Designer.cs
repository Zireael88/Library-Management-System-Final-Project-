namespace Library_Management_System__Final_Project_
{
    partial class UC_BooksReturned
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
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.dg_BooksReturned = new System.Windows.Forms.DataGridView();
            this.booksDatabaseDataSet3 = new Library_Management_System__Final_Project_.BooksDatabaseDataSet3();
            this.bookListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookListTableAdapter = new Library_Management_System__Final_Project_.BooksDatabaseDataSet3TableAdapters.BookListTableAdapter();
            this.lbl_BooksReturnedTimesBorrowed = new System.Windows.Forms.Label();
            this.lbl_BooksReturnedStatus = new System.Windows.Forms.Label();
            this.lbl_BooksReturnedPublishedDate = new System.Windows.Forms.Label();
            this.lbl_BooksReturnedAuthor = new System.Windows.Forms.Label();
            this.lbl_BooksReturnedISBN = new System.Windows.Forms.Label();
            this.lbl_BooksReturnedBookTitle = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_BooksReturnedRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BooksReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Maroon;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(379, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(161, 23);
            this.label23.TabIndex = 45;
            this.label23.Text = "BOOKS RETURNED";
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
            this.pictureBox8.Location = new System.Drawing.Point(15, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(882, 407);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // dg_BooksReturned
            // 
            this.dg_BooksReturned.AllowUserToAddRows = false;
            this.dg_BooksReturned.AllowUserToDeleteRows = false;
            this.dg_BooksReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_BooksReturned.Location = new System.Drawing.Point(15, 50);
            this.dg_BooksReturned.Name = "dg_BooksReturned";
            this.dg_BooksReturned.ReadOnly = true;
            this.dg_BooksReturned.RowHeadersWidth = 51;
            this.dg_BooksReturned.RowTemplate.Height = 24;
            this.dg_BooksReturned.Size = new System.Drawing.Size(882, 369);
            this.dg_BooksReturned.TabIndex = 51;
            // 
            // booksDatabaseDataSet3
            // 
            this.booksDatabaseDataSet3.DataSetName = "BooksDatabaseDataSet3";
            this.booksDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookListBindingSource
            // 
            this.bookListBindingSource.DataMember = "BookList";
            this.bookListBindingSource.DataSource = this.booksDatabaseDataSet3;
            // 
            // bookListTableAdapter
            // 
            this.bookListTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_BooksReturnedTimesBorrowed
            // 
            this.lbl_BooksReturnedTimesBorrowed.AutoSize = true;
            this.lbl_BooksReturnedTimesBorrowed.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedTimesBorrowed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedTimesBorrowed.Location = new System.Drawing.Point(578, 712);
            this.lbl_BooksReturnedTimesBorrowed.Name = "lbl_BooksReturnedTimesBorrowed";
            this.lbl_BooksReturnedTimesBorrowed.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedTimesBorrowed.TabIndex = 83;
            this.lbl_BooksReturnedTimesBorrowed.Text = "Hunger Games";
            // 
            // lbl_BooksReturnedStatus
            // 
            this.lbl_BooksReturnedStatus.AutoSize = true;
            this.lbl_BooksReturnedStatus.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedStatus.Location = new System.Drawing.Point(578, 635);
            this.lbl_BooksReturnedStatus.Name = "lbl_BooksReturnedStatus";
            this.lbl_BooksReturnedStatus.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedStatus.TabIndex = 82;
            this.lbl_BooksReturnedStatus.Text = "Hunger Games";
            // 
            // lbl_BooksReturnedPublishedDate
            // 
            this.lbl_BooksReturnedPublishedDate.AutoSize = true;
            this.lbl_BooksReturnedPublishedDate.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedPublishedDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedPublishedDate.Location = new System.Drawing.Point(578, 559);
            this.lbl_BooksReturnedPublishedDate.Name = "lbl_BooksReturnedPublishedDate";
            this.lbl_BooksReturnedPublishedDate.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedPublishedDate.TabIndex = 81;
            this.lbl_BooksReturnedPublishedDate.Text = "Hunger Games";
            // 
            // lbl_BooksReturnedAuthor
            // 
            this.lbl_BooksReturnedAuthor.AutoSize = true;
            this.lbl_BooksReturnedAuthor.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedAuthor.Location = new System.Drawing.Point(353, 712);
            this.lbl_BooksReturnedAuthor.Name = "lbl_BooksReturnedAuthor";
            this.lbl_BooksReturnedAuthor.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedAuthor.TabIndex = 80;
            this.lbl_BooksReturnedAuthor.Text = "Hunger Games";
            // 
            // lbl_BooksReturnedISBN
            // 
            this.lbl_BooksReturnedISBN.AutoSize = true;
            this.lbl_BooksReturnedISBN.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedISBN.Location = new System.Drawing.Point(353, 635);
            this.lbl_BooksReturnedISBN.Name = "lbl_BooksReturnedISBN";
            this.lbl_BooksReturnedISBN.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedISBN.TabIndex = 79;
            this.lbl_BooksReturnedISBN.Text = "Hunger Games";
            // 
            // lbl_BooksReturnedBookTitle
            // 
            this.lbl_BooksReturnedBookTitle.AutoSize = true;
            this.lbl_BooksReturnedBookTitle.BackColor = System.Drawing.Color.White;
            this.lbl_BooksReturnedBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BooksReturnedBookTitle.Location = new System.Drawing.Point(353, 559);
            this.lbl_BooksReturnedBookTitle.Name = "lbl_BooksReturnedBookTitle";
            this.lbl_BooksReturnedBookTitle.Size = new System.Drawing.Size(124, 23);
            this.lbl_BooksReturnedBookTitle.TabIndex = 78;
            this.lbl_BooksReturnedBookTitle.Text = "Hunger Games";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(579, 691);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 23);
            this.label16.TabIndex = 77;
            this.label16.Text = "Times Borrowed: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(579, 612);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(579, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 75;
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
            this.label7.TabIndex = 74;
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
            this.label6.TabIndex = 73;
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
            this.label5.TabIndex = 72;
            this.label5.Text = "Book Title: ";
            // 
            // BookCover
            // 
            this.BookCover.BackColor = System.Drawing.Color.LightGray;
            this.BookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookCover.Location = new System.Drawing.Point(140, 513);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(160, 256);
            this.BookCover.TabIndex = 71;
            this.BookCover.TabStop = false;
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
            this.label15.TabIndex = 70;
            this.label15.Text = "VIEW";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(109, 451);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(694, 38);
            this.pictureBox9.TabIndex = 69;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(323, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 256);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(109, 487);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(694, 307);
            this.pictureBox5.TabIndex = 68;
            this.pictureBox5.TabStop = false;
            // 
            // btn_BooksReturnedRefresh
            // 
            this.btn_BooksReturnedRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btn_BooksReturnedRefresh.FlatAppearance.BorderSize = 0;
            this.btn_BooksReturnedRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BooksReturnedRefresh.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BooksReturnedRefresh.ForeColor = System.Drawing.Color.White;
            this.btn_BooksReturnedRefresh.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_refresh_32;
            this.btn_BooksReturnedRefresh.Location = new System.Drawing.Point(857, 13);
            this.btn_BooksReturnedRefresh.Name = "btn_BooksReturnedRefresh";
            this.btn_BooksReturnedRefresh.Size = new System.Drawing.Size(39, 33);
            this.btn_BooksReturnedRefresh.TabIndex = 85;
            this.btn_BooksReturnedRefresh.UseVisualStyleBackColor = false;
            // 
            // UC_BooksReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_BooksReturnedRefresh);
            this.Controls.Add(this.lbl_BooksReturnedTimesBorrowed);
            this.Controls.Add(this.lbl_BooksReturnedStatus);
            this.Controls.Add(this.lbl_BooksReturnedPublishedDate);
            this.Controls.Add(this.lbl_BooksReturnedAuthor);
            this.Controls.Add(this.lbl_BooksReturnedISBN);
            this.Controls.Add(this.lbl_BooksReturnedBookTitle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookCover);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dg_BooksReturned);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Name = "UC_BooksReturned";
            this.Size = new System.Drawing.Size(913, 835);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_BooksReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView dg_BooksReturned;
        private BooksDatabaseDataSet3 booksDatabaseDataSet3;
        private System.Windows.Forms.BindingSource bookListBindingSource;
        private BooksDatabaseDataSet3TableAdapters.BookListTableAdapter bookListTableAdapter;
        private System.Windows.Forms.Label lbl_BooksReturnedTimesBorrowed;
        private System.Windows.Forms.Label lbl_BooksReturnedStatus;
        private System.Windows.Forms.Label lbl_BooksReturnedPublishedDate;
        private System.Windows.Forms.Label lbl_BooksReturnedAuthor;
        private System.Windows.Forms.Label lbl_BooksReturnedISBN;
        private System.Windows.Forms.Label lbl_BooksReturnedBookTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_BooksReturnedRefresh;
    }
}

namespace Library_Management_System__Final_Project_
{
    partial class Form_Homepage
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
            this.Btn_BookList = new System.Windows.Forms.Button();
            this.Btn_BooksBorrowed = new System.Windows.Forms.Button();
            this.Btn_BooksReturned = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_BooksLost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_TimesBorrowed = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_PublishedDate = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookCover = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_InsertBookTitle = new System.Windows.Forms.TextBox();
            this.txt_InsertAuthor = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_InsertISBN = new System.Windows.Forms.TextBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_InsertBookTitle = new System.Windows.Forms.Label();
            this.lbl_InsertAuthor = new System.Windows.Forms.Label();
            this.lbl_InsertPublishedDate = new System.Windows.Forms.Label();
            this.lbl_InsertISBN = new System.Windows.Forms.Label();
            this.lbl_InsertPhoto = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uC_BooksReturned1 = new Library_Management_System__Final_Project_.UC_BooksReturned();
            this.uC_BooksLost1 = new Library_Management_System__Final_Project_.UC_BooksLost();
            this.uC_BooksBorrowed1 = new Library_Management_System__Final_Project_.UC_BooksBorrowed();
            this.uC_BookLists1 = new Library_Management_System__Final_Project_.UC_BookLists();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_BookList
            // 
            this.Btn_BookList.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_BookList.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BookList.FlatAppearance.BorderSize = 0;
            this.Btn_BookList.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BookList.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BookList.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BookList.Location = new System.Drawing.Point(22, 181);
            this.Btn_BookList.Name = "Btn_BookList";
            this.Btn_BookList.Size = new System.Drawing.Size(172, 32);
            this.Btn_BookList.TabIndex = 1;
            this.Btn_BookList.Text = "Book List";
            this.Btn_BookList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BookList.UseVisualStyleBackColor = false;
            this.Btn_BookList.Click += new System.EventHandler(this.Btn_BookList_Click);
            // 
            // Btn_BooksBorrowed
            // 
            this.Btn_BooksBorrowed.BackColor = System.Drawing.Color.White;
            this.Btn_BooksBorrowed.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BooksBorrowed.FlatAppearance.BorderSize = 0;
            this.Btn_BooksBorrowed.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BooksBorrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BooksBorrowed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BooksBorrowed.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BooksBorrowed.Location = new System.Drawing.Point(22, 221);
            this.Btn_BooksBorrowed.Name = "Btn_BooksBorrowed";
            this.Btn_BooksBorrowed.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksBorrowed.TabIndex = 2;
            this.Btn_BooksBorrowed.Text = "Books Borrowed";
            this.Btn_BooksBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksBorrowed.UseVisualStyleBackColor = false;
            this.Btn_BooksBorrowed.Click += new System.EventHandler(this.Btn_BooksBorrowed_Click);
            // 
            // Btn_BooksReturned
            // 
            this.Btn_BooksReturned.BackColor = System.Drawing.Color.White;
            this.Btn_BooksReturned.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BooksReturned.FlatAppearance.BorderSize = 0;
            this.Btn_BooksReturned.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BooksReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BooksReturned.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BooksReturned.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BooksReturned.Location = new System.Drawing.Point(22, 261);
            this.Btn_BooksReturned.Name = "Btn_BooksReturned";
            this.Btn_BooksReturned.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksReturned.TabIndex = 3;
            this.Btn_BooksReturned.Text = "Books Returned";
            this.Btn_BooksReturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksReturned.UseVisualStyleBackColor = false;
            this.Btn_BooksReturned.Click += new System.EventHandler(this.Btn_BooksReturned_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // Btn_BooksLost
            // 
            this.Btn_BooksLost.BackColor = System.Drawing.Color.White;
            this.Btn_BooksLost.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BooksLost.FlatAppearance.BorderSize = 0;
            this.Btn_BooksLost.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BooksLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BooksLost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BooksLost.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BooksLost.Location = new System.Drawing.Point(22, 301);
            this.Btn_BooksLost.Name = "Btn_BooksLost";
            this.Btn_BooksLost.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksLost.TabIndex = 5;
            this.Btn_BooksLost.Text = "Books Lost";
            this.Btn_BooksLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksLost.UseVisualStyleBackColor = false;
            this.Btn_BooksLost.Click += new System.EventHandler(this.Btn_BooksLost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(248, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome Back,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(413, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_TimesBorrowed);
            this.panel2.Controls.Add(this.lbl_Status);
            this.panel2.Controls.Add(this.lbl_PublishedDate);
            this.panel2.Controls.Add(this.lbl_Author);
            this.panel2.Controls.Add(this.lbl_ISBN);
            this.panel2.Controls.Add(this.lbl_BookTitle);
            this.panel2.Controls.Add(this.MinBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BookCover);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 900);
            this.panel2.TabIndex = 13;
            // 
            // lbl_TimesBorrowed
            // 
            this.lbl_TimesBorrowed.AutoSize = true;
            this.lbl_TimesBorrowed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimesBorrowed.Location = new System.Drawing.Point(22, 760);
            this.lbl_TimesBorrowed.Name = "lbl_TimesBorrowed";
            this.lbl_TimesBorrowed.Size = new System.Drawing.Size(141, 28);
            this.lbl_TimesBorrowed.TabIndex = 42;
            this.lbl_TimesBorrowed.Text = "Hunger Games";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(22, 700);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(141, 28);
            this.lbl_Status.TabIndex = 41;
            this.lbl_Status.Text = "Hunger Games";
            // 
            // lbl_PublishedDate
            // 
            this.lbl_PublishedDate.AutoSize = true;
            this.lbl_PublishedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PublishedDate.Location = new System.Drawing.Point(22, 640);
            this.lbl_PublishedDate.Name = "lbl_PublishedDate";
            this.lbl_PublishedDate.Size = new System.Drawing.Size(141, 28);
            this.lbl_PublishedDate.TabIndex = 40;
            this.lbl_PublishedDate.Text = "Hunger Games";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(21, 580);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(141, 28);
            this.lbl_Author.TabIndex = 39;
            this.lbl_Author.Text = "Hunger Games";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISBN.Location = new System.Drawing.Point(21, 520);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(141, 28);
            this.lbl_ISBN.TabIndex = 38;
            this.lbl_ISBN.Text = "Hunger Games";
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(21, 460);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(141, 28);
            this.lbl_BookTitle.TabIndex = 37;
            this.lbl_BookTitle.Text = "Hunger Games";
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Maroon;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(207, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(39, 33);
            this.MinBtn.TabIndex = 36;
            this.MinBtn.Text = "_";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(245, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 33);
            this.ExitBtn.TabIndex = 35;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(23, 739);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 23);
            this.label16.TabIndex = 26;
            this.label16.Text = "Times Borrowed: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(23, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(23, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Published Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(23, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Author: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(23, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "ISBN: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(22, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Book Title: ";
            // 
            // BookCover
            // 
            this.BookCover.BackColor = System.Drawing.Color.Gainsboro;
            this.BookCover.Location = new System.Drawing.Point(61, 141);
            this.BookCover.Name = "BookCover";
            this.BookCover.Size = new System.Drawing.Size(160, 256);
            this.BookCover.TabIndex = 14;
            this.BookCover.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(97, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "View";
            // 
            // txt_InsertBookTitle
            // 
            this.txt_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertBookTitle.Location = new System.Drawing.Point(382, 654);
            this.txt_InsertBookTitle.Name = "txt_InsertBookTitle";
            this.txt_InsertBookTitle.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertBookTitle.TabIndex = 15;
            // 
            // txt_InsertAuthor
            // 
            this.txt_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertAuthor.Location = new System.Drawing.Point(382, 732);
            this.txt_InsertAuthor.Name = "txt_InsertAuthor";
            this.txt_InsertAuthor.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertAuthor.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 808);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(539, 808);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 22);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(476, 808);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 22);
            this.textBox5.TabIndex = 19;
            // 
            // txt_InsertISBN
            // 
            this.txt_InsertISBN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertISBN.Location = new System.Drawing.Point(746, 654);
            this.txt_InsertISBN.Name = "txt_InsertISBN";
            this.txt_InsertISBN.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertISBN.TabIndex = 20;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UploadImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadImage.Location = new System.Drawing.Point(746, 732);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(110, 27);
            this.btn_UploadImage.TabIndex = 0;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Maroon;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(746, 794);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(110, 47);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = false;
            // 
            // lbl_InsertBookTitle
            // 
            this.lbl_InsertBookTitle.AutoSize = true;
            this.lbl_InsertBookTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertBookTitle.Location = new System.Drawing.Point(378, 628);
            this.lbl_InsertBookTitle.Name = "lbl_InsertBookTitle";
            this.lbl_InsertBookTitle.Size = new System.Drawing.Size(111, 23);
            this.lbl_InsertBookTitle.TabIndex = 26;
            this.lbl_InsertBookTitle.Text = "BOOK TITLE:";
            // 
            // lbl_InsertAuthor
            // 
            this.lbl_InsertAuthor.AutoSize = true;
            this.lbl_InsertAuthor.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertAuthor.Location = new System.Drawing.Point(378, 706);
            this.lbl_InsertAuthor.Name = "lbl_InsertAuthor";
            this.lbl_InsertAuthor.Size = new System.Drawing.Size(86, 23);
            this.lbl_InsertAuthor.TabIndex = 27;
            this.lbl_InsertAuthor.Text = "AUTHOR:";
            // 
            // lbl_InsertPublishedDate
            // 
            this.lbl_InsertPublishedDate.AutoSize = true;
            this.lbl_InsertPublishedDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertPublishedDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertPublishedDate.Location = new System.Drawing.Point(378, 782);
            this.lbl_InsertPublishedDate.Name = "lbl_InsertPublishedDate";
            this.lbl_InsertPublishedDate.Size = new System.Drawing.Size(155, 23);
            this.lbl_InsertPublishedDate.TabIndex = 28;
            this.lbl_InsertPublishedDate.Text = "PUBLISHED DATE:";
            // 
            // lbl_InsertISBN
            // 
            this.lbl_InsertISBN.AutoSize = true;
            this.lbl_InsertISBN.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertISBN.Location = new System.Drawing.Point(742, 628);
            this.lbl_InsertISBN.Name = "lbl_InsertISBN";
            this.lbl_InsertISBN.Size = new System.Drawing.Size(54, 23);
            this.lbl_InsertISBN.TabIndex = 30;
            this.lbl_InsertISBN.Text = "ISBN:";
            // 
            // lbl_InsertPhoto
            // 
            this.lbl_InsertPhoto.AutoSize = true;
            this.lbl_InsertPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertPhoto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertPhoto.Location = new System.Drawing.Point(742, 707);
            this.lbl_InsertPhoto.Name = "lbl_InsertPhoto";
            this.lbl_InsertPhoto.Size = new System.Drawing.Size(72, 23);
            this.lbl_InsertPhoto.TabIndex = 31;
            this.lbl_InsertPhoto.Text = "PHOTO:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 900);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System__Final_Project_.Properties.Resources.logo_no_background;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(607, 561);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 35);
            this.label15.TabIndex = 34;
            this.label15.Text = "Insert Book";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox9.Location = new System.Drawing.Point(330, 558);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(694, 38);
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox5.Location = new System.Drawing.Point(330, 587);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(694, 274);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Location = new System.Drawing.Point(1146, -9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 920);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(217, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 920);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // uC_BooksReturned1
            // 
            this.uC_BooksReturned1.Location = new System.Drawing.Point(227, 81);
            this.uC_BooksReturned1.Name = "uC_BooksReturned1";
            this.uC_BooksReturned1.Size = new System.Drawing.Size(913, 441);
            this.uC_BooksReturned1.TabIndex = 38;
            // 
            // uC_BooksLost1
            // 
            this.uC_BooksLost1.Location = new System.Drawing.Point(227, 81);
            this.uC_BooksLost1.Name = "uC_BooksLost1";
            this.uC_BooksLost1.Size = new System.Drawing.Size(913, 441);
            this.uC_BooksLost1.TabIndex = 37;
            // 
            // uC_BooksBorrowed1
            // 
            this.uC_BooksBorrowed1.Location = new System.Drawing.Point(227, 81);
            this.uC_BooksBorrowed1.Name = "uC_BooksBorrowed1";
            this.uC_BooksBorrowed1.Size = new System.Drawing.Size(913, 441);
            this.uC_BooksBorrowed1.TabIndex = 36;
            // 
            // uC_BookLists1
            // 
            this.uC_BookLists1.Location = new System.Drawing.Point(227, 81);
            this.uC_BookLists1.Name = "uC_BookLists1";
            this.uC_BookLists1.Size = new System.Drawing.Size(913, 441);
            this.uC_BookLists1.TabIndex = 35;
            // 
            // Form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.uC_BooksReturned1);
            this.Controls.Add(this.uC_BooksLost1);
            this.Controls.Add(this.uC_BooksBorrowed1);
            this.Controls.Add(this.uC_BookLists1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lbl_InsertPhoto);
            this.Controls.Add(this.lbl_InsertISBN);
            this.Controls.Add(this.lbl_InsertPublishedDate);
            this.Controls.Add(this.lbl_InsertAuthor);
            this.Controls.Add(this.lbl_InsertBookTitle);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.txt_InsertISBN);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_InsertAuthor);
            this.Controls.Add(this.txt_InsertBookTitle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_BooksLost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_BooksReturned);
            this.Controls.Add(this.Btn_BooksBorrowed);
            this.Controls.Add(this.Btn_BookList);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form_Homepage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookCover)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_BookList;
        private System.Windows.Forms.Button Btn_BooksBorrowed;
        private System.Windows.Forms.Button Btn_BooksReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_BooksLost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox BookCover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txt_InsertBookTitle;
        private System.Windows.Forms.TextBox txt_InsertAuthor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_InsertISBN;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Button btn_Insert;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_InsertBookTitle;
        private System.Windows.Forms.Label lbl_InsertAuthor;
        private System.Windows.Forms.Label lbl_InsertPublishedDate;
        private System.Windows.Forms.Label lbl_InsertISBN;
        private System.Windows.Forms.Label lbl_InsertPhoto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Label lbl_TimesBorrowed;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_PublishedDate;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label lbl_BookTitle;
        private UC_BookLists uC_BookLists1;
        private UC_BooksBorrowed uC_BooksBorrowed1;
        private UC_BooksLost uC_BooksLost1;
        private UC_BooksReturned uC_BooksReturned1;
    }
}
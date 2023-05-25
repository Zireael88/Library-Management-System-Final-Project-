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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_TimesBorrowed = new System.Windows.Forms.TextBox();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_BookTitle = new System.Windows.Forms.TextBox();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.label2.Location = new System.Drawing.Point(248, 14);
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
            this.label3.Location = new System.Drawing.Point(420, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin!";
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(217, 67);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(913, 441);
            this.mainpanel.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ISBN);
            this.panel2.Controls.Add(this.txt_TimesBorrowed);
            this.panel2.Controls.Add(this.txt_Publisher);
            this.panel2.Controls.Add(this.txt_Author);
            this.panel2.Controls.Add(this.txt_Status);
            this.panel2.Controls.Add(this.txt_BookTitle);
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
            this.panel2.Location = new System.Drawing.Point(1136, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 1000);
            this.panel2.TabIndex = 13;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ISBN.Location = new System.Drawing.Point(26, 525);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.ReadOnly = true;
            this.txt_ISBN.Size = new System.Drawing.Size(239, 23);
            this.txt_ISBN.TabIndex = 42;
            // 
            // txt_TimesBorrowed
            // 
            this.txt_TimesBorrowed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimesBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TimesBorrowed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimesBorrowed.Location = new System.Drawing.Point(26, 765);
            this.txt_TimesBorrowed.Name = "txt_TimesBorrowed";
            this.txt_TimesBorrowed.ReadOnly = true;
            this.txt_TimesBorrowed.Size = new System.Drawing.Size(239, 23);
            this.txt_TimesBorrowed.TabIndex = 41;
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Publisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Publisher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Publisher.Location = new System.Drawing.Point(27, 645);
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.ReadOnly = true;
            this.txt_Publisher.Size = new System.Drawing.Size(239, 23);
            this.txt_Publisher.TabIndex = 40;
            // 
            // txt_Author
            // 
            this.txt_Author.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Author.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Author.Location = new System.Drawing.Point(27, 587);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.ReadOnly = true;
            this.txt_Author.Size = new System.Drawing.Size(239, 23);
            this.txt_Author.TabIndex = 39;
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Location = new System.Drawing.Point(27, 705);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(239, 23);
            this.txt_Status.TabIndex = 38;
            // 
            // txt_BookTitle
            // 
            this.txt_BookTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookTitle.Location = new System.Drawing.Point(27, 465);
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.ReadOnly = true;
            this.txt_BookTitle.Size = new System.Drawing.Size(239, 27);
            this.txt_BookTitle.TabIndex = 37;
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Maroon;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(227, 0);
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
            this.ExitBtn.Location = new System.Drawing.Point(265, 0);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(378, 628);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 23);
            this.label18.TabIndex = 26;
            this.label18.Text = "BOOK TITLE:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Gainsboro;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(378, 706);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 23);
            this.label19.TabIndex = 27;
            this.label19.Text = "AUTHOR:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Gainsboro;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(378, 782);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(155, 23);
            this.label20.TabIndex = 28;
            this.label20.Text = "PUBLISHED DATE:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(742, 628);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 23);
            this.label22.TabIndex = 30;
            this.label22.Text = "ISBN:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Gainsboro;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(742, 707);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 23);
            this.label21.TabIndex = 31;
            this.label21.Text = "PHOTO:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1000);
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
            this.pictureBox3.Location = new System.Drawing.Point(1127, -9);
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
            // Form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 1000);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
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
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
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
        private System.Windows.Forms.Panel mainpanel;
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_TimesBorrowed;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_BookTitle;
    }
}
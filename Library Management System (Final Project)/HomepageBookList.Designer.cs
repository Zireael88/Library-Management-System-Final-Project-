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
            this.lbl_menu = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_BooksLost = new System.Windows.Forms.Button();
            this.Btn_BooksReturned = new System.Windows.Forms.Button();
            this.Btn_BooksBorrowed = new System.Windows.Forms.Button();
            this.Btn_BookList = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.lbl_InsertPhoto = new System.Windows.Forms.Label();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_InsertISBN = new System.Windows.Forms.Label();
            this.txt_InsertISBN = new System.Windows.Forms.TextBox();
            this.lbl_InsertPublishedDate = new System.Windows.Forms.Label();
            this.lbl_InsertAuthor = new System.Windows.Forms.Label();
            this.dtp_InsertPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.txt_InsertBookTitle = new System.Windows.Forms.TextBox();
            this.lbl_InsertBookTitle = new System.Windows.Forms.Label();
            this.pb_PreviewImage = new System.Windows.Forms.PictureBox();
            this.txt_InsertAuthor = new System.Windows.Forms.TextBox();
            this.uC_BooksReturned1 = new Library_Management_System__Final_Project_.UC_BooksReturned();
            this.uC_BooksLost1 = new Library_Management_System__Final_Project_.UC_BooksLost();
            this.uC_BooksBorrowed1 = new Library_Management_System__Final_Project_.UC_BooksBorrowed();
            this.uC_BookLists1 = new Library_Management_System__Final_Project_.UC_BookLists();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_menu.Location = new System.Drawing.Point(22, 132);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(73, 31);
            this.lbl_menu.TabIndex = 4;
            this.lbl_menu.Text = "Menu";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Welcome.Location = new System.Drawing.Point(240, 24);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(203, 38);
            this.lbl_Welcome.TabIndex = 7;
            this.lbl_Welcome.Text = "Welcome Back,";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_username.Location = new System.Drawing.Point(435, 24);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(114, 38);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "Admin!";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pb_logo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 900);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Location = new System.Drawing.Point(0, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(220, 3);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Library_Management_System__Final_Project_.Properties.Resources.logo_no_background;
            this.pb_logo.Location = new System.Drawing.Point(19, 16);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(184, 52);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // tb_Search
            // 
            this.tb_Search.AccessibleName = "Search";
            this.tb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(839, 34);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(210, 25);
            this.tb_Search.TabIndex = 39;
            this.tb_Search.Tag = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1052, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 40;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
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
            // Btn_BooksLost
            // 
            this.Btn_BooksLost.BackColor = System.Drawing.Color.White;
            this.Btn_BooksLost.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BooksLost.FlatAppearance.BorderSize = 0;
            this.Btn_BooksLost.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BooksLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BooksLost.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BooksLost.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BooksLost.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_important_book_24;
            this.Btn_BooksLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksLost.Location = new System.Drawing.Point(22, 301);
            this.Btn_BooksLost.Name = "Btn_BooksLost";
            this.Btn_BooksLost.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksLost.TabIndex = 5;
            this.Btn_BooksLost.Text = "       Books Lost";
            this.Btn_BooksLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksLost.UseVisualStyleBackColor = false;
            this.Btn_BooksLost.Click += new System.EventHandler(this.Btn_BooksLost_Click);
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
            this.Btn_BooksReturned.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_return_book_24;
            this.Btn_BooksReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksReturned.Location = new System.Drawing.Point(22, 261);
            this.Btn_BooksReturned.Name = "Btn_BooksReturned";
            this.Btn_BooksReturned.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksReturned.TabIndex = 3;
            this.Btn_BooksReturned.Text = "       Books Returned";
            this.Btn_BooksReturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksReturned.UseVisualStyleBackColor = false;
            this.Btn_BooksReturned.Click += new System.EventHandler(this.Btn_BooksReturned_Click);
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
            this.Btn_BooksBorrowed.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_borrow_book_24;
            this.Btn_BooksBorrowed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksBorrowed.Location = new System.Drawing.Point(22, 221);
            this.Btn_BooksBorrowed.Name = "Btn_BooksBorrowed";
            this.Btn_BooksBorrowed.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksBorrowed.TabIndex = 2;
            this.Btn_BooksBorrowed.Text = "       Books Borrowed";
            this.Btn_BooksBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksBorrowed.UseVisualStyleBackColor = false;
            this.Btn_BooksBorrowed.Click += new System.EventHandler(this.Btn_BooksBorrowed_Click);
            // 
            // Btn_BookList
            // 
            this.Btn_BookList.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_BookList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_BookList.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_BookList.FlatAppearance.BorderSize = 0;
            this.Btn_BookList.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_BookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BookList.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BookList.ForeColor = System.Drawing.Color.Maroon;
            this.Btn_BookList.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_books_24;
            this.Btn_BookList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BookList.Location = new System.Drawing.Point(22, 181);
            this.Btn_BookList.Name = "Btn_BookList";
            this.Btn_BookList.Size = new System.Drawing.Size(172, 32);
            this.Btn_BookList.TabIndex = 1;
            this.Btn_BookList.Text = "       Book List";
            this.Btn_BookList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BookList.UseVisualStyleBackColor = false;
            this.Btn_BookList.Click += new System.EventHandler(this.Btn_BookList_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.lbl_InsertPhoto);
            this.panel2.Controls.Add(this.btn_UploadImage);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_InsertISBN);
            this.panel2.Controls.Add(this.MinBtn);
            this.panel2.Controls.Add(this.txt_InsertISBN);
            this.panel2.Controls.Add(this.lbl_InsertPublishedDate);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.lbl_InsertAuthor);
            this.panel2.Controls.Add(this.dtp_InsertPublishedDate);
            this.panel2.Controls.Add(this.txt_InsertBookTitle);
            this.panel2.Controls.Add(this.lbl_InsertBookTitle);
            this.panel2.Controls.Add(this.pb_PreviewImage);
            this.panel2.Controls.Add(this.txt_InsertAuthor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 900);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.Location = new System.Drawing.Point(32, 781);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(220, 3);
            this.pictureBox6.TabIndex = 56;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Library_Management_System__Final_Project_.Properties.Resources.logo_no_background;
            this.pictureBox5.Location = new System.Drawing.Point(50, 816);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(184, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 55;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(32, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 3);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Maroon;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(52, 696);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(180, 47);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "INSERT";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lbl_InsertPhoto
            // 
            this.lbl_InsertPhoto.AutoSize = true;
            this.lbl_InsertPhoto.BackColor = System.Drawing.Color.White;
            this.lbl_InsertPhoto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertPhoto.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_InsertPhoto.Location = new System.Drawing.Point(22, 544);
            this.lbl_InsertPhoto.Name = "lbl_InsertPhoto";
            this.lbl_InsertPhoto.Size = new System.Drawing.Size(72, 23);
            this.lbl_InsertPhoto.TabIndex = 31;
            this.lbl_InsertPhoto.Text = "PHOTO:";
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.FlatAppearance.BorderSize = 0;
            this.btn_UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_UploadImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadImage.Location = new System.Drawing.Point(26, 570);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(110, 27);
            this.btn_UploadImage.TabIndex = 0;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(71, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 28);
            this.label15.TabIndex = 34;
            this.label15.Text = "INSERT BOOK";
            // 
            // lbl_InsertISBN
            // 
            this.lbl_InsertISBN.AutoSize = true;
            this.lbl_InsertISBN.BackColor = System.Drawing.Color.White;
            this.lbl_InsertISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertISBN.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_InsertISBN.Location = new System.Drawing.Point(22, 432);
            this.lbl_InsertISBN.Name = "lbl_InsertISBN";
            this.lbl_InsertISBN.Size = new System.Drawing.Size(54, 23);
            this.lbl_InsertISBN.TabIndex = 30;
            this.lbl_InsertISBN.Text = "ISBN:";
            // 
            // txt_InsertISBN
            // 
            this.txt_InsertISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InsertISBN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertISBN.Location = new System.Drawing.Point(25, 458);
            this.txt_InsertISBN.Name = "txt_InsertISBN";
            this.txt_InsertISBN.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertISBN.TabIndex = 20;
            // 
            // lbl_InsertPublishedDate
            // 
            this.lbl_InsertPublishedDate.AutoSize = true;
            this.lbl_InsertPublishedDate.BackColor = System.Drawing.Color.White;
            this.lbl_InsertPublishedDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertPublishedDate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_InsertPublishedDate.Location = new System.Drawing.Point(24, 331);
            this.lbl_InsertPublishedDate.Name = "lbl_InsertPublishedDate";
            this.lbl_InsertPublishedDate.Size = new System.Drawing.Size(155, 23);
            this.lbl_InsertPublishedDate.TabIndex = 28;
            this.lbl_InsertPublishedDate.Text = "PUBLISHED DATE:";
            // 
            // lbl_InsertAuthor
            // 
            this.lbl_InsertAuthor.AutoSize = true;
            this.lbl_InsertAuthor.BackColor = System.Drawing.Color.White;
            this.lbl_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertAuthor.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_InsertAuthor.Location = new System.Drawing.Point(23, 230);
            this.lbl_InsertAuthor.Name = "lbl_InsertAuthor";
            this.lbl_InsertAuthor.Size = new System.Drawing.Size(86, 23);
            this.lbl_InsertAuthor.TabIndex = 27;
            this.lbl_InsertAuthor.Text = "AUTHOR:";
            // 
            // dtp_InsertPublishedDate
            // 
            this.dtp_InsertPublishedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_InsertPublishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_InsertPublishedDate.Location = new System.Drawing.Point(27, 357);
            this.dtp_InsertPublishedDate.Name = "dtp_InsertPublishedDate";
            this.dtp_InsertPublishedDate.Size = new System.Drawing.Size(228, 25);
            this.dtp_InsertPublishedDate.TabIndex = 41;
            // 
            // txt_InsertBookTitle
            // 
            this.txt_InsertBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertBookTitle.Location = new System.Drawing.Point(27, 155);
            this.txt_InsertBookTitle.Name = "txt_InsertBookTitle";
            this.txt_InsertBookTitle.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertBookTitle.TabIndex = 15;
            // 
            // lbl_InsertBookTitle
            // 
            this.lbl_InsertBookTitle.AutoSize = true;
            this.lbl_InsertBookTitle.BackColor = System.Drawing.Color.White;
            this.lbl_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertBookTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_InsertBookTitle.Location = new System.Drawing.Point(23, 129);
            this.lbl_InsertBookTitle.Name = "lbl_InsertBookTitle";
            this.lbl_InsertBookTitle.Size = new System.Drawing.Size(111, 23);
            this.lbl_InsertBookTitle.TabIndex = 26;
            this.lbl_InsertBookTitle.Text = "BOOK TITLE:";
            // 
            // pb_PreviewImage
            // 
            this.pb_PreviewImage.BackColor = System.Drawing.Color.LightGray;
            this.pb_PreviewImage.Location = new System.Drawing.Point(175, 518);
            this.pb_PreviewImage.Name = "pb_PreviewImage";
            this.pb_PreviewImage.Size = new System.Drawing.Size(80, 128);
            this.pb_PreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PreviewImage.TabIndex = 42;
            this.pb_PreviewImage.TabStop = false;
            // 
            // txt_InsertAuthor
            // 
            this.txt_InsertAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InsertAuthor.Location = new System.Drawing.Point(27, 256);
            this.txt_InsertAuthor.Name = "txt_InsertAuthor";
            this.txt_InsertAuthor.Size = new System.Drawing.Size(228, 25);
            this.txt_InsertAuthor.TabIndex = 16;
            // 
            // uC_BooksReturned1
            // 
            this.uC_BooksReturned1.Location = new System.Drawing.Point(227, 65);
            this.uC_BooksReturned1.Name = "uC_BooksReturned1";
            this.uC_BooksReturned1.Size = new System.Drawing.Size(913, 835);
            this.uC_BooksReturned1.TabIndex = 38;
            // 
            // uC_BooksLost1
            // 
            this.uC_BooksLost1.Location = new System.Drawing.Point(227, 62);
            this.uC_BooksLost1.Name = "uC_BooksLost1";
            this.uC_BooksLost1.Size = new System.Drawing.Size(913, 835);
            this.uC_BooksLost1.TabIndex = 37;
            // 
            // uC_BooksBorrowed1
            // 
            this.uC_BooksBorrowed1.Location = new System.Drawing.Point(227, 62);
            this.uC_BooksBorrowed1.Name = "uC_BooksBorrowed1";
            this.uC_BooksBorrowed1.Size = new System.Drawing.Size(913, 835);
            this.uC_BooksBorrowed1.TabIndex = 36;
            // 
            // uC_BookLists1
            // 
            this.uC_BookLists1.Location = new System.Drawing.Point(227, 62);
            this.uC_BookLists1.Name = "uC_BookLists1";
            this.uC_BookLists1.Size = new System.Drawing.Size(913, 835);
            this.uC_BookLists1.TabIndex = 35;
            // 
            // Form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.uC_BooksReturned1);
            this.Controls.Add(this.uC_BooksLost1);
            this.Controls.Add(this.uC_BooksBorrowed1);
            this.Controls.Add(this.uC_BookLists1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_BooksLost);
            this.Controls.Add(this.lbl_menu);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button Btn_BooksBorrowed;
        private System.Windows.Forms.Button Btn_BooksReturned;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button Btn_BooksLost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private UC_BookLists uC_BookLists1;
        private UC_BooksBorrowed uC_BooksBorrowed1;
        private UC_BooksLost uC_BooksLost1;
        private UC_BooksReturned uC_BooksReturned1;
        private System.Windows.Forms.Button Btn_BookList;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_InsertPublishedDate;
        private System.Windows.Forms.PictureBox pb_PreviewImage;
        private System.Windows.Forms.TextBox txt_InsertBookTitle;
        private System.Windows.Forms.TextBox txt_InsertAuthor;
        private System.Windows.Forms.TextBox txt_InsertISBN;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_InsertBookTitle;
        private System.Windows.Forms.Label lbl_InsertAuthor;
        private System.Windows.Forms.Label lbl_InsertPublishedDate;
        private System.Windows.Forms.Label lbl_InsertISBN;
        private System.Windows.Forms.Label lbl_InsertPhoto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
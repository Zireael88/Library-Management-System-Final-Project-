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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Homepage));
            this.lbl_menu = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_BooksLost = new System.Windows.Forms.Button();
            this.Btn_BooksBorrowed = new System.Windows.Forms.Button();
            this.Btn_BookList = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.uC_BooksLost1 = new Library_Management_System__Final_Project_.UC_BooksLost();
            this.uC_BooksBorrowed1 = new Library_Management_System__Final_Project_.UC_BooksBorrowed();
            this.uC_BookLists1 = new Library_Management_System__Final_Project_.UC_BookLists();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_menu.Location = new System.Drawing.Point(22, 132);
            this.lbl_menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 900);
            this.panel3.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Location = new System.Drawing.Point(0, 82);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(220, 2);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Library_Management_System__Final_Project_.Properties.Resources.logo_no_background;
            this.pb_logo.Location = new System.Drawing.Point(19, 16);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(184, 52);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(218, -9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 920);
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
            this.Btn_BooksLost.Location = new System.Drawing.Point(22, 261);
            this.Btn_BooksLost.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_BooksLost.Name = "Btn_BooksLost";
            this.Btn_BooksLost.Size = new System.Drawing.Size(172, 32);
            this.Btn_BooksLost.TabIndex = 3;
            this.Btn_BooksLost.Text = "       Books Lost";
            this.Btn_BooksLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BooksLost.UseVisualStyleBackColor = false;
            this.Btn_BooksLost.Click += new System.EventHandler(this.Btn_BooksLost_Click);
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
            this.Btn_BooksBorrowed.Margin = new System.Windows.Forms.Padding(2);
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
            this.Btn_BookList.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_BookList.Name = "Btn_BookList";
            this.Btn_BookList.Size = new System.Drawing.Size(172, 32);
            this.Btn_BookList.TabIndex = 1;
            this.Btn_BookList.Text = "       Book List";
            this.Btn_BookList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BookList.UseVisualStyleBackColor = false;
            this.Btn_BookList.Click += new System.EventHandler(this.Btn_BookList_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Location = new System.Drawing.Point(1146, -9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 920);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1400, 1);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 32);
            this.ExitBtn.TabIndex = 42;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Maroon;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1360, 1);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(39, 32);
            this.btn_minimize.TabIndex = 43;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // uC_BooksLost1
            // 
            this.uC_BooksLost1.Location = new System.Drawing.Point(228, 62);
            this.uC_BooksLost1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_BooksLost1.Name = "uC_BooksLost1";
            this.uC_BooksLost1.Size = new System.Drawing.Size(1200, 835);
            this.uC_BooksLost1.TabIndex = 37;
            // 
            // uC_BooksBorrowed1
            // 
            this.uC_BooksBorrowed1.Location = new System.Drawing.Point(228, 62);
            this.uC_BooksBorrowed1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_BooksBorrowed1.Name = "uC_BooksBorrowed1";
            this.uC_BooksBorrowed1.Size = new System.Drawing.Size(1200, 835);
            this.uC_BooksBorrowed1.TabIndex = 36;
            // 
            // uC_BookLists1
            // 
            this.uC_BookLists1.Location = new System.Drawing.Point(228, 62);
            this.uC_BookLists1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_BookLists1.Name = "uC_BookLists1";
            this.uC_BookLists1.Size = new System.Drawing.Size(1200, 835);
            this.uC_BookLists1.TabIndex = 35;
            // 
            // Form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.uC_BooksLost1);
            this.Controls.Add(this.uC_BooksBorrowed1);
            this.Controls.Add(this.uC_BookLists1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_BooksLost);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.Btn_BooksBorrowed);
            this.Controls.Add(this.Btn_BookList);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form_Homepage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Homepage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Homepage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Homepage_MouseUp);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button Btn_BooksBorrowed;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button Btn_BooksLost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private UC_BookLists uC_BookLists1;
        private UC_BooksBorrowed uC_BooksBorrowed1;
        private UC_BooksLost uC_BooksLost1;
        private System.Windows.Forms.Button Btn_BookList;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button btn_minimize;
    }
}
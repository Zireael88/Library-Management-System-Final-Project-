namespace Library_Management_System__Final_Project_
{
    partial class Form_EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditForm));
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_InsertISBN = new System.Windows.Forms.Label();
            this.lbl_InsertPublishedDate = new System.Windows.Forms.Label();
            this.lbl_InsertAuthor = new System.Windows.Forms.Label();
            this.lbl_InsertBookTitle = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.tb_BookTitle = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dtp_PublishedDate = new System.Windows.Forms.DateTimePicker();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(297, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 50;
            this.label15.Text = "EDIT BOOK";
            // 
            // lbl_InsertISBN
            // 
            this.lbl_InsertISBN.AutoSize = true;
            this.lbl_InsertISBN.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertISBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertISBN.Location = new System.Drawing.Point(412, 70);
            this.lbl_InsertISBN.Name = "lbl_InsertISBN";
            this.lbl_InsertISBN.Size = new System.Drawing.Size(54, 23);
            this.lbl_InsertISBN.TabIndex = 47;
            this.lbl_InsertISBN.Text = "ISBN:";
            // 
            // lbl_InsertPublishedDate
            // 
            this.lbl_InsertPublishedDate.AutoSize = true;
            this.lbl_InsertPublishedDate.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertPublishedDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertPublishedDate.Location = new System.Drawing.Point(48, 224);
            this.lbl_InsertPublishedDate.Name = "lbl_InsertPublishedDate";
            this.lbl_InsertPublishedDate.Size = new System.Drawing.Size(155, 23);
            this.lbl_InsertPublishedDate.TabIndex = 46;
            this.lbl_InsertPublishedDate.Text = "PUBLISHED DATE:";
            // 
            // lbl_InsertAuthor
            // 
            this.lbl_InsertAuthor.AutoSize = true;
            this.lbl_InsertAuthor.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertAuthor.Location = new System.Drawing.Point(48, 148);
            this.lbl_InsertAuthor.Name = "lbl_InsertAuthor";
            this.lbl_InsertAuthor.Size = new System.Drawing.Size(86, 23);
            this.lbl_InsertAuthor.TabIndex = 45;
            this.lbl_InsertAuthor.Text = "AUTHOR:";
            // 
            // lbl_InsertBookTitle
            // 
            this.lbl_InsertBookTitle.AutoSize = true;
            this.lbl_InsertBookTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertBookTitle.Location = new System.Drawing.Point(48, 70);
            this.lbl_InsertBookTitle.Name = "lbl_InsertBookTitle";
            this.lbl_InsertBookTitle.Size = new System.Drawing.Size(111, 23);
            this.lbl_InsertBookTitle.TabIndex = 44;
            this.lbl_InsertBookTitle.Text = "BOOK TITLE:";
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Maroon;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Insert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(416, 236);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(109, 47);
            this.btn_Insert.TabIndex = 43;
            this.btn_Insert.Text = "EDIT";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ISBN.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ISBN.Location = new System.Drawing.Point(416, 96);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(229, 25);
            this.tb_ISBN.TabIndex = 42;
            // 
            // tb_Author
            // 
            this.tb_Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Author.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Author.Location = new System.Drawing.Point(52, 174);
            this.tb_Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(229, 25);
            this.tb_Author.TabIndex = 38;
            // 
            // tb_BookTitle
            // 
            this.tb_BookTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_BookTitle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BookTitle.Location = new System.Drawing.Point(52, 96);
            this.tb_BookTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_BookTitle.Name = "tb_BookTitle";
            this.tb_BookTitle.Size = new System.Drawing.Size(229, 25);
            this.tb_BookTitle.TabIndex = 37;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(653, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 33);
            this.ExitBtn.TabIndex = 51;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(693, 38);
            this.pictureBox9.TabIndex = 49;
            this.pictureBox9.TabStop = false;
            // 
            // dtp_PublishedDate
            // 
            this.dtp_PublishedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_PublishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_PublishedDate.Location = new System.Drawing.Point(53, 257);
            this.dtp_PublishedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_PublishedDate.Name = "dtp_PublishedDate";
            this.dtp_PublishedDate.Size = new System.Drawing.Size(228, 25);
            this.dtp_PublishedDate.TabIndex = 52;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(324, 71);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(57, 22);
            this.tb_ID.TabIndex = 53;
            this.tb_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // Form_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(693, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.dtp_PublishedDate);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lbl_InsertISBN);
            this.Controls.Add(this.lbl_InsertPublishedDate);
            this.Controls.Add(this.lbl_InsertAuthor);
            this.Controls.Add(this.lbl_InsertBookTitle);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.tb_ISBN);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.tb_BookTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EditForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_EditForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_EditForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_EditForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.Label lbl_InsertISBN;
        public System.Windows.Forms.Label lbl_InsertPublishedDate;
        public System.Windows.Forms.Label lbl_InsertAuthor;
        public System.Windows.Forms.Label lbl_InsertBookTitle;
        public System.Windows.Forms.Button btn_Insert;
        public System.Windows.Forms.TextBox tb_ISBN;
        public System.Windows.Forms.TextBox tb_Author;
        public System.Windows.Forms.TextBox tb_BookTitle;
        public System.Windows.Forms.DateTimePicker dtp_PublishedDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_ID;
    }
}
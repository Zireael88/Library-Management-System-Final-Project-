namespace Library_Management_System__Final_Project_
{
    partial class Form_Borrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Borrow));
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_InsertAuthor = new System.Windows.Forms.Label();
            this.lbl_InsertBookTitle = new System.Windows.Forms.Label();
            this.tb_BorrowerName = new System.Windows.Forms.TextBox();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ContactNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(208, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 23);
            this.label15.TabIndex = 50;
            this.label15.Text = "BORROW FORM";
            // 
            // lbl_InsertAuthor
            // 
            this.lbl_InsertAuthor.AutoSize = true;
            this.lbl_InsertAuthor.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertAuthor.Location = new System.Drawing.Point(35, 263);
            this.lbl_InsertAuthor.Name = "lbl_InsertAuthor";
            this.lbl_InsertAuthor.Size = new System.Drawing.Size(166, 23);
            this.lbl_InsertAuthor.TabIndex = 45;
            this.lbl_InsertAuthor.Text = "BORROWER NAME:";
            // 
            // lbl_InsertBookTitle
            // 
            this.lbl_InsertBookTitle.AutoSize = true;
            this.lbl_InsertBookTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_InsertBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsertBookTitle.Location = new System.Drawing.Point(35, 78);
            this.lbl_InsertBookTitle.Name = "lbl_InsertBookTitle";
            this.lbl_InsertBookTitle.Size = new System.Drawing.Size(218, 23);
            this.lbl_InsertBookTitle.TabIndex = 44;
            this.lbl_InsertBookTitle.Text = "BOOK TO BE BORROWED:";
            // 
            // tb_BorrowerName
            // 
            this.tb_BorrowerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_BorrowerName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BorrowerName.Location = new System.Drawing.Point(39, 299);
            this.tb_BorrowerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_BorrowerName.Name = "tb_BorrowerName";
            this.tb_BorrowerName.Size = new System.Drawing.Size(465, 25);
            this.tb_BorrowerName.TabIndex = 37;
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_BookTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(35, 110);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(34, 23);
            this.lbl_BookTitle.TabIndex = 51;
            this.lbl_BookTitle.Text = "???";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Author.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(35, 196);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(34, 23);
            this.lbl_Author.TabIndex = 53;
            this.lbl_Author.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 52;
            this.label3.Text = "BOOK AUTHOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "CONTACT NUMBER:";
            // 
            // tb_ContactNumber
            // 
            this.tb_ContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ContactNumber.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ContactNumber.Location = new System.Drawing.Point(39, 390);
            this.tb_ContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ContactNumber.Name = "tb_ContactNumber";
            this.tb_ContactNumber.Size = new System.Drawing.Size(465, 25);
            this.tb_ContactNumber.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "EMAIL:";
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(39, 478);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(465, 25);
            this.tb_Email.TabIndex = 56;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Maroon;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.Color.White;
            this.btn_Enter.Location = new System.Drawing.Point(315, 558);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(143, 47);
            this.btn_Enter.TabIndex = 58;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Maroon;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(80, 558);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(143, 47);
            this.btn_Cancel.TabIndex = 59;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(548, 38);
            this.pictureBox9.TabIndex = 49;
            this.pictureBox9.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(508, 1);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 33);
            this.ExitBtn.TabIndex = 60;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(353, 75);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(73, 25);
            this.tb_ID.TabIndex = 61;
            this.tb_ID.Visible = false;
            // 
            // Form_Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(548, 655);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ContactNumber);
            this.Controls.Add(this.lbl_Author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_BookTitle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lbl_InsertAuthor);
            this.Controls.Add(this.lbl_InsertBookTitle);
            this.Controls.Add(this.tb_BorrowerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Borrow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Borrow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Borrow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Borrow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbl_InsertAuthor;
        private System.Windows.Forms.Label lbl_InsertBookTitle;
        private System.Windows.Forms.TextBox tb_BorrowerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ContactNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button ExitBtn;
        public System.Windows.Forms.Label lbl_BookTitle;
        public System.Windows.Forms.Label lbl_Author;
        public System.Windows.Forms.TextBox tb_ID;
    }
}
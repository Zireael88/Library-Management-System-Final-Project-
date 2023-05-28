namespace Library_Management_System__Final_Project_
{
    partial class form_LogIn
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_members = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Signup = new System.Windows.Forms.Label();
            this.btn_showpassword = new System.Windows.Forms.Button();
            this.pb_logo1 = new System.Windows.Forms.PictureBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.pb_redrectangle = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_redrectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Login.Location = new System.Drawing.Point(30, 141);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(280, 106);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Log In";
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(48, 323);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(565, 38);
            this.tb_email.TabIndex = 2;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(51, 271);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(135, 38);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(51, 388);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(126, 38);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(48, 440);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(565, 38);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Maroon;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(48, 518);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(565, 38);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_members
            // 
            this.lbl_members.AutoSize = true;
            this.lbl_members.BackColor = System.Drawing.Color.Maroon;
            this.lbl_members.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_members.ForeColor = System.Drawing.Color.White;
            this.lbl_members.Location = new System.Drawing.Point(1114, 655);
            this.lbl_members.Name = "lbl_members";
            this.lbl_members.Size = new System.Drawing.Size(198, 84);
            this.lbl_members.TabIndex = 11;
            this.lbl_members.Text = "Ellaine Rose Balatbat\r\nSamantha Faith Tan\r\nLenar Andrei Yolola\r\n";
            this.lbl_members.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1393, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(39, 33);
            this.ExitBtn.TabIndex = 36;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(49, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Not registered yet?";
            // 
            // btn_Signup
            // 
            this.btn_Signup.AutoSize = true;
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Signup.Location = new System.Drawing.Point(226, 581);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(175, 28);
            this.btn_Signup.TabIndex = 38;
            this.btn_Signup.Text = "Create an account";
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // btn_showpassword
            // 
            this.btn_showpassword.FlatAppearance.BorderSize = 0;
            this.btn_showpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showpassword.Image = global::Library_Management_System__Final_Project_.Properties.Resources.icons8_show_24;
            this.btn_showpassword.Location = new System.Drawing.Point(565, 441);
            this.btn_showpassword.Name = "btn_showpassword";
            this.btn_showpassword.Size = new System.Drawing.Size(47, 36);
            this.btn_showpassword.TabIndex = 39;
            this.btn_showpassword.UseVisualStyleBackColor = true;
            this.btn_showpassword.Click += new System.EventHandler(this.btn_showpassword_Click);
            // 
            // pb_logo1
            // 
            this.pb_logo1.BackColor = System.Drawing.Color.Maroon;
            this.pb_logo1.Image = global::Library_Management_System__Final_Project_.Properties.Resources.logo_no_background1;
            this.pb_logo1.Location = new System.Drawing.Point(1065, 60);
            this.pb_logo1.Name = "pb_logo1";
            this.pb_logo1.Size = new System.Drawing.Size(296, 66);
            this.pb_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo1.TabIndex = 0;
            this.pb_logo1.TabStop = false;
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.Color.Maroon;
            this.pb_image.Image = global::Library_Management_System__Final_Project_.Properties.Resources.Untitled_design__1_;
            this.pb_image.Location = new System.Drawing.Point(1084, 266);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(268, 251);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 10;
            this.pb_image.TabStop = false;
            // 
            // pb_redrectangle
            // 
            this.pb_redrectangle.BackColor = System.Drawing.Color.Maroon;
            this.pb_redrectangle.Location = new System.Drawing.Point(976, -13);
            this.pb_redrectangle.Name = "pb_redrectangle";
            this.pb_redrectangle.Size = new System.Drawing.Size(464, 973);
            this.pb_redrectangle.TabIndex = 9;
            this.pb_redrectangle.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1159, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "MADE BY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_showpassword);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.pb_logo1);
            this.Controls.Add(this.lbl_members);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.pb_redrectangle);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_redrectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pb_redrectangle;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl_members;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_Signup;
        private System.Windows.Forms.Button btn_showpassword;
        private System.Windows.Forms.Label label2;
    }
}


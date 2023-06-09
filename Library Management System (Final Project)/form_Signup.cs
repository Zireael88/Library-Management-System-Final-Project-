﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Library_Management_System__Final_Project_
{
    public partial class form_Signup : Form
    {

        private OleDbConnection conn = new OleDbConnection();
        public form_Signup()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb;
            Persist Security Info=False;";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult IExit;
            IExit = MessageBox.Show("Are you sure you want to exit", "Leaving So Soon?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (IExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try 
            {
                if (tb_password.Text == tb_confirmpassword.Text)
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Account(username,[password])values('"+tb_email.Text+"','"+tb_confirmpassword.Text+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Created","Accounts",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    conn.Close();

                    form_LogIn form_LogIn = new form_LogIn();
                    this.Hide();
                    form_LogIn.ShowDialog();
                    
                }
                else 
                {
                    MessageBox.Show("Passwords do not match!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            form_LogIn form_LogIn = new form_LogIn();
            this.Hide();
            form_LogIn.ShowDialog();
            
        }

        private void btn_showpassword_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar == true)
            {
                btn_showpassword.Image = Library_Management_System__Final_Project_.Properties.Resources.icons8_hide_24;
                tb_password.UseSystemPasswordChar = false;
            }
            else if (tb_password.UseSystemPasswordChar == false)
            {
                btn_showpassword.Image = Library_Management_System__Final_Project_.Properties.Resources.icons8_show_24;
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tb_confirmpassword.UseSystemPasswordChar == true)
            {
                btn_confirm.Image = Library_Management_System__Final_Project_.Properties.Resources.icons8_hide_24;
                tb_confirmpassword.UseSystemPasswordChar = false;
            }
            else if (tb_confirmpassword.UseSystemPasswordChar == false)
            {
                btn_confirm.Image = Library_Management_System__Final_Project_.Properties.Resources.icons8_show_24;
                tb_confirmpassword.UseSystemPasswordChar = true;
            }
        }
    }
}

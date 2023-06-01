using System;
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
    public partial class form_LogIn : Form
    {

        private OleDbConnection conn = new OleDbConnection();
        public form_LogIn()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb;
            Persist Security Info=False;";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Account where username = '" + tb_email.Text + "' and password='" + tb_password.Text + "'";

                OleDbDataReader or = cmd.ExecuteReader();
                int count = 0;
                while (or.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_Homepage hp = new Form_Homepage();
                    hp.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Login Failed\nIncorrect Username or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
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

        private void btn_Signup_Click(object sender, EventArgs e)
        {
           form_Signup form_Signup = new form_Signup();
            this.Hide();
            form_Signup.ShowDialog();
            
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

        private void btn_login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }
    }
}

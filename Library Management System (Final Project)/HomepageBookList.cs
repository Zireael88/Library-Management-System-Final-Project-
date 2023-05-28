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
    public partial class Form_Homepage : Form
    {

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        public Form_Homepage()
        {
            InitializeComponent();

        }
        //void dataviewer()
        //{
        //    try
        //    {

        //        conn.Open();
        //        OleDbCommand cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from BookList";
        //        cmd.ExecuteNonQuery();
        //        DataTable dt = new DataTable();
        //        OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
        //        dp.Fill(dt);
        //        //dg_Booklist.DataSource = dt;
        //        conn.Close();





        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        //        conn.Close();
        //    }
        //}

        private void Form_Homepage_Load(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = true;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = false;
            uC_BooksReturned1.Visible = false;


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

        private void MinBtn_Click(object sender, EventArgs e)
        {
                this.WindowState=FormWindowState.Minimized;    
        }

        private void Btn_BookList_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = true;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = false;
            uC_BooksReturned1.Visible = false;
            Btn_BookList.BackColor = Color.Gainsboro;
            Btn_BooksBorrowed.BackColor = Color.White;
            Btn_BooksLost.BackColor = Color.White;
            Btn_BooksReturned.BackColor = Color.White;
        }

        private void Btn_BooksBorrowed_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = false;
            uC_BooksBorrowed1.Visible = true;
            uC_BooksLost1.Visible = false;
            uC_BooksReturned1.Visible = false;
            Btn_BookList.BackColor = Color.White;
            Btn_BooksBorrowed.BackColor = Color.Gainsboro;
            Btn_BooksLost.BackColor = Color.White;
            Btn_BooksReturned.BackColor = Color.White;
        }


        private void Btn_BooksReturned_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = false;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = false;
            uC_BooksReturned1.Visible = true;
            Btn_BookList.BackColor = Color.White;
            Btn_BooksBorrowed.BackColor = Color.White;
            Btn_BooksLost.BackColor = Color.White;
            Btn_BooksReturned.BackColor = Color.Gainsboro;
        }

        private void Btn_BooksLost_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = false;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = true;
            uC_BooksReturned1.Visible = false;
            Btn_BookList.BackColor = Color.White;
            Btn_BooksBorrowed.BackColor = Color.White;
            Btn_BooksLost.BackColor = Color.Gainsboro;
            Btn_BooksReturned.BackColor = Color.White;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into BookList(ISBN,BookTitle,Author,PublishedDate)values('" + txt_InsertISBN.Text + "','" + txt_InsertBookTitle.Text + "','" + txt_InsertAuthor.Text + "','" + dtp_InsertPublishedDate.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Added", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
            txt_InsertAuthor.Text = "";
            txt_InsertISBN.Text = "";
            txt_InsertBookTitle.Text = "";
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pb_PreviewImage.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}

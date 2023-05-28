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
    public partial class Form_EditForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\saman\source\repos\Library Management System(Final Project)\Library Management System(Final Project)\BooksDatabase.accdb");
        public Form_EditForm()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {

                //conn.Open();
                //OleDbCommand cmd = conn.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Insert into BookList(ID,ISBN,Book Title,Status,Published Date,Times Borrowed,BookCover)values('" + null + "','" + txt_InsertISBN.Text + "','" + txt_InsertBookTitle.Text + "','" + null + "','" + txt_InsertPublishedDate + "','" + null + "','" + null + "')";
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Successfully Added", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

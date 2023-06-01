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
using System.Net.NetworkInformation;
using System.IO;

namespace Library_Management_System__Final_Project_
{
    public partial class Form_EditForm : Form
    {
        private bool isDragging = false;
        private Point dragOffset;

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        OleDbCommand cmd;
        string updatequery = "UPDATE BookList SET ISBN = ?, BookTitle = ?,Author = ?,PublishedDate=? WHERE ID = ?";
        public Form_EditForm()
        {
            InitializeComponent();
        }
        //Function For Converting Image To Byte Array
        public byte[] convertImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }
        //Function for Converting Byte Array To Image 
        public Image convertByteArrayToImage(byte[] img)
        {
            if (img == null || img.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }

        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            
            try
            {

                    conn.Open();
                    cmd = new OleDbCommand(updatequery, conn);
                    cmd.Parameters.AddWithValue("ISBN", OleDbType.VarChar).Value = tb_ISBN.Text;
                    cmd.Parameters.AddWithValue("BookTitle", OleDbType.VarChar).Value = tb_BookTitle.Text;
                    cmd.Parameters.AddWithValue("Author", OleDbType.VarChar).Value = tb_Author.Text;
                    cmd.Parameters.AddWithValue("PublishedDate", OleDbType.VarChar).Value = dtp_PublishedDate.Text;
                    //cmd.Parameters.AddWithValue("BookCover", OleDbType.Binary).Value = convertImageToByteArray(pb_editPreviewImage.Image);
                    cmd.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(tb_ID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Updated", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_EditForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }

        private void Form_EditForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - dragOffset.X;
                newLocation.Y += e.Y - dragOffset.Y;
                this.Location = newLocation;
            }
        }

        private void Form_EditForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}

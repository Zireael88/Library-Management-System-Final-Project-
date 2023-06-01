using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Library_Management_System__Final_Project_
{
    public partial class Form_Borrow : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        OleDbCommand cmd;
        string updatequery = "UPDATE BookList SET Status = ? WHERE ID = ?";
        private bool isDragging = false;
        private Point dragOffset;
        public Form_Borrow()
        {
            InitializeComponent();
        }
        //Function For Converting Image To Byte Array
        public byte[] convertImageToByteArray(Image img)
        {
            //try
            //{
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            //}
            //catch (Exception ex)
            //{
                
            //    MessageBox.Show(ex.Message);
            //    return null;
            //}
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Borrow_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }

        private void Form_Borrow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - dragOffset.X;
                newLocation.Y += e.Y - dragOffset.Y;
                this.Location = newLocation;
            }
        }

        private void Form_Borrow_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string availability = "Not Available";
            string datetoday = DateTime.Today.ToString("M/d/yyyy");
            string timetoday = DateTime.Now.ToString("hh:mm:ss tt");

            UC_BookLists uc = new UC_BookLists();
            try
            {
                //Check If One Or More Fields Are Empty
                if (tb_BorrowerName.Text == String.Empty || tb_ContactNumber.Text == String.Empty || tb_Email.Text== String.Empty)
                {
                    MessageBox.Show("One Or More Empty Field\n Make sure all fields are filled............", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    conn.Open();
                    OleDbCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    //'" + tb_BorrowerName.Text + "','" + tb_ContactNumber.Text + "','" + tb_Email.Text + "','" + lbl_BookTitle.Text + "','" + datetoday + "','"+ timetoday +"'                                                                                                                                                                                                                                                      
                    cmd2.CommandText = "Insert into BooksBorrowed(BorrowerName,ContactNumber,Email,Book,DateBorrowed,[Time])values(?,?,?,?,?,?)";
                    cmd2.Parameters.AddWithValue("BorrowerName", OleDbType.VarChar).Value= tb_BorrowerName.Text;
                    cmd2.Parameters.AddWithValue("ContactNumber", OleDbType.VarChar).Value = tb_ContactNumber.Text;
                    cmd2.Parameters.AddWithValue("Email", OleDbType.VarChar).Value = tb_Email.Text;
                    cmd2.Parameters.AddWithValue("Book", OleDbType.VarChar).Value = lbl_BookTitle.Text;
                    cmd2.Parameters.AddWithValue("DateBorrowed", OleDbType.VarChar).Value = datetoday;
                    cmd2.Parameters.AddWithValue("[Time]", OleDbType.VarChar).Value = timetoday;

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Borrowed", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conn.Close();

                }
                conn.Open();
                cmd = new OleDbCommand(updatequery, conn);
                cmd.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = availability;
                cmd.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(tb_ID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book is Now not Available for Borrowwing", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}

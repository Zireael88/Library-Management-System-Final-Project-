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
using System.IO;


namespace Library_Management_System__Final_Project_
{
    public partial class UC_BooksLost : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        public UC_BooksLost()
        {
            InitializeComponent();
        }
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
        public void dataviewer()
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BooksLost";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);

                dg_Bookslost.DataSource = dt;
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btn_BookLostsearch_Click(object sender, EventArgs e)
        {
            //UC_BookLists uc = new UC_BookLists();
            //if (tb_Search.Text != "")
            //{
            //    uc.dg_Booklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    OleDbDataAdapter adap = new OleDbDataAdapter();
            //    DataSet ds = new DataSet();
            //    DataView dv = new DataView();

            //    string cmd = "Select * From BookList Where BookTitle like '%" + tb_Search.Text + "%';";

            //    conn.Open();
            //    adap = new OleDbDataAdapter(cmd, conn);
            //    adap.Fill(ds);
            //    dv = new DataView(ds.Tables[0]);
            //    uc.dg_Booklist.DataSource = dv;
            //    conn.Close();
            //}
            //else if (tb_Search.Text == "") 
            //{
            //    uc.dg_Booklist.Refresh();
            //}
        }

        private void tb_BooksLostSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //UC_BookLists uc = new UC_BookLists();
            //if (tb_Search.Text != "")
            //{
            //    uc.dg_Booklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //    OleDbDataAdapter adap = new OleDbDataAdapter();
            //    DataSet ds = new DataSet();
            //    DataView dv = new DataView();

            //    string cmd = "Select * From BookList Where BookTitle like '%" + tb_Search.Text + "%';";

            //    conn.Open();
            //    adap = new OleDbDataAdapter(cmd, conn);
            //    adap.Fill(ds);
            //    dv = new DataView(ds.Tables[0]);
            //    uc.dg_Booklist.DataSource = dv;
            //    conn.Close();
            //}
            //else if (tb_Search.Text == "")
            //{
            //    uc.dg_Booklist.Refresh();
            //}
        }

        private void btn_BooksLostRefresh_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void dg_Bookslost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_Bookslost.Rows[e.RowIndex];
                    lbl_BooksLostBookTitle.Text = row.Cells["BookTitle"].Value.ToString();
                    lbl_BooksLostAuthor.Text = row.Cells["Author"].Value.ToString();
                    lbl_BooksLostISBN.Text = row.Cells["ISBN"].Value.ToString();
                    lbl_BooksLostPublishedDate.Text = row.Cells["PublishedDate"].Value.ToString();
                    lbl_BooksLostStatus.Text = row.Cells["Status"].Value.ToString();
                    //lbl.Text = row.Cells["ID"].Value.ToString();





                   








                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UC_BooksLost_Load(object sender, EventArgs e)
        {
            try
            {
                dataviewer();

                dg_Bookslost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dg_Bookslost.CellClick += (gridSender, cellClickEvent) =>
                {
                    if (cellClickEvent.RowIndex >= 0)
                    {
                        dg_Bookslost.Rows[cellClickEvent.RowIndex].Selected = true;
                    }
                };
                //Column and Row size changes
                dg_Bookslost.RowHeadersVisible = false;
                dg_Bookslost.Columns["TimesBorrowed"].Visible = false;
                dg_Bookslost.Columns["BookCover"].Visible = false;
                dg_Bookslost.Columns["ID"].Width = 49;
                dg_Bookslost.Columns["ISBN"].Width = 125;
                dg_Bookslost.Columns["BookTitle"].Width = 275;
                dg_Bookslost.Columns["Author"].Width = 200;
                dg_Bookslost.Columns["Status"].Width = 104;
                dg_Bookslost.Columns["PublishedDate"].Width = 110;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string availability = "Available";


            try
            {
                //Check If One Or More Fields Are Empty
                if (txt_InsertISBN.Text == String.Empty || txt_InsertBookTitle.Text == String.Empty || dtp_InsertPublishedDate.Text == String.Empty || txt_InsertAuthor.Text == String.Empty || pb_PreviewImage.Image == null)
                {
                    MessageBox.Show("One Or More Empty Field\n Make sure all fields are filled............", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into BookList(ISBN,BookTitle,Author,Status,PublishedDate,BookCover)values(?,?,?,?,?,?)";
                    cmd.Parameters.AddWithValue("ISBN", OleDbType.VarChar).Value = txt_InsertISBN.Text;
                    cmd.Parameters.AddWithValue("BookTitle", OleDbType.VarChar).Value = txt_InsertBookTitle.Text;
                    cmd.Parameters.AddWithValue("Author", OleDbType.VarChar).Value = txt_InsertAuthor.Text;
                    cmd.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = availability;
                    cmd.Parameters.AddWithValue("PublishedDate", OleDbType.VarChar).Value = dtp_InsertPublishedDate.Text;
                    cmd.Parameters.AddWithValue("BookCover", OleDbType.Binary).Value = convertImageToByteArray(pb_PreviewImage.Image);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Added", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    dataviewer();
                    txt_InsertAuthor.Text = "";
                    txt_InsertISBN.Text = "";
                    txt_InsertBookTitle.Text = "";
                    pb_PreviewImage.Image = null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string imageFile = ofd.FileName;
                        byte[] imageData = File.ReadAllBytes(imageFile);
                        pb_PreviewImage.Image = Image.FromFile(imageFile);
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

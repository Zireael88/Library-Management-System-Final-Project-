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

    public partial class UC_BookLists : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        string updatequery = "UPDATE BookList SET Status = ? WHERE ID = ?";
        public UC_BookLists()
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

        

        public void dataviewer()
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BookList";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);

                dg_Booklist.DataSource = dt;
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void UC_BookLists_Load(object sender, EventArgs e)
        {
            try
            {
                dataviewer();

                dg_Booklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dg_Booklist.CellClick += (gridSender, cellClickEvent) =>
                {
                    if (cellClickEvent.RowIndex >= 0)
                    {
                        dg_Booklist.Rows[cellClickEvent.RowIndex].Selected = true;
                    }
                };
                //Column and Row size changes
                dg_Booklist.RowHeadersVisible = false;
                dg_Booklist.Columns["BookCover"].Visible = false;
                dg_Booklist.Columns["ID"].Width = 49;
                dg_Booklist.Columns["ISBN"].Width = 125;
                dg_Booklist.Columns["BookTitle"].Width = 275;
                dg_Booklist.Columns["Author"].Width = 200;
                dg_Booklist.Columns["Status"].Width = 104;
                dg_Booklist.Columns["PublishedDate"].Width = 110;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_Booklist.SelectedRows.Count > 0)
                {
                    int selectedRowID = (int)dg_Booklist.SelectedRows[0].Cells["ID"].Value;
                    ((DataTable)dg_Booklist.DataSource).Rows.RemoveAt(dg_Booklist.SelectedRows[0].Index);
                    dg_Booklist.Refresh();

                    using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb")) // Replace with your actual connection string
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM BookList WHERE ID = ?";
                        OleDbCommand cmd = new OleDbCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@ID", selectedRowID);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Form_EditForm form_EditForm = new Form_EditForm();

                UC_BookLists uc = new UC_BookLists();
                if (dg_Booklist.SelectedRows.Count == 1 && dg_Booklist.Rows.Count > 0)
                {
                    form_EditForm.tb_BookTitle.Text = dg_Booklist.SelectedRows[0].Cells[2].Value.ToString();
                    form_EditForm.tb_ISBN.Text = dg_Booklist.SelectedRows[0].Cells[1].Value.ToString();
                    form_EditForm.tb_Author.Text = dg_Booklist.SelectedRows[0].Cells[3].Value.ToString();
                    form_EditForm.dtp_PublishedDate.Text = dg_Booklist.SelectedRows[0].Cells[5].Value.ToString();
                    form_EditForm.tb_ID.Text = dg_Booklist.SelectedRows[0].Cells[0].Value.ToString();
                    //form_EditForm.pb_editPreviewImage.Image = convertByteArrayToImage((byte[])dg_Booklist.SelectedRows[0].Cells["BookCover"].Value);//dg_Booklist.SelectedRows[0].Cells[7].Value

                    form_EditForm.ShowDialog();
                }
                else if (dg_Booklist.Rows.Count == 0)
                {
                    MessageBox.Show("DataGridView Is Empty......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dg_Booklist.SelectedRows.Count == 0 && dg_Booklist.Rows.Count > 0)
                {
                    MessageBox.Show("DataGridView Has Data But There Is No Row Selected......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dg_Booklist.SelectedRows.Count > 1)
                {
                    MessageBox.Show("You Have Selected More Than One Row Please Select One Row Only......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Unknown Error Try Again......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Borrrow_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_Booklist.SelectedRows.Count == 1 && dg_Booklist.Rows.Count > 0)
                {
                    Form_Borrow form_Borrow = new Form_Borrow();
                    form_Borrow.lbl_BookTitle.Text = dg_Booklist.SelectedRows[0].Cells[2].Value.ToString();
                    form_Borrow.lbl_Author.Text = dg_Booklist.SelectedRows[0].Cells[3].Value.ToString();
                    form_Borrow.tb_ID.Text = dg_Booklist.SelectedRows[0].Cells[0].Value.ToString();
                    form_Borrow.ShowDialog();
                }

                else if (dg_Booklist.Rows.Count == 0)
                {
                    MessageBox.Show("DataGridView Is Empty......","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (dg_Booklist.SelectedRows.Count == 0 && dg_Booklist.Rows.Count > 0)
                {
                    MessageBox.Show("DataGridView Has Data But There Is No Row Selected......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (dg_Booklist.SelectedRows.Count > 1)
                {
                    MessageBox.Show("You Have Selected More Than One Row Please Select One Row Only......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Unknown Error Try Again......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_Booklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_Booklist.Rows[e.RowIndex];
                    lbl_BookListBookTitle.Text = row.Cells["BookTitle"].Value.ToString();
                    lbl_BookListAuthor.Text = row.Cells["Author"].Value.ToString();
                    lbl_BookListISBN.Text = row.Cells["ISBN"].Value.ToString();
                    lbl_BookListPublishedDate.Text = row.Cells["PublishedDate"].Value.ToString();
                    lbl_BookListStatus.Text = row.Cells["Status"].Value.ToString();
                    lbl_ID.Text = row.Cells["ID"].Value.ToString();

                    
                   
                       

                        //First cast image from datagridview cell to byte[] and then convert it from byte array to Image then finnaly display it on picturebox.
                        BookCover.Image = convertByteArrayToImage((byte[])row.Cells["BookCover"].Value);
                   







                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("One Or More Empty Field\n Make sure all fields are filled............","Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
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



            /*try
            {
                //Check If One Or More Fields Are Empty
                if (txt_InsertISBN.Text == String.Empty || txt_InsertBookTitle.Text == String.Empty || dtp_InsertPublishedDate.Text == String.Empty || txt_InsertAuthor.Text == String.Empty || pb_PreviewImage.Image == null)
                {
                    MessageBox.Show("One Or More Empty Field MAke sure all fields are filled............");
                }
                else
                {
                    OleDbCommand insertDataIntoMSAccessDataBaseOleDbCommand = new OleDbCommand(insertquery, conn);
                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("ISBN", OleDbType.VarChar).Value = txt_InsertISBN.Text;
                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("BookTitle", OleDbType.VarChar).Value = txt_InsertBookTitle.Text;
                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Author", OleDbType.VarChar).Value = txt_InsertAuthor.Text;
                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = availability;
                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("PublishedDate", OleDbType.VarChar).Value = dtp_InsertPublishedDate.Text;

                    insertDataIntoMSAccessDataBaseOleDbCommand.Parameters.AddWithValue("BookCover", OleDbType.Binary).Value = ConvertImageToByteArray(pb_PreviewImage.Image);

                    //Opening Access Database Connection
                    conn.Open();
                    insertDataIntoMSAccessDataBaseOleDbCommand.ExecuteNonQuery();

                    //If data Has been inserted to the database output the following message
                    
                    
                    MessageBox.Show("Book Successfully Added.........", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
           

            







            }*/
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

        private void btn_BookListsearch_Click(object sender, EventArgs e)
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

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            UC_BookLists uc = new UC_BookLists();
            if (tb_Search.Text != "")
            {
                uc.dg_Booklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OleDbDataAdapter adap = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                string cmd = "Select * From BookList Where BookTitle like '%" + tb_Search.Text + "%';";

                conn.Open();
                adap = new OleDbDataAdapter(cmd, conn);
                adap.Fill(ds);
                dv = new DataView(ds.Tables[0]);
                uc.dg_Booklist.DataSource = dv;
                conn.Close();
            }
            else if (tb_Search.Text == "")
            {
                uc.dg_Booklist.Refresh();
            }
        }

        private void btn_Lost_Click(object sender, EventArgs e)
        {
            string availability = "LOST";
            conn.Open();
            OleDbCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            //'" + tb_BorrowerName.Text + "','" + tb_ContactNumber.Text + "','" + tb_Email.Text + "','" + lbl_BookTitle.Text + "','" + datetoday + "','"+ timetoday +"'                                                                                                                                                                                                                                                      
            cmd2.CommandText = "Insert into BooksLost(ISBN,BookTitle,Author,Status,PublishedDate)values('" + lbl_BookListISBN.Text + "','" + lbl_BookListBookTitle.Text + "','" + lbl_BookListAuthor.Text + "','" + availability + "','" + lbl_BookListPublishedDate.Text+ "')";
            //cmd2.Parameters.AddWithValue("BorrowerName", OleDbType.VarChar).Value = lbl_BookListBookTitle.Text;
            //cmd2.Parameters.AddWithValue("ContactNumber", OleDbType.VarChar).Value = tb_ContactNumber.Text;
            //cmd2.Parameters.AddWithValue("Email", OleDbType.VarChar).Value = tb_Email.Text;
            //cmd2.Parameters.AddWithValue("Book", OleDbType.VarChar).Value = lbl_BookTitle.Text;
            //cmd2.Parameters.AddWithValue("DateBorrowed", OleDbType.VarChar).Value = datetoday;
            //cmd2.Parameters.AddWithValue("[Time]", OleDbType.VarChar).Value = timetoday;
            
            
            cmd2 = new OleDbCommand(updatequery, conn);
            cmd2 = new OleDbCommand(updatequery, conn);
            cmd2.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = availability;
            cmd2.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(lbl_ID.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Book is Lost", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conn.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string availability = "Available";
            OleDbCommand cmd;
           
                
                
                    conn.Open();
                    cmd = new OleDbCommand(updatequery, conn);
                    cmd.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = availability;
                    cmd.Parameters.AddWithValue("ID", OleDbType.Integer).Value = Convert.ToInt16(lbl_ID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book is Now Available for Borrowwing", "Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                
            
        
        }
    }
}

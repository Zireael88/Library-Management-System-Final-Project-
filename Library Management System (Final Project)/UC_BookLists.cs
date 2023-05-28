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

    public partial class UC_BookLists : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        public UC_BookLists()
        {
            InitializeComponent();
            

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
                dg_Booklist.Columns["ISBN"].Width = 75;
                dg_Booklist.Columns["BookTitle"].Width = 250;
                dg_Booklist.Columns["Author"].Width = 150;
                dg_Booklist.Columns["Status"].Width = 104;
                dg_Booklist.Columns["PublishedDate"].Width = 110;
                dg_Booklist.Columns["TimesBorrowed"].Width = 120;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form_EditForm form_EditForm = new Form_EditForm();
            form_EditForm.ShowDialog();
            
        }

        private void btn_Borrrow_Click(object sender, EventArgs e)
        {
            Form_Borrow form_Borrow = new Form_Borrow();
            form_Borrow.ShowDialog();
        }
    }
}

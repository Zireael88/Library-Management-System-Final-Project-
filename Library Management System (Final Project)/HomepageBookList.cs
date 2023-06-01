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
        private bool isDragging = false;
        private Point dragOffset;

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\saman\Documents\BooksDatabase.accdb");
        public Form_Homepage()
        {
            InitializeComponent();

        }
        public void dataviewer()
        {
            try
            {
                UC_BooksBorrowed uC_BooksBorrowed = new UC_BooksBorrowed();

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from BooksBorrowed";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);

                uC_BooksBorrowed.dg_BooksBorrowed.DataSource = dt;
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                conn.Close();
            }
        }


        private void Form_Homepage_Load(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = true;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = false;


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
            Btn_BookList.BackColor = Color.Gainsboro;
            Btn_BooksBorrowed.BackColor = Color.White;
            Btn_BooksLost.BackColor = Color.White;
        }

        private void Btn_BooksBorrowed_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = false;
            uC_BooksBorrowed1.Visible = true;
            uC_BooksLost1.Visible = false;
            Btn_BookList.BackColor = Color.White;
            Btn_BooksBorrowed.BackColor = Color.Gainsboro;
            Btn_BooksLost.BackColor = Color.White;
            
        }


        private void Btn_BooksLost_Click(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = false;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = true;
            Btn_BookList.BackColor = Color.White;
            Btn_BooksBorrowed.BackColor = Color.White;
            Btn_BooksLost.BackColor = Color.Gainsboro;
        }

       

       
        private void Form_Homepage_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragOffset = e.Location;
        }

        private void Form_Homepage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - dragOffset.X;
                newLocation.Y += e.Y - dragOffset.Y;
                this.Location = newLocation;
            }
        }

        private void Form_Homepage_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult IExit;
            IExit = MessageBox.Show("Are you sure you want to exit", "Leaving So Soon?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (IExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_Search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void uC_BooksReturned1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System__Final_Project_
{
    public partial class Form_Homepage : Form
    {
        public Form_Homepage()
        {
            InitializeComponent();

        }

        private void Form_Homepage_Load(object sender, EventArgs e)
        {
            uC_BookLists1.Visible = true;
            uC_BooksBorrowed1.Visible = false;
            uC_BooksLost1.Visible = false;
            uC_BooksReturned1.Visible = false;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
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
            // loadform(new BookList());
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
            //loadform(new BooksBorrowed());
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
            //loadform(new BooksReturned());
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
            // loadform(new BooksLost());
        }


    }
}

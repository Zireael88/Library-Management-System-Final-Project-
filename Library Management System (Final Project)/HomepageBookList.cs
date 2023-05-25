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

        public void loadform(object Form) 
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
                this.WindowState=FormWindowState.Minimized;    
        }

        private void Btn_BooksBorrowed_Click(object sender, EventArgs e)
        {
            loadform(new BooksBorrowed());
        }

        private void Btn_BookList_Click(object sender, EventArgs e)
        {
            loadform(new BookList());
        }

        private void Btn_BooksReturned_Click(object sender, EventArgs e)
        {
            loadform(new BooksReturned());
        }

        private void Btn_BooksLost_Click(object sender, EventArgs e)
        {
            loadform(new BooksLost());
        }
    }
}

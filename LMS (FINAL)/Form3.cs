using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS__FINAL_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "" || txtAuthor.Text.Trim() == "" ||cmbCategory.Text.Trim() == "")
            {
                MessageBox.Show("Please Entre All data anf try again ");
            }
            else
            {

            }
        }
    }
}

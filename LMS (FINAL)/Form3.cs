﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                StreamWriter sw = new StreamWriter("BooksData.txt", true);
                string strbook = txtTitle.Text + ";"
                               + txtAuthor.Text + ";"
                               + cmbCategory.Text;
                sw.WriteLine(strbook);
                sw.Close();
                MessageBox.Show("Book is Added ");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                txtTitle.Focus();

            }
        }
    }
}

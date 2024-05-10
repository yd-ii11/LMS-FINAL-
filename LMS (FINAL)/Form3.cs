using System;
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

            try
            {
                if (txtTitle.Text.Trim() == "" || txtAuthor.Text.Trim() == "" || txtISBN.Text.Trim() == "" || cmbCategory.Text.Trim() == "")
                {
                    MessageBox.Show("Please Entre All data and try again ");
                }
                else
                {

                    StreamReader srcheck = new StreamReader("BooksData.txt");
                    string strcheck = srcheck.ReadToEnd();
                    srcheck.Close();
                    if (strcheck.Contains(txtISBN.Text + ";"))
                    {
                        MessageBox.Show("This ISBN is Exist, Please change and try again ");
                        txtISBN.Focus();
                        txtISBN.SelectAll();
                    }
                    else


                    {
                        StreamWriter sw = new StreamWriter("BooksData.txt", true);
                        string strbook = txtTitle.Text + ";"
                                       + txtAuthor.Text + ";"
                                       + txtISBN.Text + ";"
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
                        foreach (Control c in this.Controls)
                        {
                            if (c is ComboBox)
                            {
                                c.Text = "";
                            }
                        }
                        txtTitle.Focus();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

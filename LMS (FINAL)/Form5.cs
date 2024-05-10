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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
           try
            {
                if (txtFindBook.Text.Trim() != "")
                {
                    StreamReader sr = new StreamReader("BooksData.txt");
                    string line;
                    bool found = false;
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] Books = line.Split(";");
                            if (Books[2] == txtFindBook.Text)
                            {
                                lblTitle.Text = Books[0];
                                lblAuthor.Text = Books[1];
                                lblISBN.Text = Books[2];
                                lblCategory.Text = Books[3];
                                found = true;
                                break;
                            }
                        }

                    } while (line != null);

                    sr.Close();

                    if (!found)
                    {
                        MessageBox.Show("Please Enter ISBN and try again ");
                        txtFindBook.Focus();
                        txtFindBook.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter ISBN and try again ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

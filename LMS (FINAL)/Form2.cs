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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExitForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "" || txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter All data and try again ");
                    txtId.Focus();
                }
                else
                {
                    StreamReader srcheck = new StreamReader("StudentData.txt");
                    string strcheck = srcheck.ReadToEnd();
                    srcheck.Close();
                    if (strcheck.Contains(txtId.Text + ";"))
                    {
                        MessageBox.Show("This ID is Exist, Please change And try again");
                        txtId.Focus();
                        txtId.SelectAll();
                    }
                    else

                    {
                        StreamWriter sw = new StreamWriter("StudentData.txt", true);
                        string strStudent = txtId.Text + ";"
                                          + txtName.Text;
                        sw.WriteLine(strStudent);
                        sw.Close();
                        MessageBox.Show("Student is Added ");
                        foreach (Control c in this.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                        }
                        txtId.Focus();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
                
            
        }
    }
}

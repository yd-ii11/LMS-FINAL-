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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnExitForm4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            if (txtFindStudent.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("StudentData.txt");
                string line = "";
                bool found = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string [] Student = line.Split(';');
                        if (Student [0] == txtFindStudent.Text)
                        {
                            lblStudentFindName.Text = Student[1];
                            lblStudentFindId.Text = Student[0];
                            found = true;
                            break;
                        }
                    }

                } while (line != null);

                sr.Close();

                if (!found)
                {
                    MessageBox.Show("Please Enter ID and try again");
                    txtFindStudent.Focus();
                    txtFindStudent.SelectAll();
                }


            }
            else
            {
                MessageBox.Show("Please Enter ID and try again ");
            }
        }
    }
}

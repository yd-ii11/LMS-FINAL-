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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("BooksData.txt");
            string allbooks = sr.ReadToEnd();
            sr.Close();
            txtShowBooks.Text = allbooks;


        }
    }
}

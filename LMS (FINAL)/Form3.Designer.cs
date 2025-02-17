﻿namespace LMS__FINAL_
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            cmbCategory = new ComboBox();
            btnAddNewBook = new Button();
            btnShowAllBooks = new Button();
            btnExitForm3 = new Button();
            label4 = new Label();
            txtISBN = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 120);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 165);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 250);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(374, 113);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(151, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(374, 158);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(151, 27);
            txtAuthor.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Scientific Books", "Religious Books", "Historical Books", "Political Books", "Novels and Stories" });
            cmbCategory.Location = new Point(374, 242);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 6;
            // 
            // btnAddNewBook
            // 
            btnAddNewBook.Cursor = Cursors.Hand;
            btnAddNewBook.Location = new Point(291, 296);
            btnAddNewBook.Name = "btnAddNewBook";
            btnAddNewBook.Size = new Size(94, 44);
            btnAddNewBook.TabIndex = 7;
            btnAddNewBook.Text = "Add new ";
            btnAddNewBook.UseVisualStyleBackColor = true;
            btnAddNewBook.Click += btnAddNewBook_Click;
            // 
            // btnShowAllBooks
            // 
            btnShowAllBooks.Cursor = Cursors.Hand;
            btnShowAllBooks.Location = new Point(431, 296);
            btnShowAllBooks.Name = "btnShowAllBooks";
            btnShowAllBooks.Size = new Size(94, 44);
            btnShowAllBooks.TabIndex = 8;
            btnShowAllBooks.Text = "Show All";
            btnShowAllBooks.UseVisualStyleBackColor = true;
            btnShowAllBooks.Click += btnShowAllBooks_Click;
            // 
            // btnExitForm3
            // 
            btnExitForm3.BackColor = Color.Red;
            btnExitForm3.Cursor = Cursors.Hand;
            btnExitForm3.Location = new Point(360, 371);
            btnExitForm3.Name = "btnExitForm3";
            btnExitForm3.Size = new Size(94, 38);
            btnExitForm3.TabIndex = 9;
            btnExitForm3.Text = "Exit";
            btnExitForm3.UseVisualStyleBackColor = false;
            btnExitForm3.Click += btnExitForm3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(301, 39);
            label4.Name = "label4";
            label4.Size = new Size(224, 42);
            label4.TabIndex = 10;
            label4.Text = "Add Book";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(374, 202);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(151, 27);
            txtISBN.TabIndex = 11;
            txtISBN.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 209);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "ISBN";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(label5);
            Controls.Add(txtISBN);
            Controls.Add(label4);
            Controls.Add(btnExitForm3);
            Controls.Add(btnShowAllBooks);
            Controls.Add(btnAddNewBook);
            Controls.Add(cmbCategory);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private ComboBox cmbCategory;
        private Button btnAddNewBook;
        private Button btnShowAllBooks;
        private Button btnExitForm3;
        private Label label4;
        private TextBox txtISBN;
        private Label label5;
    }
}
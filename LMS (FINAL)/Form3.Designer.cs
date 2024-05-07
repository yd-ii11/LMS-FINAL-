namespace LMS__FINAL_
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 120);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 165);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 207);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(223, 113);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(151, 27);
            txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(223, 158);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(151, 27);
            txtAuthor.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(223, 199);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 6;
            // 
            // btnAddNewBook
            // 
            btnAddNewBook.Cursor = Cursors.Hand;
            btnAddNewBook.Location = new Point(140, 296);
            btnAddNewBook.Name = "btnAddNewBook";
            btnAddNewBook.Size = new Size(94, 44);
            btnAddNewBook.TabIndex = 7;
            btnAddNewBook.Text = "Add new ";
            btnAddNewBook.UseVisualStyleBackColor = true;
            // 
            // btnShowAllBooks
            // 
            btnShowAllBooks.Cursor = Cursors.Hand;
            btnShowAllBooks.Location = new Point(280, 296);
            btnShowAllBooks.Name = "btnShowAllBooks";
            btnShowAllBooks.Size = new Size(94, 44);
            btnShowAllBooks.TabIndex = 8;
            btnShowAllBooks.Text = "Show All";
            btnShowAllBooks.UseVisualStyleBackColor = true;
            // 
            // btnExitForm3
            // 
            btnExitForm3.Cursor = Cursors.Hand;
            btnExitForm3.Location = new Point(209, 371);
            btnExitForm3.Name = "btnExitForm3";
            btnExitForm3.Size = new Size(94, 38);
            btnExitForm3.TabIndex = 9;
            btnExitForm3.Text = "Exit";
            btnExitForm3.UseVisualStyleBackColor = true;
            btnExitForm3.Click += btnExitForm3_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(150, 39);
            label4.Name = "label4";
            label4.Size = new Size(224, 42);
            label4.TabIndex = 10;
            label4.Text = "Add Book";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
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
    }
}
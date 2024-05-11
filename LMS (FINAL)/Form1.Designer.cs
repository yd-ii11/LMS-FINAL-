namespace LMS__FINAL_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddStudent = new Button();
            btnAddBook = new Button();
            btnFindStudent = new Button();
            btnFindBook = new Button();
            btnExist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 21F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(173, 61);
            label1.Name = "label1";
            label1.Size = new Size(470, 47);
            label1.TabIndex = 0;
            label1.Text = "Library Management System ";
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.White;
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.Font = new Font("Segoe UI", 11F);
            btnAddStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnAddStudent.Location = new Point(48, 275);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 50);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.White;
            btnAddBook.Cursor = Cursors.Hand;
            btnAddBook.Font = new Font("Segoe UI", 11F);
            btnAddBook.ForeColor = SystemColors.ActiveCaptionText;
            btnAddBook.Location = new Point(233, 275);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(150, 50);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "AddBook";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnFindStudent
            // 
            btnFindStudent.BackColor = Color.White;
            btnFindStudent.Cursor = Cursors.Hand;
            btnFindStudent.Font = new Font("Segoe UI", 11F);
            btnFindStudent.ForeColor = SystemColors.ActiveCaptionText;
            btnFindStudent.Location = new Point(418, 275);
            btnFindStudent.Name = "btnFindStudent";
            btnFindStudent.Size = new Size(150, 50);
            btnFindStudent.TabIndex = 3;
            btnFindStudent.Text = "Find Student";
            btnFindStudent.UseVisualStyleBackColor = false;
            btnFindStudent.Click += btnFindStudent_Click;
            // 
            // btnFindBook
            // 
            btnFindBook.BackColor = Color.White;
            btnFindBook.Cursor = Cursors.Hand;
            btnFindBook.Font = new Font("Segoe UI", 11F);
            btnFindBook.ForeColor = SystemColors.ActiveCaptionText;
            btnFindBook.Location = new Point(603, 275);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Size = new Size(150, 50);
            btnFindBook.TabIndex = 4;
            btnFindBook.Text = "Find Book";
            btnFindBook.UseVisualStyleBackColor = false;
            btnFindBook.Click += btnFindBook_Click;
            // 
            // btnExist
            // 
            btnExist.BackColor = Color.Red;
            btnExist.Cursor = Cursors.Hand;
            btnExist.Font = new Font("Segoe UI", 11F);
            btnExist.ForeColor = SystemColors.ButtonHighlight;
            btnExist.Location = new Point(322, 366);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(150, 50);
            btnExist.TabIndex = 5;
            btnExist.Text = "Exit";
            btnExist.UseVisualStyleBackColor = false;
            btnExist.Click += btnExist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExist);
            Controls.Add(btnFindBook);
            Controls.Add(btnFindStudent);
            Controls.Add(btnAddBook);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddStudent;
        private Button btnAddBook;
        private Button btnFindStudent;
        private Button btnFindBook;
        private Button btnExist;
    }
}

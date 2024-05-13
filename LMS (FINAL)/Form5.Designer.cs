namespace LMS__FINAL_
{
    partial class Form5
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnFindBook = new Button();
            txtFindBook = new TextBox();
            panel3 = new Panel();
            btnExit = new Button();
            lblCategory = new Label();
            lblISBN = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 73);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(239, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Search For Book";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(btnFindBook);
            panel2.Controls.Add(txtFindBook);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 377);
            panel2.TabIndex = 1;
            // 
            // btnFindBook
            // 
            btnFindBook.Cursor = Cursors.Hand;
            btnFindBook.Location = new Point(585, 33);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Size = new Size(94, 29);
            btnFindBook.TabIndex = 3;
            btnFindBook.Text = "Find";
            btnFindBook.UseVisualStyleBackColor = true;
            btnFindBook.Click += btnFindBook_Click;
            // 
            // txtFindBook
            // 
            txtFindBook.Location = new Point(315, 37);
            txtFindBook.Name = "txtFindBook";
            txtFindBook.Size = new Size(140, 25);
            txtFindBook.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(lblCategory);
            panel3.Controls.Add(lblISBN);
            panel3.Controls.Add(lblAuthor);
            panel3.Controls.Add(lblTitle);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 206);
            panel3.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Location = new Point(576, 81);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 63);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblCategory
            // 
            lblCategory.BorderStyle = BorderStyle.FixedSingle;
            lblCategory.Location = new Point(266, 158);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(165, 25);
            lblCategory.TabIndex = 9;
            lblCategory.Text = " ";
            lblCategory.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblISBN
            // 
            lblISBN.BorderStyle = BorderStyle.FixedSingle;
            lblISBN.Location = new Point(266, 119);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(165, 25);
            lblISBN.TabIndex = 8;
            lblISBN.Text = " ";
            lblISBN.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAuthor
            // 
            lblAuthor.BorderStyle = BorderStyle.FixedSingle;
            lblAuthor.Location = new Point(266, 75);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(165, 25);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = " ";
            lblAuthor.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.Location = new Point(266, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = " ";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 164);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 5;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 81);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 4;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 125);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 35);
            label3.Name = "label3";
            label3.Size = new Size(34, 19);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label lblCategory;
        private Label lblISBN;
        private Label lblAuthor;
        private Label lblTitle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFindBook;
        private TextBox txtFindBook;
        private Button btnExit;
    }
}
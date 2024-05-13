namespace LMS__FINAL_
{
    partial class Form7
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
            txtShowBooks = new TextBox();
            panel3 = new Panel();
            btnExitForm7 = new Button();
            btnShowStudents = new Button();
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
            panel1.Size = new Size(780, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(252, 33);
            label1.Name = "label1";
            label1.Size = new Size(276, 40);
            label1.TabIndex = 0;
            label1.Text = "All Added Books";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtShowBooks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 360);
            panel2.TabIndex = 1;
            // 
            // txtShowBooks
            // 
            txtShowBooks.Dock = DockStyle.Fill;
            txtShowBooks.Location = new Point(0, 0);
            txtShowBooks.Multiline = true;
            txtShowBooks.Name = "txtShowBooks";
            txtShowBooks.Size = new Size(780, 360);
            txtShowBooks.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExitForm7);
            panel3.Controls.Add(btnShowStudents);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 371);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 79);
            panel3.TabIndex = 2;
            // 
            // btnExitForm7
            // 
            btnExitForm7.BackColor = Color.Red;
            btnExitForm7.Location = new Point(600, 23);
            btnExitForm7.Name = "btnExitForm7";
            btnExitForm7.Size = new Size(94, 44);
            btnExitForm7.TabIndex = 1;
            btnExitForm7.Text = "Exit";
            btnExitForm7.UseVisualStyleBackColor = false;
            btnExitForm7.Click += btnExitForm7_Click;
            // 
            // btnShowStudents
            // 
            btnShowStudents.BackColor = Color.Teal;
            btnShowStudents.Location = new Point(87, 23);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(94, 44);
            btnShowStudents.TabIndex = 0;
            btnShowStudents.Text = "Show";
            btnShowStudents.UseVisualStyleBackColor = false;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox txtShowBooks;
        private Button btnExitForm7;
        private Button btnShowStudents;
    }
}
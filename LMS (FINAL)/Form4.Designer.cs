namespace LMS__FINAL_
{
    partial class Form4
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
            panel2 = new Panel();
            panel3 = new Panel();
            lblSearchForStudent = new Label();
            labFindStudent = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnExitForm4 = new Button();
            btnFindStudent = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSearchForStudent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 72);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFindStudent);
            panel2.Controls.Add(labFindStudent);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 366);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExitForm4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(562, 216);
            panel3.TabIndex = 0;
            // 
            // lblSearchForStudent
            // 
            lblSearchForStudent.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSearchForStudent.Location = new Point(131, 23);
            lblSearchForStudent.Name = "lblSearchForStudent";
            lblSearchForStudent.Size = new Size(275, 36);
            lblSearchForStudent.TabIndex = 0;
            lblSearchForStudent.Text = "Serach For Student";
            lblSearchForStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // labFindStudent
            // 
            labFindStudent.BorderStyle = BorderStyle.FixedSingle;
            labFindStudent.Font = new Font("Segoe UI", 13F);
            labFindStudent.Location = new Point(72, 55);
            labFindStudent.Name = "labFindStudent";
            labFindStudent.Size = new Size(62, 36);
            labFindStudent.TabIndex = 1;
            labFindStudent.Text = "ID";
            labFindStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(91, 54);
            label3.Name = "label3";
            label3.Size = new Size(102, 37);
            label3.TabIndex = 0;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(256, 54);
            label4.Name = "label4";
            label4.Size = new Size(150, 35);
            label4.TabIndex = 1;
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(91, 125);
            label5.Name = "label5";
            label5.Size = new Size(102, 33);
            label5.TabIndex = 2;
            label5.Text = "ID";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(256, 125);
            label6.Name = "label6";
            label6.Size = new Size(150, 33);
            label6.TabIndex = 3;
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExitForm4
            // 
            btnExitForm4.Location = new Point(441, 81);
            btnExitForm4.Name = "btnExitForm4";
            btnExitForm4.Size = new Size(109, 29);
            btnExitForm4.TabIndex = 4;
            btnExitForm4.Text = "Exit";
            btnExitForm4.UseVisualStyleBackColor = true;
            btnExitForm4.Click += btnExitForm4_Click;
            // 
            // btnFindStudent
            // 
            btnFindStudent.Location = new Point(229, 55);
            btnFindStudent.Name = "btnFindStudent";
            btnFindStudent.Size = new Size(112, 36);
            btnFindStudent.TabIndex = 5;
            btnFindStudent.Text = "Find";
            btnFindStudent.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 438);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSearchForStudent;
        private Panel panel2;
        private Label labFindStudent;
        private Panel panel3;
        private Button btnExitForm4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnFindStudent;
    }
}
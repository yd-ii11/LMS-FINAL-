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
            lblSearchForStudent = new Label();
            panel2 = new Panel();
            txtFindStudent = new TextBox();
            btnFindStudent = new Button();
            labFindStudent = new Label();
            panel3 = new Panel();
            btnExitForm4 = new Button();
            lblStudentFindId = new Label();
            label5 = new Label();
            lblStudentFindName = new Label();
            label3 = new Label();
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
            // lblSearchForStudent
            // 
            lblSearchForStudent.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSearchForStudent.Location = new Point(144, 23);
            lblSearchForStudent.Name = "lblSearchForStudent";
            lblSearchForStudent.Size = new Size(275, 36);
            lblSearchForStudent.TabIndex = 0;
            lblSearchForStudent.Text = "Serach For Student";
            lblSearchForStudent.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtFindStudent);
            panel2.Controls.Add(btnFindStudent);
            panel2.Controls.Add(labFindStudent);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 366);
            panel2.TabIndex = 1;
            // 
            // txtFindStudent
            // 
            txtFindStudent.Cursor = Cursors.Hand;
            txtFindStudent.Font = new Font("Segoe UI", 13F);
            txtFindStudent.Location = new Point(211, 55);
            txtFindStudent.Name = "txtFindStudent";
            txtFindStudent.Size = new Size(148, 36);
            txtFindStudent.TabIndex = 8;
            // 
            // btnFindStudent
            // 
            btnFindStudent.Cursor = Cursors.Hand;
            btnFindStudent.Location = new Point(436, 55);
            btnFindStudent.Name = "btnFindStudent";
            btnFindStudent.Size = new Size(112, 36);
            btnFindStudent.TabIndex = 5;
            btnFindStudent.Text = "Find";
            btnFindStudent.UseVisualStyleBackColor = true;
            btnFindStudent.Click += btnFindStudent_Click;
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
            // panel3
            // 
            panel3.Controls.Add(btnExitForm4);
            panel3.Controls.Add(lblStudentFindId);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblStudentFindName);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(562, 216);
            panel3.TabIndex = 0;
            // 
            // btnExitForm4
            // 
            btnExitForm4.BackColor = Color.Red;
            btnExitForm4.Cursor = Cursors.Hand;
            btnExitForm4.Location = new Point(441, 81);
            btnExitForm4.Name = "btnExitForm4";
            btnExitForm4.Size = new Size(109, 29);
            btnExitForm4.TabIndex = 4;
            btnExitForm4.Text = "Exit";
            btnExitForm4.UseVisualStyleBackColor = false;
            btnExitForm4.Click += btnExitForm4_Click;
            // 
            // lblStudentFindId
            // 
            lblStudentFindId.BorderStyle = BorderStyle.FixedSingle;
            lblStudentFindId.Font = new Font("Segoe UI", 13F);
            lblStudentFindId.Location = new Point(256, 125);
            lblStudentFindId.Name = "lblStudentFindId";
            lblStudentFindId.Size = new Size(150, 33);
            lblStudentFindId.TabIndex = 3;
            lblStudentFindId.TextAlign = ContentAlignment.TopCenter;
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
            // lblStudentFindName
            // 
            lblStudentFindName.BorderStyle = BorderStyle.FixedSingle;
            lblStudentFindName.Font = new Font("Segoe UI", 13F);
            lblStudentFindName.Location = new Point(256, 54);
            lblStudentFindName.Name = "lblStudentFindName";
            lblStudentFindName.Size = new Size(150, 35);
            lblStudentFindName.TabIndex = 1;
            lblStudentFindName.TextAlign = ContentAlignment.TopCenter;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 438);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label lblStudentFindId;
        private Label label5;
        private Label lblStudentFindName;
        private Label label3;
        private Button btnFindStudent;
        private TextBox txtFindStudent;
    }
}
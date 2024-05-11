namespace LMS__FINAL_
{
    partial class Form2
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
            txtId = new TextBox();
            txtName = new TextBox();
            btnAddNewStudent = new Button();
            btnShowAllStudent = new Button();
            btnExitForm2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(271, 18);
            label1.Name = "label1";
            label1.Size = new Size(258, 57);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(120, 115);
            label2.Name = "label2";
            label2.Size = new Size(43, 37);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(120, 162);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(271, 118);
            txtId.Name = "txtId";
            txtId.Size = new Size(258, 34);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(271, 165);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 34);
            txtName.TabIndex = 5;
            // 
            // btnAddNewStudent
            // 
            btnAddNewStudent.BackColor = SystemColors.ActiveCaption;
            btnAddNewStudent.Cursor = Cursors.Hand;
            btnAddNewStudent.Font = new Font("Segoe UI", 11F);
            btnAddNewStudent.ForeColor = SystemColors.ButtonHighlight;
            btnAddNewStudent.Location = new Point(212, 284);
            btnAddNewStudent.Name = "btnAddNewStudent";
            btnAddNewStudent.Size = new Size(150, 50);
            btnAddNewStudent.TabIndex = 7;
            btnAddNewStudent.Text = "Add New";
            btnAddNewStudent.UseVisualStyleBackColor = false;
            btnAddNewStudent.Click += btnAddNewStudent_Click;
            // 
            // btnShowAllStudent
            // 
            btnShowAllStudent.BackColor = SystemColors.ActiveCaption;
            btnShowAllStudent.Cursor = Cursors.Hand;
            btnShowAllStudent.Font = new Font("Segoe UI", 11F);
            btnShowAllStudent.ForeColor = SystemColors.ButtonHighlight;
            btnShowAllStudent.Location = new Point(438, 284);
            btnShowAllStudent.Name = "btnShowAllStudent";
            btnShowAllStudent.Size = new Size(150, 50);
            btnShowAllStudent.TabIndex = 8;
            btnShowAllStudent.Text = "Show ALL";
            btnShowAllStudent.UseVisualStyleBackColor = false;
            btnShowAllStudent.Click += btnShowAllStudent_Click;
            // 
            // btnExitForm2
            // 
            btnExitForm2.BackColor = SystemColors.ActiveCaption;
            btnExitForm2.Cursor = Cursors.Hand;
            btnExitForm2.Font = new Font("Segoe UI", 11F);
            btnExitForm2.ForeColor = SystemColors.ButtonHighlight;
            btnExitForm2.Location = new Point(325, 391);
            btnExitForm2.Name = "btnExitForm2";
            btnExitForm2.Size = new Size(150, 50);
            btnExitForm2.TabIndex = 9;
            btnExitForm2.Text = "Exit";
            btnExitForm2.UseVisualStyleBackColor = false;
            btnExitForm2.Click += btnExitForm2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExitForm2);
            Controls.Add(btnShowAllStudent);
            Controls.Add(btnAddNewStudent);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private Button btnAddNewStudent;
        private Button btnShowAllStudent;
        private Button btnExitForm2;
    }
}
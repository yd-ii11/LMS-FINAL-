﻿namespace LMS__FINAL_
{
    partial class Form6
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            txtShowStudent = new TextBox();
            panel3 = new Panel();
            btnExitForm6 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 83);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(236, 19);
            label1.Name = "label1";
            label1.Size = new Size(308, 47);
            label1.TabIndex = 1;
            label1.Text = "All Added Students";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtShowStudent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 367);
            panel1.TabIndex = 3;
            // 
            // txtShowStudent
            // 
            txtShowStudent.Dock = DockStyle.Fill;
            txtShowStudent.Font = new Font("Segoe UI", 12F);
            txtShowStudent.Location = new Point(0, 0);
            txtShowStudent.Multiline = true;
            txtShowStudent.Name = "txtShowStudent";
            txtShowStudent.Size = new Size(780, 367);
            txtShowStudent.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExitForm6);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(780, 100);
            panel3.TabIndex = 4;
            // 
            // btnExitForm6
            // 
            btnExitForm6.BackColor = Color.Red;
            btnExitForm6.Cursor = Cursors.Hand;
            btnExitForm6.Location = new Point(584, 21);
            btnExitForm6.Name = "btnExitForm6";
            btnExitForm6.Size = new Size(101, 51);
            btnExitForm6.TabIndex = 1;
            btnExitForm6.Text = "Exit";
            btnExitForm6.UseVisualStyleBackColor = false;
            btnExitForm6.Click += btnExitForm6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(96, 21);
            button1.Name = "button1";
            button1.Size = new Size(112, 51);
            button1.TabIndex = 0;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TextBox txtShowStudent;
        private Panel panel3;
        private Button btnExitForm6;
        private Button button1;
    }
}
namespace MidDb26_2024CS49
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.displayStudents = new System.Windows.Forms.DataGridView();
            this.updateStudentBtn = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(208, 77);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(141, 26);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Registration No.";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(477, 77);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(134, 26);
            this.txtLastname.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(208, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtRegno
            // 
            this.txtRegno.Location = new System.Drawing.Point(477, 154);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.Size = new System.Drawing.Size(134, 26);
            this.txtRegno.TabIndex = 7;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(96, 302);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(147, 36);
            this.addStudentBtn.TabIndex = 9;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Location = new System.Drawing.Point(431, 302);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(147, 36);
            this.deleteStudentBtn.TabIndex = 10;
            this.deleteStudentBtn.Text = "Delete Student";
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.deleteStudentBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(598, 302);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(147, 36);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // displayStudents
            // 
            this.displayStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayStudents.Location = new System.Drawing.Point(54, 365);
            this.displayStudents.Name = "displayStudents";
            this.displayStudents.ReadOnly = true;
            this.displayStudents.RowHeadersWidth = 62;
            this.displayStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayStudents.RowTemplate.Height = 28;
            this.displayStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayStudents.Size = new System.Drawing.Size(722, 198);
            this.displayStudents.TabIndex = 12;
            this.displayStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayStudents_CellClick);
            this.displayStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayStudents_CellContentClick);
            // 
            // updateStudentBtn
            // 
            this.updateStudentBtn.Location = new System.Drawing.Point(265, 302);
            this.updateStudentBtn.Name = "updateStudentBtn";
            this.updateStudentBtn.Size = new System.Drawing.Size(146, 36);
            this.updateStudentBtn.TabIndex = 13;
            this.updateStudentBtn.Text = "Update Student";
            this.updateStudentBtn.UseVisualStyleBackColor = true;
            this.updateStudentBtn.Click += new System.EventHandler(this.updateStudentBtn_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(353, 239);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 28);
            this.cmbGender.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Gender:";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.updateStudentBtn);
            this.Controls.Add(this.displayStudents);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.txtRegno);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRegno;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView displayStudents;
        private System.Windows.Forms.Button updateStudentBtn;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
    }
}
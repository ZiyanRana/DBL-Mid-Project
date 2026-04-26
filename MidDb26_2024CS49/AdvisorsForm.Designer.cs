namespace MidDb26_2024CS49
{
    partial class AdvisorsForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.addAdvisorBtn = new System.Windows.Forms.Button();
            this.updateAdvisorBtn = new System.Windows.Forms.Button();
            this.deleteAdvisorBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.displayAdvisors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayAdvisors)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(60, 118);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(210, 118);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(127, 26);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(359, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(676, 118);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(127, 26);
            this.txtSalary.TabIndex = 3;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(514, 118);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(138, 28);
            this.cmbDesignation.TabIndex = 4;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // addAdvisorBtn
            // 
            this.addAdvisorBtn.Location = new System.Drawing.Point(233, 202);
            this.addAdvisorBtn.Name = "addAdvisorBtn";
            this.addAdvisorBtn.Size = new System.Drawing.Size(156, 34);
            this.addAdvisorBtn.TabIndex = 5;
            this.addAdvisorBtn.Text = "Add Advisor";
            this.addAdvisorBtn.UseVisualStyleBackColor = true;
            this.addAdvisorBtn.Click += new System.EventHandler(this.addAdvisorBtn_Click);
            // 
            // updateAdvisorBtn
            // 
            this.updateAdvisorBtn.Location = new System.Drawing.Point(465, 202);
            this.updateAdvisorBtn.Name = "updateAdvisorBtn";
            this.updateAdvisorBtn.Size = new System.Drawing.Size(156, 34);
            this.updateAdvisorBtn.TabIndex = 6;
            this.updateAdvisorBtn.Text = "Update Advisor";
            this.updateAdvisorBtn.UseVisualStyleBackColor = true;
            this.updateAdvisorBtn.Click += new System.EventHandler(this.updateAdvisorBtn_Click);
            // 
            // deleteAdvisorBtn
            // 
            this.deleteAdvisorBtn.Location = new System.Drawing.Point(233, 258);
            this.deleteAdvisorBtn.Name = "deleteAdvisorBtn";
            this.deleteAdvisorBtn.Size = new System.Drawing.Size(156, 34);
            this.deleteAdvisorBtn.TabIndex = 7;
            this.deleteAdvisorBtn.Text = "Delete Advisor";
            this.deleteAdvisorBtn.UseVisualStyleBackColor = true;
            this.deleteAdvisorBtn.Click += new System.EventHandler(this.deleteAdvisorBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(465, 258);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(156, 34);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // displayAdvisors
            // 
            this.displayAdvisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAdvisors.Location = new System.Drawing.Point(119, 316);
            this.displayAdvisors.Name = "displayAdvisors";
            this.displayAdvisors.ReadOnly = true;
            this.displayAdvisors.RowHeadersWidth = 62;
            this.displayAdvisors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayAdvisors.RowTemplate.Height = 28;
            this.displayAdvisors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayAdvisors.Size = new System.Drawing.Size(586, 150);
            this.displayAdvisors.TabIndex = 9;
            this.displayAdvisors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayAdvisors_CellClick);
            this.displayAdvisors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayAdvisors_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Designation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Salary:";
            // 
            // AdvisorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayAdvisors);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteAdvisorBtn);
            this.Controls.Add(this.updateAdvisorBtn);
            this.Controls.Add(this.addAdvisorBtn);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "AdvisorsForm";
            this.Text = "Manage Advisors";
            this.Load += new System.EventHandler(this.AdvisorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAdvisors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button addAdvisorBtn;
        private System.Windows.Forms.Button updateAdvisorBtn;
        private System.Windows.Forms.Button deleteAdvisorBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView displayAdvisors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
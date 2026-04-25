namespace MidDb26_2024CS49
{
    partial class ProjectAdvisorsForm
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
            this.cmbAdvisors = new System.Windows.Forms.ComboBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.assignAdvisorBtn = new System.Windows.Forms.Button();
            this.displayAssignments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.removeAdvisorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAdvisors
            // 
            this.cmbAdvisors.FormattingEnabled = true;
            this.cmbAdvisors.Location = new System.Drawing.Point(295, 73);
            this.cmbAdvisors.Name = "cmbAdvisors";
            this.cmbAdvisors.Size = new System.Drawing.Size(131, 28);
            this.cmbAdvisors.TabIndex = 0;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(468, 73);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(127, 28);
            this.cmbRoles.TabIndex = 1;
            // 
            // assignAdvisorBtn
            // 
            this.assignAdvisorBtn.Location = new System.Drawing.Point(213, 176);
            this.assignAdvisorBtn.Name = "assignAdvisorBtn";
            this.assignAdvisorBtn.Size = new System.Drawing.Size(149, 39);
            this.assignAdvisorBtn.TabIndex = 2;
            this.assignAdvisorBtn.Text = "Assign Advisor";
            this.assignAdvisorBtn.UseVisualStyleBackColor = true;
            this.assignAdvisorBtn.Click += new System.EventHandler(this.assignAdvisorBtn_Click);
            // 
            // displayAssignments
            // 
            this.displayAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAssignments.Location = new System.Drawing.Point(130, 247);
            this.displayAssignments.Name = "displayAssignments";
            this.displayAssignments.ReadOnly = true;
            this.displayAssignments.RowHeadersWidth = 62;
            this.displayAssignments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayAssignments.RowTemplate.Height = 28;
            this.displayAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayAssignments.Size = new System.Drawing.Size(465, 150);
            this.displayAssignments.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Advisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Role";
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(126, 73);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(129, 28);
            this.cmbProjects.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Project";
            // 
            // removeAdvisorBtn
            // 
            this.removeAdvisorBtn.Location = new System.Drawing.Point(388, 176);
            this.removeAdvisorBtn.Name = "removeAdvisorBtn";
            this.removeAdvisorBtn.Size = new System.Drawing.Size(148, 39);
            this.removeAdvisorBtn.TabIndex = 8;
            this.removeAdvisorBtn.Text = "Remove Advisor";
            this.removeAdvisorBtn.UseVisualStyleBackColor = true;
            this.removeAdvisorBtn.Click += new System.EventHandler(this.removeAdvisorBtn_Click);
            // 
            // ProjectAdvisorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.removeAdvisorBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayAssignments);
            this.Controls.Add(this.assignAdvisorBtn);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.cmbAdvisors);
            this.Name = "ProjectAdvisorsForm";
            this.Text = "Assign Advisors to Projects";
            this.Load += new System.EventHandler(this.ProjectAdvisorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAdvisors;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button assignAdvisorBtn;
        private System.Windows.Forms.DataGridView displayAssignments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeAdvisorBtn;
    }
}
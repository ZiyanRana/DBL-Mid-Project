namespace MidDb26_2024CS49
{
    partial class GroupProjectsForm
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
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.assignBtn = new System.Windows.Forms.Button();
            this.displayAssignments = new System.Windows.Forms.DataGridView();
            this.removeAssignmentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(196, 92);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(158, 28);
            this.cmbGroups.TabIndex = 0;
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(406, 92);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(158, 28);
            this.cmbProjects.TabIndex = 1;
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(196, 183);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(173, 45);
            this.assignBtn.TabIndex = 2;
            this.assignBtn.Text = "Assign Project";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // displayAssignments
            // 
            this.displayAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAssignments.Location = new System.Drawing.Point(163, 248);
            this.displayAssignments.Name = "displayAssignments";
            this.displayAssignments.ReadOnly = true;
            this.displayAssignments.RowHeadersWidth = 62;
            this.displayAssignments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayAssignments.RowTemplate.Height = 28;
            this.displayAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayAssignments.Size = new System.Drawing.Size(449, 150);
            this.displayAssignments.TabIndex = 3;
            // 
            // removeAssignmentBtn
            // 
            this.removeAssignmentBtn.Location = new System.Drawing.Point(382, 183);
            this.removeAssignmentBtn.Name = "removeAssignmentBtn";
            this.removeAssignmentBtn.Size = new System.Drawing.Size(182, 45);
            this.removeAssignmentBtn.TabIndex = 4;
            this.removeAssignmentBtn.Text = "Remove Assignment";
            this.removeAssignmentBtn.UseVisualStyleBackColor = true;
            this.removeAssignmentBtn.Click += new System.EventHandler(this.removeAssignmentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Project:";
            // 
            // GroupProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAssignmentBtn);
            this.Controls.Add(this.displayAssignments);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.cmbGroups);
            this.Name = "GroupProjectsForm";
            this.Text = "Assign Projects to Groups";
            this.Load += new System.EventHandler(this.GroupProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.DataGridView displayAssignments;
        private System.Windows.Forms.Button removeAssignmentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
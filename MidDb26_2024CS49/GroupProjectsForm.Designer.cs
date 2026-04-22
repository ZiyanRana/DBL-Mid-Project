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
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(166, 46);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(158, 28);
            this.cmbGroups.TabIndex = 0;
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(166, 98);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(158, 28);
            this.cmbProjects.TabIndex = 1;
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(166, 161);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(158, 40);
            this.assignBtn.TabIndex = 2;
            this.assignBtn.Text = "Assign Project";
            this.assignBtn.UseVisualStyleBackColor = true;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // displayAssignments
            // 
            this.displayAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayAssignments.Location = new System.Drawing.Point(166, 248);
            this.displayAssignments.Name = "displayAssignments";
            this.displayAssignments.ReadOnly = true;
            this.displayAssignments.RowHeadersWidth = 62;
            this.displayAssignments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayAssignments.RowTemplate.Height = 28;
            this.displayAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayAssignments.Size = new System.Drawing.Size(449, 150);
            this.displayAssignments.TabIndex = 3;
            // 
            // GroupProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayAssignments);
            this.Controls.Add(this.assignBtn);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.cmbGroups);
            this.Name = "GroupProjectsForm";
            this.Text = "Assign Projects to Groups";
            this.Load += new System.EventHandler(this.GroupProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.DataGridView displayAssignments;
    }
}
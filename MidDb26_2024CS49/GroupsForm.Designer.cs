namespace MidDb26_2024CS49
{
    partial class GroupsForm
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
            this.createGroupBtn = new System.Windows.Forms.Button();
            this.displayGroups = new System.Windows.Forms.DataGridView();
            this.displayGroupMembers = new System.Windows.Forms.DataGridView();
            this.addStudentsBtn = new System.Windows.Forms.Button();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGroupMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // createGroupBtn
            // 
            this.createGroupBtn.Location = new System.Drawing.Point(100, 31);
            this.createGroupBtn.Name = "createGroupBtn";
            this.createGroupBtn.Size = new System.Drawing.Size(169, 38);
            this.createGroupBtn.TabIndex = 0;
            this.createGroupBtn.Text = "Create Group";
            this.createGroupBtn.UseVisualStyleBackColor = true;
            this.createGroupBtn.Click += new System.EventHandler(this.createGroupBtn_Click);
            // 
            // displayGroups
            // 
            this.displayGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGroups.Location = new System.Drawing.Point(100, 75);
            this.displayGroups.Name = "displayGroups";
            this.displayGroups.ReadOnly = true;
            this.displayGroups.RowHeadersWidth = 62;
            this.displayGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayGroups.RowTemplate.Height = 28;
            this.displayGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayGroups.Size = new System.Drawing.Size(564, 150);
            this.displayGroups.TabIndex = 1;
            this.displayGroups.UseWaitCursor = true;
            this.displayGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayGroups_CellClick);
            this.displayGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayGroups_CellContentClick);
            // 
            // displayGroupMembers
            // 
            this.displayGroupMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGroupMembers.Location = new System.Drawing.Point(100, 303);
            this.displayGroupMembers.Name = "displayGroupMembers";
            this.displayGroupMembers.ReadOnly = true;
            this.displayGroupMembers.RowHeadersWidth = 62;
            this.displayGroupMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayGroupMembers.RowTemplate.Height = 28;
            this.displayGroupMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayGroupMembers.Size = new System.Drawing.Size(564, 150);
            this.displayGroupMembers.TabIndex = 2;
            this.displayGroupMembers.UseWaitCursor = true;
            // 
            // addStudentsBtn
            // 
            this.addStudentsBtn.Location = new System.Drawing.Point(100, 259);
            this.addStudentsBtn.Name = "addStudentsBtn";
            this.addStudentsBtn.Size = new System.Drawing.Size(168, 38);
            this.addStudentsBtn.TabIndex = 3;
            this.addStudentsBtn.Text = "Add Students";
            this.addStudentsBtn.UseVisualStyleBackColor = true;
            this.addStudentsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(274, 269);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(134, 28);
            this.cmbStudents.TabIndex = 4;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 483);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.addStudentsBtn);
            this.Controls.Add(this.displayGroupMembers);
            this.Controls.Add(this.displayGroups);
            this.Controls.Add(this.createGroupBtn);
            this.Name = "GroupsForm";
            this.Text = "Manage Groups";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGroupMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createGroupBtn;
        private System.Windows.Forms.DataGridView displayGroups;
        private System.Windows.Forms.DataGridView displayGroupMembers;
        private System.Windows.Forms.Button addStudentsBtn;
        private System.Windows.Forms.ComboBox cmbStudents;
    }
}
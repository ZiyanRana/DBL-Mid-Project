namespace MidDb26_2024CS49
{
    partial class GroupMarkingForm
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
            this.cmbEvals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assignMarksBtn = new System.Windows.Forms.Button();
            this.updateMarksBtn = new System.Windows.Forms.Button();
            this.deleteMarksBtn = new System.Windows.Forms.Button();
            this.displayMarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroups
            // 
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(121, 92);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(121, 28);
            this.cmbGroups.TabIndex = 0;
            // 
            // cmbEvals
            // 
            this.cmbEvals.FormattingEnabled = true;
            this.cmbEvals.Location = new System.Drawing.Point(331, 91);
            this.cmbEvals.Name = "cmbEvals";
            this.cmbEvals.Size = new System.Drawing.Size(127, 28);
            this.cmbEvals.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Evaluation:";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(551, 93);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(125, 26);
            this.txtMarks.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obtained Marks:";
            // 
            // assignMarksBtn
            // 
            this.assignMarksBtn.Location = new System.Drawing.Point(121, 172);
            this.assignMarksBtn.Name = "assignMarksBtn";
            this.assignMarksBtn.Size = new System.Drawing.Size(156, 44);
            this.assignMarksBtn.TabIndex = 6;
            this.assignMarksBtn.Text = "Assign Marks";
            this.assignMarksBtn.UseVisualStyleBackColor = true;
            this.assignMarksBtn.Click += new System.EventHandler(this.assignMarksBtn_Click);
            // 
            // updateMarksBtn
            // 
            this.updateMarksBtn.Location = new System.Drawing.Point(320, 172);
            this.updateMarksBtn.Name = "updateMarksBtn";
            this.updateMarksBtn.Size = new System.Drawing.Size(156, 44);
            this.updateMarksBtn.TabIndex = 7;
            this.updateMarksBtn.Text = "Update Marks";
            this.updateMarksBtn.UseVisualStyleBackColor = true;
            this.updateMarksBtn.Click += new System.EventHandler(this.updateMarksBtn_Click);
            // 
            // deleteMarksBtn
            // 
            this.deleteMarksBtn.Location = new System.Drawing.Point(520, 172);
            this.deleteMarksBtn.Name = "deleteMarksBtn";
            this.deleteMarksBtn.Size = new System.Drawing.Size(156, 44);
            this.deleteMarksBtn.TabIndex = 8;
            this.deleteMarksBtn.Text = "Delete Marking";
            this.deleteMarksBtn.UseVisualStyleBackColor = true;
            this.deleteMarksBtn.Click += new System.EventHandler(this.deleteMarksBtn_Click);
            // 
            // displayMarks
            // 
            this.displayMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayMarks.Location = new System.Drawing.Point(184, 274);
            this.displayMarks.Name = "displayMarks";
            this.displayMarks.RowHeadersWidth = 62;
            this.displayMarks.RowTemplate.Height = 28;
            this.displayMarks.Size = new System.Drawing.Size(438, 150);
            this.displayMarks.TabIndex = 9;
            // 
            // GroupMarkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayMarks);
            this.Controls.Add(this.deleteMarksBtn);
            this.Controls.Add(this.updateMarksBtn);
            this.Controls.Add(this.assignMarksBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEvals);
            this.Controls.Add(this.cmbGroups);
            this.Name = "GroupMarkingForm";
            this.Text = "Assign Marks to Groups";
            this.Load += new System.EventHandler(this.GroupMarkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.ComboBox cmbEvals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button assignMarksBtn;
        private System.Windows.Forms.Button updateMarksBtn;
        private System.Windows.Forms.Button deleteMarksBtn;
        private System.Windows.Forms.DataGridView displayMarks;
    }
}
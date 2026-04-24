namespace MidDb26_2024CS49
{
    partial class ReportsForm
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
            this.projectReportBtn = new System.Windows.Forms.Button();
            this.marksheetReportBtn = new System.Windows.Forms.Button();
            this.displayReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayReports)).BeginInit();
            this.SuspendLayout();
            // 
            // projectReportBtn
            // 
            this.projectReportBtn.Location = new System.Drawing.Point(163, 107);
            this.projectReportBtn.Name = "projectReportBtn";
            this.projectReportBtn.Size = new System.Drawing.Size(193, 47);
            this.projectReportBtn.TabIndex = 0;
            this.projectReportBtn.Text = "Project Report";
            this.projectReportBtn.UseVisualStyleBackColor = true;
            this.projectReportBtn.Click += new System.EventHandler(this.projectReportBtn_Click);
            // 
            // marksheetReportBtn
            // 
            this.marksheetReportBtn.Location = new System.Drawing.Point(443, 107);
            this.marksheetReportBtn.Name = "marksheetReportBtn";
            this.marksheetReportBtn.Size = new System.Drawing.Size(193, 47);
            this.marksheetReportBtn.TabIndex = 1;
            this.marksheetReportBtn.Text = "Marksheet Report";
            this.marksheetReportBtn.UseVisualStyleBackColor = true;
            this.marksheetReportBtn.Click += new System.EventHandler(this.marksheetReportBtn_Click);
            // 
            // displayReports
            // 
            this.displayReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayReports.Location = new System.Drawing.Point(163, 225);
            this.displayReports.Name = "displayReports";
            this.displayReports.RowHeadersWidth = 62;
            this.displayReports.RowTemplate.Height = 28;
            this.displayReports.Size = new System.Drawing.Size(473, 150);
            this.displayReports.TabIndex = 2;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayReports);
            this.Controls.Add(this.marksheetReportBtn);
            this.Controls.Add(this.projectReportBtn);
            this.Name = "ReportsForm";
            this.Text = "View Reports";
            ((System.ComponentModel.ISupportInitialize)(this.displayReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button projectReportBtn;
        private System.Windows.Forms.Button marksheetReportBtn;
        private System.Windows.Forms.DataGridView displayReports;
    }
}
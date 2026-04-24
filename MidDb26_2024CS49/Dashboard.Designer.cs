namespace MidDb26_2024CS49
{
    partial class Dashboard
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
            this.studentsBtn = new System.Windows.Forms.Button();
            this.advisorsBtn = new System.Windows.Forms.Button();
            this.projectsBtn = new System.Windows.Forms.Button();
            this.groupsBtn = new System.Windows.Forms.Button();
            this.evaluationsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.assignProjectsBtn = new System.Windows.Forms.Button();
            this.assignAdvisorsBtn = new System.Windows.Forms.Button();
            this.assignMarksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(199, 79);
            this.studentsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(253, 91);
            this.studentsBtn.TabIndex = 0;
            this.studentsBtn.Text = "Manage Students";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // advisorsBtn
            // 
            this.advisorsBtn.Location = new System.Drawing.Point(496, 79);
            this.advisorsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.advisorsBtn.Name = "advisorsBtn";
            this.advisorsBtn.Size = new System.Drawing.Size(253, 91);
            this.advisorsBtn.TabIndex = 1;
            this.advisorsBtn.Text = "Manage Advisors";
            this.advisorsBtn.UseVisualStyleBackColor = true;
            this.advisorsBtn.Click += new System.EventHandler(this.advisorsBtn_Click);
            // 
            // projectsBtn
            // 
            this.projectsBtn.Location = new System.Drawing.Point(199, 195);
            this.projectsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Size = new System.Drawing.Size(253, 91);
            this.projectsBtn.TabIndex = 2;
            this.projectsBtn.Text = "Projects";
            this.projectsBtn.UseVisualStyleBackColor = true;
            this.projectsBtn.Click += new System.EventHandler(this.projectsBtn_Click);
            // 
            // groupsBtn
            // 
            this.groupsBtn.Location = new System.Drawing.Point(496, 195);
            this.groupsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Size = new System.Drawing.Size(253, 91);
            this.groupsBtn.TabIndex = 3;
            this.groupsBtn.Text = "Groups";
            this.groupsBtn.UseVisualStyleBackColor = true;
            this.groupsBtn.Click += new System.EventHandler(this.groupsBtn_Click);
            // 
            // evaluationsBtn
            // 
            this.evaluationsBtn.Location = new System.Drawing.Point(199, 418);
            this.evaluationsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.evaluationsBtn.Name = "evaluationsBtn";
            this.evaluationsBtn.Size = new System.Drawing.Size(253, 91);
            this.evaluationsBtn.TabIndex = 4;
            this.evaluationsBtn.Text = "Evaluations";
            this.evaluationsBtn.UseVisualStyleBackColor = true;
            this.evaluationsBtn.Click += new System.EventHandler(this.evaluationsBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(344, 540);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(253, 91);
            this.reportsBtn.TabIndex = 5;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            // 
            // assignProjectsBtn
            // 
            this.assignProjectsBtn.Location = new System.Drawing.Point(199, 304);
            this.assignProjectsBtn.Name = "assignProjectsBtn";
            this.assignProjectsBtn.Size = new System.Drawing.Size(253, 91);
            this.assignProjectsBtn.TabIndex = 6;
            this.assignProjectsBtn.Text = "Assign Projects";
            this.assignProjectsBtn.UseVisualStyleBackColor = true;
            this.assignProjectsBtn.Click += new System.EventHandler(this.assignProjectsBtn_Click);
            // 
            // assignAdvisorsBtn
            // 
            this.assignAdvisorsBtn.Location = new System.Drawing.Point(496, 304);
            this.assignAdvisorsBtn.Name = "assignAdvisorsBtn";
            this.assignAdvisorsBtn.Size = new System.Drawing.Size(253, 91);
            this.assignAdvisorsBtn.TabIndex = 7;
            this.assignAdvisorsBtn.Text = "Assign Advisors";
            this.assignAdvisorsBtn.UseVisualStyleBackColor = true;
            this.assignAdvisorsBtn.Click += new System.EventHandler(this.assignAdvisorsBtn_Click);
            // 
            // assignMarksBtn
            // 
            this.assignMarksBtn.Location = new System.Drawing.Point(496, 418);
            this.assignMarksBtn.Name = "assignMarksBtn";
            this.assignMarksBtn.Size = new System.Drawing.Size(253, 91);
            this.assignMarksBtn.TabIndex = 8;
            this.assignMarksBtn.Text = "Assign Marks";
            this.assignMarksBtn.UseVisualStyleBackColor = true;
            this.assignMarksBtn.Click += new System.EventHandler(this.assignMarksBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 655);
            this.Controls.Add(this.assignMarksBtn);
            this.Controls.Add(this.assignAdvisorsBtn);
            this.Controls.Add(this.assignProjectsBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.evaluationsBtn);
            this.Controls.Add(this.groupsBtn);
            this.Controls.Add(this.projectsBtn);
            this.Controls.Add(this.advisorsBtn);
            this.Controls.Add(this.studentsBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dashboard";
            this.Text = "FYP Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button advisorsBtn;
        private System.Windows.Forms.Button projectsBtn;
        private System.Windows.Forms.Button groupsBtn;
        private System.Windows.Forms.Button evaluationsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button assignProjectsBtn;
        private System.Windows.Forms.Button assignAdvisorsBtn;
        private System.Windows.Forms.Button assignMarksBtn;
    }
}
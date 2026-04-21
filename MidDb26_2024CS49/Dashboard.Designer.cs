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
            // 
            // evaluationsBtn
            // 
            this.evaluationsBtn.Location = new System.Drawing.Point(199, 314);
            this.evaluationsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.evaluationsBtn.Name = "evaluationsBtn";
            this.evaluationsBtn.Size = new System.Drawing.Size(253, 91);
            this.evaluationsBtn.TabIndex = 4;
            this.evaluationsBtn.Text = "Evaluations";
            this.evaluationsBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(496, 314);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(253, 91);
            this.reportsBtn.TabIndex = 5;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 440);
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
    }
}


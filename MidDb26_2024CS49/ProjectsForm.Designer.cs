namespace MidDb26_2024CS49
{
    partial class ProjectsForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.displayProjects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(257, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(278, 26);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Location = new System.Drawing.Point(257, 148);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 99);
            this.txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update Project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete Project";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // displayProjects
            // 
            this.displayProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayProjects.Location = new System.Drawing.Point(116, 385);
            this.displayProjects.Name = "displayProjects";
            this.displayProjects.ReadOnly = true;
            this.displayProjects.RowHeadersWidth = 62;
            this.displayProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayProjects.RowTemplate.Height = 28;
            this.displayProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayProjects.Size = new System.Drawing.Size(549, 150);
            this.displayProjects.TabIndex = 8;
            this.displayProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayProjects_CellClick);
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.displayProjects);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Name = "ProjectsForm";
            this.Text = "Manage Projects";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView displayProjects;
    }
}
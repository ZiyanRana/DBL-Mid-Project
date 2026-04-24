namespace MidDb26_2024CS49
{
    partial class EvaluationsForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtWeightage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEvalBtn = new System.Windows.Forms.Button();
            this.updateEvalBtn = new System.Windows.Forms.Button();
            this.delEvalBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.displayEvaluations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.displayEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(340, 57);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 26);
            this.txtMarks.TabIndex = 1;
            // 
            // txtWeightage
            // 
            this.txtWeightage.Location = new System.Drawing.Point(551, 57);
            this.txtWeightage.Name = "txtWeightage";
            this.txtWeightage.Size = new System.Drawing.Size(100, 26);
            this.txtWeightage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Evaluation Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Marks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Weightage:";
            // 
            // addEvalBtn
            // 
            this.addEvalBtn.Location = new System.Drawing.Point(205, 133);
            this.addEvalBtn.Name = "addEvalBtn";
            this.addEvalBtn.Size = new System.Drawing.Size(159, 47);
            this.addEvalBtn.TabIndex = 6;
            this.addEvalBtn.Text = "Add Evaluation";
            this.addEvalBtn.UseVisualStyleBackColor = true;
            this.addEvalBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateEvalBtn
            // 
            this.updateEvalBtn.Location = new System.Drawing.Point(417, 133);
            this.updateEvalBtn.Name = "updateEvalBtn";
            this.updateEvalBtn.Size = new System.Drawing.Size(159, 47);
            this.updateEvalBtn.TabIndex = 7;
            this.updateEvalBtn.Text = "Update Evaluation";
            this.updateEvalBtn.UseVisualStyleBackColor = true;
            this.updateEvalBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // delEvalBtn
            // 
            this.delEvalBtn.Location = new System.Drawing.Point(205, 198);
            this.delEvalBtn.Name = "delEvalBtn";
            this.delEvalBtn.Size = new System.Drawing.Size(159, 47);
            this.delEvalBtn.TabIndex = 8;
            this.delEvalBtn.Text = "Delete Evaluation";
            this.delEvalBtn.UseVisualStyleBackColor = true;
            this.delEvalBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(417, 198);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(159, 47);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // displayEvaluations
            // 
            this.displayEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayEvaluations.Location = new System.Drawing.Point(136, 288);
            this.displayEvaluations.Name = "displayEvaluations";
            this.displayEvaluations.RowHeadersWidth = 62;
            this.displayEvaluations.RowTemplate.Height = 28;
            this.displayEvaluations.Size = new System.Drawing.Size(505, 150);
            this.displayEvaluations.TabIndex = 10;
            this.displayEvaluations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayEvaluations_CellClick);
            // 
            // EvaluationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayEvaluations);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.delEvalBtn);
            this.Controls.Add(this.updateEvalBtn);
            this.Controls.Add(this.addEvalBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeightage);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtName);
            this.Name = "EvaluationsForm";
            this.Text = "Manage Evaluations";
            this.Load += new System.EventHandler(this.EvaluationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayEvaluations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtWeightage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEvalBtn;
        private System.Windows.Forms.Button updateEvalBtn;
        private System.Windows.Forms.Button delEvalBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView displayEvaluations;
    }
}
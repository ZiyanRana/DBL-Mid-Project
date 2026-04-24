using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MidDb26_2024CS49
{
    public partial class EvaluationsForm : Form
    {
        DBHelper db = new DBHelper();
        public EvaluationsForm()
        {
            InitializeComponent();
        }

        void LoadEvaluations()
        {
            string query = "SELECT * FROM evaluation";
            displayEvaluations.DataSource = db.GetData(query);
        }

        void ClearFields()
        {
            txtName.Text = "";
            txtMarks.Text = "";
            txtWeightage.Text = "";
        }

        private void EvaluationsForm_Load(object sender, EventArgs e)
        {
            LoadEvaluations();
        }

        private void displayEvaluations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = displayEvaluations.Rows[e.RowIndex];

                txtName.Text =
                    row.Cells["Name"].Value.ToString();

                txtMarks.Text =
                    row.Cells["TotalMarks"].Value.ToString();

                txtWeightage.Text =
                    row.Cells["TotalWeightage"].Value.ToString();
            }
        }

        private void addEvalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Evaluation name is required!");
                    return;
                }
                else if (txtMarks.Text == "")
                {
                    MessageBox.Show("Total Marks are required!");
                    return;
                }
                else if (txtWeightage.Text == "")
                {
                    MessageBox.Show("Weightage is required!");
                    return;
                }

                string query = $@"
                                INSERT INTO evaluation (Name, TotalMarks, TotalWeightage)
                                VALUES
                                (
                                    '{txtName.Text}', {txtMarks.Text}, {txtWeightage.Text}
                                )";
                db.ExecuteQuery(query);
                MessageBox.Show("Evaluation Added");

                LoadEvaluations();
                ClearFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateEvalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    MessageBox.Show("Evaluation name is required!");
                    return;
                }
                else if (txtMarks.Text == "")
                {
                    MessageBox.Show("Total Marks are required!");
                    return;
                }
                else if (txtWeightage.Text == "")
                {
                    MessageBox.Show("Weightage is required!");
                    return;
                }

                int id = Convert.ToInt32(displayEvaluations.CurrentRow.Cells["Id"].Value);
                string query = $@"
                                UPDATE evaluation
                                SET Name = '{txtName.Text}',
                                    TotalMarks = {txtMarks.Text},
                                    TotalWeightage = {txtWeightage.Text}
                                WHERE Id = {id};";

                db.ExecuteQuery(query);
                MessageBox.Show("Evaluation Updated!");
                LoadEvaluations();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delEvalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(displayEvaluations.CurrentRow.Cells["Id"].Value);
                string query = $@"
                                DELETE FROM evaluation
                                WHERE Id = {id};";

                MessageBox.Show("Deleted!");
                LoadEvaluations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEvaluations();
        }
    }
}
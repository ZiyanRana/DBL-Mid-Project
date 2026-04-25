using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidDb26_2024CS49
{
    public partial class GroupMarkingForm : Form
    {
        DBHelper db = new DBHelper();
        public GroupMarkingForm()
        {
            InitializeComponent();
        }

        void LoadGroups()
        {
            string query = "SELECT Id, CONCAT('Group ', Id) AS GroupName FROM `group`;";

            DataTable dt = db.GetData(query);

            cmbGroups.DataSource = dt;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "Id";
        }

        void LoadEvaluations()
        {
            string query = "SELECT Id, Name FROM evaluation;";

            DataTable dt = db.GetData(query);

            cmbEvals.DataSource = dt;
            cmbEvals.DisplayMember = "Name";
            cmbEvals.ValueMember = "Id";
        }

        void LoadMarks()
        {
            string query = @"
                            SELECT
                                ge.GroupId,
                                e.Name AS Evaluation,
                                ge.ObtainedMarks,
                                ge.EvaluationDate
                            FROM groupevaluation ge
                            JOIN evaluation e ON ge.EvaluationId = e.Id;";

            displayMarks.DataSource = db.GetData(query);
        }

        void ClearFields()
        {
            txtMarks.Text = "";
        }

        private void GroupMarkingForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadEvaluations();
            LoadMarks();
        }

        private void assignMarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);
                int evaluationId = Convert.ToInt32(cmbEvals.SelectedValue);
                int obtainedMarks = Convert.ToInt32(txtMarks.Text);

                string totalMarksQuery = @"
                                          SELECT TotalMarks FROM evaluation
                                          WHERE Id = {evaluationId};";

                int totalMarks = Convert.ToInt32(db.GetData(totalMarksQuery).Rows[0]["TotalMarks"]);

                if (obtainedMarks > totalMarks)
                {
                    MessageBox.Show("Obtained marks cannot exceed total marks!");
                    return;
                }

                string query = $@"
                                INSERT INTO groupevaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate)
                                VALUES ( {groupId}, {evaluationId}, {obtainedMarks}, NOW() );";

                db.ExecuteQuery(query);
                MessageBox.Show("Marks Assigned!");
                LoadMarks();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateMarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);
                int evaluationId = Convert.ToInt32(cmbEvals.SelectedValue);
                int obtainedMarks = Convert.ToInt32(txtMarks.Text);

                string query = $@"
                                UPDATE groupevaluation
                                SET ObtainedMarks = {obtainedMarks}
                                WHERE GroupId = {groupId} AND EvaluationId = {evaluationId}";

                db.ExecuteQuery(query);
                MessageBox.Show("Updated!");
                LoadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteMarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);

                int evaluationId = Convert.ToInt32(cmbEvals.SelectedValue);

                string query = $@"
                                DELETE FROM groupevaluation
                                WHERE GroupId = {groupId} AND EvaluationId = {evaluationId}";

                db.ExecuteQuery(query);
                MessageBox.Show("Marks Deleted!");
                LoadMarks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadEvaluations();
            LoadGroups();
            LoadMarks();
            ClearFields();
        }
    }
}

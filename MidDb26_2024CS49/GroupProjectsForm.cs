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
    public partial class GroupProjectsForm : Form
    {
        DBHelper db = new DBHelper();
        public GroupProjectsForm()
        {
            InitializeComponent();
        }

        void LoadGroups()
        {
            string query = @"SELECT Id, CONCAT('Group ', Id) AS GroupName FROM `group`";

            DataTable dt = db.GetData(query);

            cmbGroups.DataSource = dt;
            cmbGroups.DisplayMember = "GroupName";
            cmbGroups.ValueMember = "Id";
        }

        void LoadProjects()
        {
            string query = @"SELECT Id, Title FROM project";

            DataTable dt = db.GetData(query);

            cmbProjects.DataSource = dt;
            cmbProjects.DisplayMember = "Title";
            cmbProjects.ValueMember = "Id";
        }

        void LoadAssignments()
        {
            string query = @"
                            SELECT gp.ProjectId, gp.GroupId, p.Title, gp.AssignmentDate
                            FROM groupproject gp
                            JOIN project p ON gp.ProjectId = p.Id";

            displayAssignments.DataSource = db.GetData(query);
            displayAssignments.Columns["ProjectId"].Visible = false;
        }

        private void GroupProjectsForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadProjects();
            LoadAssignments();
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(cmbGroups.SelectedValue);
                int projectId = Convert.ToInt32(cmbProjects.SelectedValue);

                string checkQuery = $@"
                                    SELECT *
                                    FROM groupproject
                                    WHERE GroupId = {groupId}";

                if (db.GetData(checkQuery).Rows.Count > 0)
                {
                    MessageBox.Show("This group already has a project assigned!");
                    return;
                }

                string query = $@"
                                INSERT INTO groupproject (ProjectId, GroupId, AssignmentDate)
                                VALUES
                                ({projectId}, {groupId}, NOW())";

                db.ExecuteQuery(query);
                MessageBox.Show("Project Assigned!");
                LoadAssignments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeAssignmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayAssignments.CurrentRow == null)
                {
                    MessageBox.Show("Select an assignment first!");
                    return;
                }

                int groupId = Convert.ToInt32(displayAssignments.CurrentRow.Cells["GroupId"].Value);
                int projectId = Convert.ToInt32(displayAssignments.CurrentRow.Cells["ProjectId"].Value);

                string query = $@"
                                 DELETE FROM groupproject
                                 WHERE GroupId = {groupId} AND ProjectId = {projectId};";
                db.ExecuteQuery(query);
                MessageBox.Show("Assignment removed successfully!");
                LoadAssignments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

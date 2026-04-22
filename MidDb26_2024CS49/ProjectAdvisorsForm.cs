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
    public partial class ProjectAdvisorsForm : Form
    {
        DBHelper db = new DBHelper();
        public ProjectAdvisorsForm()
        {
            InitializeComponent();
        }

        void LoadProjects()
        {
            string query = "SELECT Id, Title FROM project";

            DataTable dt = db.GetData(query);

            cmbProjects.DataSource = dt;
            cmbProjects.DisplayMember = "Title";
            cmbProjects.ValueMember = "Id";
        }

        void LoadAdvisors()
        {
            string query = @"
                            SELECT a.Id, CONCAT(p.FirstName, ' ', p.LastName) AS AdvisorName
                            FROM advisor a
                            JOIN person p ON a.Id = p.Id";

            DataTable dt = db.GetData(query);

            cmbAdvisors.DataSource = dt;
            cmbAdvisors.DisplayMember = "AdvisorName";
            cmbAdvisors.ValueMember = "Id";
        }

        void LoadRoles()
        {
            string query = @"
                            SELECT Id, Value
                            FROM lookup
                            WHERE Category = 'ADVISOR_ROLE'";

            DataTable dt = db.GetData(query);

            cmbRoles.DataSource = dt;
            cmbRoles.DisplayMember = "Value";
            cmbRoles.ValueMember = "Id";
        }

        void LoadAssignments()
        {
            string query = @"
                            SELECT 
                                p.Title AS Project, 
                                CONCAT(pe.FirstName, ' ', pe.LastName) AS Advisor,
                                l.Value AS Role, 
                                pa.AssignmentDate

                            FROM projectadvisor pa

                            JOIN project p ON pa.ProjectId = p.Id
                            JOIN advisor a ON pa.AdvisorId = a.Id
                            JOIN person pe ON a.Id = pe.Id
                            JOIN lookup l ON pa.AdvisorRole = l.Id";
      
            displayAssignments.DataSource = db.GetData(query);
        }
        private void ProjectAdvisorsForm_Load(object sender, EventArgs e)
        {
            LoadProjects();
            LoadAdvisors();
            LoadRoles();
            LoadAssignments();
        }

        private void assignAdvisorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int projectId = Convert.ToInt32(cmbProjects.SelectedValue);
                int advisorId = Convert.ToInt32(cmbAdvisors.SelectedValue);
                int roleId = Convert.ToInt32(cmbRoles.SelectedValue);

                string checkQuery = $@"
                                    SELECT *
                                    FROM projectadvisor
                                    WHERE ProjectId = {projectId}
                                    AND AdvisorRole = {roleId}";

                if (db.GetData(checkQuery).Rows.Count > 0)
                {
                    MessageBox.Show("This role is already assigned for this project!");
                    return;
                }

                string query = $@"
                                INSERT INTO projectadvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate)
                                VALUES
                                ({advisorId}, {projectId}, {roleId}, NOW())";

                db.ExecuteQuery(query);
                MessageBox.Show("Advisor Assigned!");
                LoadAssignments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

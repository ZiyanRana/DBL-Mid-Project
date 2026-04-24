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
    public partial class ReportsForm : Form
    {
        DBHelper db = new DBHelper();
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void projectReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                                SELECT
                                    p.Title AS Project, 
                                    gp.GroupId, 
                                    CONCAT(pe.FirstName, ' ', pe.LastName) AS Advisor,
                                    l.Value AS AdvisorRole
                                FROM groupproject gp
                                JOIN project p ON gp.ProjectId = p.Id
                                JOIN projectadvisor pa ON p.Id = pa.ProjectId
                                JOIN advisor a ON pa.AdvisorId = a.Id
                                JOIN person pe ON a.Id = pe.Id
                                JOIN lookup l ON pa.AdvisorRole = l.Id
                                ORDER BY p.Title;";

                displayReports.DataSource = db.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void marksheetReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
                                SELECT
                                    ge.GroupId,
                                    e.Name AS Evaluation,
                                    ge.ObtainedMarks,
                                    e.TotalMarks,
                                    (
                                        ge.ObtainedMarks * 100/e.TotalMarks) AS Percentage
                                    FROM groupevaluation ge
                                    JOIN evaluation e ON ge.EvaluationId = e.Id;";

                displayReports.DataSource = db.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

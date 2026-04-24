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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();
        }

        private void advisorsBtn_Click(object sender, EventArgs e)
        {
            AdvisorsForm form = new AdvisorsForm();
            form.Show();
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            ProjectsForm form = new ProjectsForm();
            form.Show();
        }

        private void groupsBtn_Click(object sender, EventArgs e)
        {
            GroupsForm form = new GroupsForm();
            form.Show();
        }

        private void assignProjectsBtn_Click(object sender, EventArgs e)
        {
            GroupProjectsForm form = new GroupProjectsForm();
            form.Show();
        }

        private void assignAdvisorsBtn_Click(object sender, EventArgs e)
        {
            ProjectAdvisorsForm form = new ProjectAdvisorsForm();
            form.Show();
        }

        private void evaluationsBtn_Click(object sender, EventArgs e)
        {
            EvaluationsForm form = new EvaluationsForm();
            form.Show();
        }

        private void assignMarksBtn_Click(object sender, EventArgs e)
        {
            GroupMarkingForm form = new GroupMarkingForm();
            form.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm();
            form.Show();
        }
    }
}

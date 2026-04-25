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
    public partial class ProjectsForm : Form
    {
        DBHelper db = new DBHelper();
        public ProjectsForm()
        {
            InitializeComponent();
        }

        void LoadProjects()
        {
            string query = "SELECT * FROM project";
            displayProjects.DataSource = db.GetData(query);
        }

        void ClearFields()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Title is required");
                return;
            }

            try
            {
                string query = $"INSERT INTO project (Title, Description) VALUES ('{txtTitle.Text}', '{txtDescription.Text}')";
                db.ExecuteQuery(query);

                MessageBox.Show("Project Added!");

                LoadProjects();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Title is required");
                return;
            }

            try
            {
                int id = Convert.ToInt32(displayProjects.CurrentRow.Cells["Id"].Value);

                string query = $"UPDATE project SET Title='{txtTitle.Text}', Description='{txtDescription.Text}' WHERE Id={id}";
                db.ExecuteQuery(query);

                MessageBox.Show("Updated!");

                LoadProjects();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this project?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                int id = Convert.ToInt32(displayProjects.CurrentRow.Cells["Id"].Value);

                db.ExecuteQuery($"DELETE FROM project WHERE Id = {id}");

                MessageBox.Show("Deleted!");

                LoadProjects();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProjects();
            ClearFields();
        }

        private void displayProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = displayProjects.Rows[e.RowIndex];

                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }
    }
}

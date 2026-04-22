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
    public partial class GroupsForm : Form
    {
        DBHelper db = new DBHelper();
        public GroupsForm()
        {
            InitializeComponent();
        }

        void LoadGroups()
        {
            string query = "SELECT * FROM `group`";
            displayGroups.DataSource = db.GetData(query);
        }

        void LoadStudents()
        {
            string query = @"
                            SELECT s.Id, CONCAT(p.FirstName, ' ', p.LastName, ' - ', s.RegistrationNo) AS StudentInfo
                            FROM student s
                            JOIN person p ON s.Id = p.Id";

            DataTable dt = db.GetData(query);
            cmbStudents.DataSource = dt;
            cmbStudents.DisplayMember = "StudentInfo";
            cmbStudents.ValueMember = "Id";
        }

        void LoadGroupMembers(int groupId)
        {
            string query = $@"
                            SELECT p.FirstName, p.LastName, s.RegistrationNo
                            FROM groupstudent gs
                            JOIN student s ON gs.StudentId = s.Id
                            JOIN person p ON s.Id = p.Id
                            WHERE gs.GroupId = {groupId}";

            displayGroupMembers.DataSource = db.GetData(query);
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
            LoadStudents();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayGroups.CurrentRow == null)
                {
                    MessageBox.Show("Select a group first");
                    return;
                }

                int groupId = Convert.ToInt32(displayGroups.CurrentRow.Cells["Id"].Value);

                int studentId = Convert.ToInt32(cmbStudents.SelectedValue);

                string query = $@"
                                INSERT INTO groupstudent
                                (GroupId, StudentId, Status, AssignmentDate)
                                VALUES
                                ({groupId}, {studentId}, 3, NOW())";

                db.ExecuteQuery(query);
                MessageBox.Show("Student Added to Group!");
                LoadGroupMembers(groupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                                INSERT INTO `group` (Created_On)
                                VALUES ('{DateTime.Now:yyyy-MM-dd}')";

                db.ExecuteQuery(query);

                MessageBox.Show("Group Created!");

                LoadGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int groupId = Convert.ToInt32(displayGroups.Rows[e.RowIndex].Cells["Id"].Value);
                LoadGroupMembers(groupId);
            }
        }
    }
}

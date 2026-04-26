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
                            SELECT s.Id AS StudentId, p.FirstName, p.LastName, s.RegistrationNo
                            FROM groupstudent gs
                            JOIN student s ON gs.StudentId = s.Id
                            JOIN person p ON s.Id = p.Id
                            WHERE gs.GroupId = {groupId}";

            displayGroupMembers.DataSource = db.GetData(query);
            displayGroupMembers.Columns["StudentId"].Visible = false;
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

                string checkQuery = $@"
                                     SELECT * FROM groupstudent
                                     WHERE GroupId = {groupId} AND StudentId = {studentId};";
                
                if (db.GetData(checkQuery).Rows.Count > 0)
                {
                    MessageBox.Show("Student already exists in this group!");
                    return;
                }

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
            var cellValue = displayGroups.Rows[e.RowIndex].Cells["Id"].Value;
            if (cellValue == null || cellValue == DBNull.Value) return;

            if (e.RowIndex >= 0)
            {
                int groupId = Convert.ToInt32(displayGroups.Rows[e.RowIndex].Cells["Id"].Value);
                LoadGroupMembers(groupId);
            }
        }

        private void deleteGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayGroups.CurrentRow == null)
                {
                    MessageBox.Show("Select a group first!");
                    return;
                }

                int groupId = Convert.ToInt32(displayGroups.CurrentRow.Cells["Id"].Value);
                    
                db.ExecuteQuery($"DELETE FROM groupstudent WHERE GroupId = {groupId}");
                db.ExecuteQuery($"DELETE FROM groupproject WHERE GroupId = {groupId}");
                db.ExecuteQuery($"DELETE FROM groupevaluation WHERE GroupId = {groupId}");
                db.ExecuteQuery($"DELETE FROM `group` WHERE Id = {groupId}");

                MessageBox.Show("Group deleted!");
                LoadGroups();

                displayGroupMembers.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayGroups.CurrentRow == null || displayGroupMembers.CurrentRow == null)
                {
                    MessageBox.Show("Select group and student first!");
                    return;
                }

                int groupId = Convert.ToInt32(displayGroups.CurrentRow.Cells["Id"].Value);
                int studentId = Convert.ToInt32(displayGroupMembers.CurrentRow.Cells["StudentId"].Value);

                string query = $@"
                                DELETE FROM groupstudent
                                WHERE GroupId = {groupId} AND StudentId = {studentId}";

                db.ExecuteQuery(query);
                MessageBox.Show("Student removed from group!");
                LoadGroupMembers(groupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

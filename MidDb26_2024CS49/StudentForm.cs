using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace MidDb26_2024CS49
{
    public partial class StudentForm : Form
    {
        DBHelper db = new DBHelper();
        public StudentForm()
        {
            InitializeComponent();
        }

        void LoadStudents()
        {
            string query = @"SELECT s.Id, p.FirstName, p.LastName, p.Email, s.RegistrationNo, p.Gender AS GenderId, l.Value AS Gender
                     FROM student s
                     JOIN person p ON s.Id = p.Id
                     JOIN lookup l ON p.Gender = l.Id;";

            displayStudents.DataSource = db.GetData(query);
            displayStudents.Columns["GenderId"].Visible = false;
        }

        void LoadGenders()
        {
            string query = "SELECT Id, Value FROM lookup WHERE Category = 'GENDER';";

            DataTable dt = db.GetData(query);
            cmbGender.DataSource = dt;
            cmbGender.DisplayMember = "Value";
            cmbGender.ValueMember = "Id";
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadGenders();
        }

        void ClearFields()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtRegno.Text = "";
            cmbGender.SelectedValue = -1;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string checkQuery = $"SELECT * FROM student WHERE RegistrationNo = '{txtRegno.Text}';";
                if (db.GetData(checkQuery).Rows.Count > 0)
                {
                    MessageBox.Show("Student with this registration number or email already exists!");
                    return;
                }

                int gender = Convert.ToInt32(cmbGender.SelectedValue);
                string query1 = $"INSERT INTO person (FirstName, LastName, Email, Gender) VALUES ('{txtFirstname.Text}', '{txtLastname.Text}', '{txtEmail.Text}', {gender});";
                db.ExecuteQuery(query1);

                string getId = "SELECT LAST_INSERT_ID()";
                int personId = Convert.ToInt32(db.GetData(getId).Rows[0][0]);

                string query2 = $"INSERT INTO student (Id, RegistrationNo) VALUES ({personId}, '{txtRegno.Text}')";
                db.ExecuteQuery(query2);

                MessageBox.Show("Student Added!");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                int id = Convert.ToInt32(displayStudents.CurrentRow.Cells["Id"].Value);

                db.ExecuteQuery($"DELETE FROM student WHERE Id = {id}");
                db.ExecuteQuery($"DELETE FROM person WHERE Id = {id}");

                MessageBox.Show("Deleted!");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool ValidateInputs()
        {
            if (txtFirstname.Text.Trim() == "")
            {
                MessageBox.Show("First Name is required");
                return false;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email is required");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Invalid Email");
                return false;
            }

            if (txtRegno.Text.Trim() == "")
            {
                MessageBox.Show("Registration Number is required");
                return false;
            }
            else if (!txtRegno.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Invalid registration number, must include a number.");
                return false;
            }
            return true;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadStudents();
            ClearFields();
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                int id = Convert.ToInt32(displayStudents.CurrentRow.Cells["Id"].Value);
                int gender = Convert.ToInt32(cmbGender.SelectedValue);

                string query1 = $"UPDATE person SET FirstName='{txtFirstname.Text}', LastName='{txtLastname.Text}', Email='{txtEmail.Text}', Gender='{gender}' WHERE Id={id};";
                string query2 = $"UPDATE student SET RegistrationNo='{txtRegno.Text}' WHERE Id={id}";

                db.ExecuteQuery(query1);
                db.ExecuteQuery(query2);

                MessageBox.Show("Student Updated!");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = displayStudents.Rows[e.RowIndex];

                if (row.Cells["Id"].Value == null || row.Cells["Id"].Value == DBNull.Value) return;

                txtFirstname.Text = row.Cells["FirstName"].Value.ToString();
                txtLastname.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtRegno.Text = row.Cells["RegistrationNo"].Value.ToString();
                cmbGender.SelectedValue = row.Cells["GenderId"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

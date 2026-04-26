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
    public partial class AdvisorsForm : Form
    {
        DBHelper db = new DBHelper();
        public AdvisorsForm()
        {
            InitializeComponent();
        }
        void LoadDesignations()
        {
            string query = "SELECT Id, Value FROM lookup WHERE Category = 'DESIGNATION'";
            DataTable dt = db.GetData(query);
            cmbDesignation.DataSource = dt;
            cmbDesignation.DisplayMember = "Value";
            cmbDesignation.ValueMember = "Id";
        }
        void LoadAdvisors()
        {
            string query = @"SELECT a.Id, p.FirstName, p.LastName, p.Email, l1.Value AS Designation, 
                     a.Salary, p.Gender AS GenderId, l2.Value AS Gender
                     FROM advisor a
                     JOIN person p ON a.Id = p.Id
                     JOIN lookup l1 ON a.Designation = l1.Id
                     JOIN lookup l2 ON p.Gender = l2.Id";
            displayAdvisors.DataSource = db.GetData(query);
            displayAdvisors.Columns["GenderId"].Visible = false;
        }
        void LoadGenders()
        {
            string query = "SELECT Id, Value FROM lookup WHERE Category = 'GENDER';";
            DataTable dt = db.GetData(query);
            cmbGender.DataSource = dt;
            cmbGender.DisplayMember = "Value";
            cmbGender.ValueMember = "Id";
        }
        private void AdvisorsForm_Load(object sender, EventArgs e)
        {
            LoadDesignations();
            LoadGenders();
            LoadAdvisors();
        }
        bool ValidateInputs()
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name is required");
                return false;
            }
            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name is required");
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
            if (txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("Salary is required");
                return false;
            }
            if (!int.TryParse(txtSalary.Text, out _))
            {
                MessageBox.Show("Invalid salary amount, must be only numbers.");
                return false;
            }
            if (cmbDesignation.SelectedValue == null)
            {
                MessageBox.Show("Select designation!");
                return false;
            }
            if (cmbGender.SelectedValue == null)
            {
                MessageBox.Show("Select gender!");
                return false;
            }
            return true;
        }
        void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            cmbDesignation.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
        }
        private void addAdvisorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                string checkQuery = $"SELECT * FROM person p WHERE p.Email = '{txtEmail.Text}';";
                if (db.GetData(checkQuery).Rows.Count > 0)
                {
                    MessageBox.Show("Advisor already exist!");
                    return;
                }
                int gender = Convert.ToInt32(cmbGender.SelectedValue);
                string query1 = $"INSERT INTO person (FirstName, LastName, Email, Gender) VALUES ('{txtFirstName.Text}', '{txtLastName.Text}', '{txtEmail.Text}', {gender})";
                db.ExecuteQuery(query1);
                int personId = Convert.ToInt32(db.GetData("SELECT LAST_INSERT_ID()").Rows[0][0]);
                int designationId = Convert.ToInt32(cmbDesignation.SelectedValue);
                string query2 = $"INSERT INTO advisor (Id, Designation, Salary) VALUES ({personId}, {designationId}, {txtSalary.Text})";
                db.ExecuteQuery(query2);
                MessageBox.Show("Advisor Added!");
                ClearFields();
                LoadAdvisors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateAdvisorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;
                int id = Convert.ToInt32(displayAdvisors.CurrentRow.Cells["Id"].Value);
                int designationId = Convert.ToInt32(cmbDesignation.SelectedValue);
                int gender = Convert.ToInt32(cmbGender.SelectedValue);
                string q1 = $"UPDATE person SET FirstName='{txtFirstName.Text}', LastName='{txtLastName.Text}', Email='{txtEmail.Text}', Gender={gender} WHERE Id={id};";
                string q2 = $"UPDATE advisor SET Designation={designationId}, Salary={txtSalary.Text} WHERE Id={id}";
                db.ExecuteQuery(q1);
                db.ExecuteQuery(q2);
                MessageBox.Show("Updated!");
                ClearFields();
                LoadAdvisors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleteAdvisorBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this advisor?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                int id = Convert.ToInt32(displayAdvisors.CurrentRow.Cells["Id"].Value);
                db.ExecuteQuery($"DELETE FROM advisor WHERE Id = {id}");
                db.ExecuteQuery($"DELETE FROM person WHERE Id = {id}");
                MessageBox.Show("Deleted!");
                ClearFields();
                LoadAdvisors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadAdvisors();
            ClearFields();
        }
        private void displayAdvisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void displayAdvisors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = displayAdvisors.Rows[e.RowIndex];
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                cmbDesignation.Text = row.Cells["Designation"].Value.ToString();
                cmbGender.SelectedValue = row.Cells["GenderId"].Value;
            }
        }
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
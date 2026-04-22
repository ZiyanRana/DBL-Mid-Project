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
            string query = "Select * from `group`";
            displayGroups.DataSource = db.GetData(query);
        }

        void LoadStudents()
        {
            stirng query = @""
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createGroupBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

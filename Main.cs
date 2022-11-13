using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_PRG_282
{
    public partial class Main : Form
    {
        Controls.ManageStudent ucManageStudent = new Controls.ManageStudent();
        Controls.CreateStudent ucNewStudent = new Controls.CreateStudent();
        Controls.ViewStudent ucViewStudent = new Controls.ViewStudent();
        Controls.AddModule ucAddModule = new Controls.AddModule();
        Controls.ManageModules ucManageModule = new Controls.ManageModules();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            
            
            
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucViewStudent);
            ucViewStudent.Dock = DockStyle.Fill;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucNewStudent);
            ucNewStudent.Dock = DockStyle.Fill;

            SqlCommand addStudent;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //sql = "Insert Into Student (StudentNumber, Name, Surname, DOB, Gender, Phone, Address) values ()"
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucViewStudent);
            ucViewStudent.Dock = DockStyle.Fill;
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucManageStudent);
            ucManageStudent.Dock = DockStyle.Fill;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewModule_Click(object sender, EventArgs e)
        {

        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucAddModule);
            ucManageStudent.Dock = DockStyle.Fill;
        }

        private void btnMangeModules_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucManageModule);
            ucManageStudent.Dock = DockStyle.Fill;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // This code hides the current Main form  and shows the login form to the user.
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

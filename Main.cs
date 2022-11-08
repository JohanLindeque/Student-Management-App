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
        Controls.NewStudent ucNewStudent = new Controls.NewStudent();
        Controls.ViewStudent ucViewStudent = new Controls.ViewStudent();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

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
    }
}

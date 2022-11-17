using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG_282.Controls
{
    public partial class ManageStudent : UserControl
    {
        DataHandler dh = new DataHandler();
        List<string> modules = new List<string>();
        public ManageStudent()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txbSearchStudent.Clear();
            txbStuAddress.Clear();
            txbStuID.Clear();
            txbStuName.Clear();
            txbStuPhone.Clear();
            txbStuSurname.Clear();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            dh.GetStudents();
            dgvManageStudent.DataSource = dh.bs;
            dh.GetModules();
            foreach (DbDataRecord dr in dh.bs)
            {
                cbxModules.Items.Add(dr[0]);
            }
            txbStuID.Text = dh.GetLastStudentNumber();
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(int.Parse(txbStuID.Text), txbStuName.Text, txbStuSurname.Text,null, dateTimePicker1.Value, cbxGender.Text, txbStuPhone.Text, txbStuAddress.Text, modules);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvManageStudent_SelectionChanged(object sender, EventArgs e)
        {
            DbDataRecord dr = dh.bs.Current as DbDataRecord;

            if(dr != null)
            {
                txbStuID.Text = dr[0].ToString();
                txbStuName.Text = dr[1].ToString();
                txbStuSurname.Text = dr[2].ToString();
                cbxGender.Text = dr[5].ToString();
                txbStuPhone.Text = dr[6].ToString();
                txbStuAddress.Text = dr[7].ToString();
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            dh.GetStudents(int.Parse(txbSearchStudent.Text));
            dgvManageStudent.DataSource = dh.bs;
            Clear();
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            dh.DeleteStudent(int.Parse(txbSearchStudent.Text));
            dgvManageStudent.DataSource = dh.bs;
        }

        private void btnaddMod_Click(object sender, EventArgs e)
        {
            string module = cbxModules.Text;
            if (!modules.Contains(module) && module != "")
            {
                modules.Add(module);
            }
            lbxModules.Items.Clear();
            foreach (var item in modules)
            {
                lbxModules.Items.Add(item);
            }
        }

        private void btnRemoveMod_Click(object sender, EventArgs e)
        {
            modules.Remove(lbxModules.SelectedItem.ToString());
            lbxModules.Items.Clear();
            foreach (var item in modules)
            {
                lbxModules.Items.Add(item);
            }
        }
    }
}

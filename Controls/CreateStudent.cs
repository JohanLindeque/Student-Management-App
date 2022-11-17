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
    public partial class CreateStudent : UserControl
    {
        DataHandler handler = new DataHandler();
        Student student;
        List<string> modules = new List<string>();

        List<string> chosenMod= new List<string>();

        public void clearInput()
        {
            txbStuID.Clear();
            txbStuID.Focus();
            txbStuName.Clear();
            //dtpDOB.
            cbxGender.SelectedIndex = 0;
            txbStuPhone.Clear();
            txbStuAddress.Clear();
            lsbModules.Items.Clear();

        }

        public bool Check()
        {
            if (txbStuID.Text != null && txbStuName.Text != null && txbStuSurname.Text != null && txbStuPhone.Text != null && txbStuAddress.Text != null && dtpDOB.Value != null && cbxGender.SelectedItem != null && txbStuPhone.Text != null )
            {
                return true;
            }
            return false;
        }


        public CreateStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                student = new Student(int.Parse(txbStuID.Text), txbStuName.Text, txbStuSurname.Text, null, dtpDOB.Value, cbxGender.SelectedItem.ToString(), txbStuPhone.Text, txbStuAddress.Text, chosenMod);
                handler.AddStudent(student);
                clearInput();
            }
            else
            {
                MessageBox.Show("Ensure all fields have a valid input.");
            }
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            handler.GetModules();
            foreach (DbDataRecord dr in handler.bs)
            {
                cbxNodules.Items.Add(dr[0]);
            }
            txbStuID.Text = handler.GetLastStudentNumber();
            cbxGender.SelectedIndex = 0;
            cbxGender.Items.Add("Male");
            cbxGender.Items.Add("Female");
            cbxGender.Items.Add("Other");
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            string module = cbxNodules.Text;
            if (!modules.Contains(module) && module != "")
            {
                modules.Add(module);
            }
            lsbModules.Items.Clear();
            foreach (var item in modules)
            {
                lsbModules.Items.Add(item);
            }
        }

        private void btnRemoveMod_Click(object sender, EventArgs e)
        {
            modules.Remove(lsbModules.SelectedItem.ToString());
            lsbModules.Items.Clear();
            foreach (var item in modules)
            {
                lsbModules.Items.Add(item);
            }
        }
    }
}

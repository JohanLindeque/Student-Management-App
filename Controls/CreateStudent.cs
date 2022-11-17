using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void Check()
        {
            if (txbStuID.Text != null && txbStuName.Text != null && txbStuSurname.Text != null && txbStuPhone.Text != null && txbStuAddress.Text != null && dtpDOB.Value != null && cbxGender.SelectedItem != null && txbStuPhone.Text != null )
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


        public CreateStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            cbxGender.SelectedIndex = 0;
            cbxGender.Items.Add("Male");
            cbxGender.Items.Add("Female");
            cbxGender.Items.Add("Other");
        }
    }
}

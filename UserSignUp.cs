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
    public partial class UserSignUp : Form
    {
        public void newUser(string name, string password)
        {
            string User = $"{Environment.NewLine + name + ", " + password}";

            Filehandler.ReadUsers();
            foreach (string item in Filehandler.myusers)
            {
                if (Filehandler.myusers.Contains(User))
                {
                    MessageBox.Show("User already exist!");
                    break;

                }
                else
                {
                    Filehandler.WritUser(User);
                    MessageBox.Show("User created!");
                    switchForm();
                    
                    break;
                }
            }
        }

        public void ClearInput()
        {
            txbNewName.Clear();
            txbNewName.Focus();
            txbNewPassword.Clear();
        }

        public void switchForm()
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }


        public UserSignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            newUser(txbNewName.Text,txbNewPassword.Text);

        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {
           
           
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            switchForm();
        }
    }
}

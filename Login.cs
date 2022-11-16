using Project_PRG_282.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_PRG_282
{
    public partial class Login : Form
    {
        public void switchForm()
        {
            this.Hide();
            UserSignUp f2 = new UserSignUp();
            f2.ShowDialog();
            this.Close();
        }

        public void ClearInput()
        {
            txbUsername.Clear();
            txbUsername.Focus();
            txbPassword.Clear();
        }
        public void ValUser(string name,string pass)
        {
            string User = name + ", " + pass;
            Filehandler.ReadUsers();
            foreach (string item in Filehandler.myusers)
            {
                if (Filehandler.myusers.Contains(User))
                {
                    MessageBox.Show("Welcome!");
                    // This code hides the current login form and shows the Main form to the user.
                    this.Hide();
                    Main f2 = new Main();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User does not exist!");
                    switchForm();
                }

            }

        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
           Filehandler.ReadUsers();
            ClearInput();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            switchForm();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // This code hides the current login form and shows the Main form to the user.
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValUser(txbUsername.Text, txbPassword.Text);
            
        }
    }
    
}

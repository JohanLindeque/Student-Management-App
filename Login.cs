using Project_PRG_282.Controls;
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
    public partial class Login : Form
    {
        Controls.SignUp ucSignup = new Controls.SignUp();
        Controls.UserLogin ucLogin= new Controls.UserLogin();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlUserOptions.Controls.Clear();
            pnlUserOptions.Controls.Add(ucLogin);
            ucLogin.Dock = DockStyle.Fill;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            pnlUserOptions.Controls.Clear();
            pnlUserOptions.Controls.Add(ucSignup);
            ucSignup.Dock = DockStyle.Fill;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlUserOptions.Controls.Clear();
            pnlUserOptions.Controls.Add(ucLogin);
            ucLogin.Dock = DockStyle.Fill;

           
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            // This code hides the current login form and shows the Main form to the user.
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
            this.Close();
        }
    }
    
}

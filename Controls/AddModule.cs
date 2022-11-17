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
    public partial class AddModule : UserControl
    {
        DataHandler handler = new DataHandler();
        Module mod;

        public void clearinputs()
        {
            txbModuleCode.Clear();
            txbModuleCode.Focus();
            txbModuleName.Clear();
            rtbModuleDes.Clear();
            txbModuleLink.Clear();
        }

        public bool check()
        {
            if (txbModuleCode.Text != null && txbModuleName.Text != null && rtbModuleDes.Text != null && txbModuleLink.Text != null)
            {
                return true;
            }
            return false;
        }

        public AddModule()
        {
            InitializeComponent();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (check())
            {
                mod = new Module(txbModuleCode.Text, txbModuleName.Text, rtbModuleDes.Text, txbModuleLink.Text);
                handler.AddModule(mod);
            }
            else
            {
                MessageBox.Show("Ensure all fields have a valid input.");
            }
            clearinputs();
        }
    }
}

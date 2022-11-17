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
    public partial class ManageModules : UserControl
    {

        DataHandler handler = new DataHandler();
        Module mod;

        public void clearInput()
        {
            txbSearchModule.Clear();
            txbModuleCode.Clear();
            txbModuleName.Clear();
            txbModuleLink.Clear();
            rtbModDesc.Clear();
        }

        public void search()
        {
            handler.GetModules(txbSearchModule.Text);
            dgvManageModule.DataSource = handler.bs;
            clearInput();
        }

        public bool check()
        {
            if (txbModuleCode.Text != null && txbModuleName.Text != null && txbModuleLink.Text != null && rtbModDesc.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ManageModules()
        {
            InitializeComponent();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dgvManageModule_SelectionChanged(object sender, EventArgs e)
        {
            DbDataRecord dr = handler.bs.Current as DbDataRecord;

            if(dr != null)
            {
                txbModuleCode.Text = dr[0].ToString();
                txbModuleName.Text = dr[1].ToString();
                txbModuleLink.Text = dr[2].ToString();
                rtbModDesc.Text = dr[0].ToString();

            }
        }

       

        private void ManageModules_Load(object sender, EventArgs e)
        {
            handler.GetModules();
            dgvManageModule.DataSource = handler.bs;
        }

        private void btnDeleteM_Click(object sender, EventArgs e)
        {
            if (txbModuleCode.Text != null)
            {
                handler.DeleteModule(txbModuleCode.Text);
                dgvManageModule.DataSource = handler.bs;
                clearInput();
            }
            else
            {
                MessageBox.Show("Enter a valid module code.");
            }
        }

        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                mod = new Module(txbModuleCode.Text, txbModuleName.Text, rtbModDesc.Text, txbModuleLink.Text);
                handler.UpdateModule(mod);
                clearInput();
            }
            else
            {
                MessageBox.Show("Ensure all fields contain valid input.");
            }
        }
    }
}

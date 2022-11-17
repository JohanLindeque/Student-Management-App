﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG_282.Controls
{
    public partial class ViewStudent : UserControl
    {
        DataHandler dh = new DataHandler();

        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            dh.GetStudents();
            dgvStudents.DataSource = dh.bs;
            dh.GetModules();
            dataGridView1.DataSource = dh.bs;
        }
    }
}

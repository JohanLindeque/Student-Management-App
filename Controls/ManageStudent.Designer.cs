namespace Project_PRG_282.Controls
{
    partial class ManageStudent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlManageContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.lblStuGender = new System.Windows.Forms.Label();
            this.lblStuAddress = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbStuName = new System.Windows.Forms.TextBox();
            this.txbStuSurname = new System.Windows.Forms.TextBox();
            this.txbStuAddress = new System.Windows.Forms.TextBox();
            this.lblStuDOB = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblStuSurname = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.txbStuPhone = new System.Windows.Forms.TextBox();
            this.txbStuID = new System.Windows.Forms.TextBox();
            this.dgvManageStudent = new System.Windows.Forms.DataGridView();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txbSearchStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblManageS = new System.Windows.Forms.Label();
            this.pnlManageTop = new System.Windows.Forms.Panel();
            this.lbxModules = new System.Windows.Forms.ListBox();
            this.cbxModules = new System.Windows.Forms.ComboBox();
            this.btnaddMod = new System.Windows.Forms.Button();
            this.btnRemoveMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlManageContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudent)).BeginInit();
            this.pnlManageTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageContainer
            // 
            this.pnlManageContainer.Controls.Add(this.panel1);
            this.pnlManageContainer.Controls.Add(this.dgvManageStudent);
            this.pnlManageContainer.Controls.Add(this.btnDeleteS);
            this.pnlManageContainer.Controls.Add(this.btnSearchStudent);
            this.pnlManageContainer.Controls.Add(this.txbSearchStudent);
            this.pnlManageContainer.Controls.Add(this.label1);
            this.pnlManageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageContainer.Location = new System.Drawing.Point(0, 81);
            this.pnlManageContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlManageContainer.Name = "pnlManageContainer";
            this.pnlManageContainer.Size = new System.Drawing.Size(835, 461);
            this.pnlManageContainer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRemoveMod);
            this.panel1.Controls.Add(this.btnaddMod);
            this.panel1.Controls.Add(this.cbxModules);
            this.panel1.Controls.Add(this.lbxModules);
            this.panel1.Controls.Add(this.cbxGender);
            this.panel1.Controls.Add(this.lblStuName);
            this.panel1.Controls.Add(this.btnUpdateS);
            this.panel1.Controls.Add(this.lblStuGender);
            this.panel1.Controls.Add(this.lblStuAddress);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txbStuName);
            this.panel1.Controls.Add(this.txbStuSurname);
            this.panel1.Controls.Add(this.txbStuAddress);
            this.panel1.Controls.Add(this.lblStuDOB);
            this.panel1.Controls.Add(this.lblStuID);
            this.panel1.Controls.Add(this.lblStuSurname);
            this.panel1.Controls.Add(this.lblStuPhone);
            this.panel1.Controls.Add(this.txbStuPhone);
            this.panel1.Controls.Add(this.txbStuID);
            this.panel1.Location = new System.Drawing.Point(15, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 193);
            this.panel1.TabIndex = 50;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(394, 16);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(146, 21);
            this.cbxGender.TabIndex = 49;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(29, 50);
            this.lblStuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(35, 13);
            this.lblStuName.TabIndex = 41;
            this.lblStuName.Text = "Name";
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(408, 144);
            this.btnUpdateS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(104, 28);
            this.btnUpdateS.TabIndex = 13;
            this.btnUpdateS.Text = "Update Student";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(312, 16);
            this.lblStuGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(42, 13);
            this.lblStuGender.TabIndex = 48;
            this.lblStuGender.Text = "Gender";
            // 
            // lblStuAddress
            // 
            this.lblStuAddress.AutoSize = true;
            this.lblStuAddress.Location = new System.Drawing.Point(312, 91);
            this.lblStuAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuAddress.Name = "lblStuAddress";
            this.lblStuAddress.Size = new System.Drawing.Size(45, 13);
            this.lblStuAddress.TabIndex = 40;
            this.lblStuAddress.Text = "Address";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 113);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // txbStuName
            // 
            this.txbStuName.Location = new System.Drawing.Point(112, 50);
            this.txbStuName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuName.Name = "txbStuName";
            this.txbStuName.Size = new System.Drawing.Size(146, 20);
            this.txbStuName.TabIndex = 46;
            // 
            // txbStuSurname
            // 
            this.txbStuSurname.Location = new System.Drawing.Point(112, 81);
            this.txbStuSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuSurname.Name = "txbStuSurname";
            this.txbStuSurname.Size = new System.Drawing.Size(146, 20);
            this.txbStuSurname.TabIndex = 42;
            // 
            // txbStuAddress
            // 
            this.txbStuAddress.Location = new System.Drawing.Point(394, 91);
            this.txbStuAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuAddress.Name = "txbStuAddress";
            this.txbStuAddress.Size = new System.Drawing.Size(146, 20);
            this.txbStuAddress.TabIndex = 45;
            // 
            // lblStuDOB
            // 
            this.lblStuDOB.AutoSize = true;
            this.lblStuDOB.Location = new System.Drawing.Point(29, 117);
            this.lblStuDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuDOB.Name = "lblStuDOB";
            this.lblStuDOB.Size = new System.Drawing.Size(30, 13);
            this.lblStuDOB.TabIndex = 36;
            this.lblStuDOB.Text = "DOB";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(29, 16);
            this.lblStuID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(58, 13);
            this.lblStuID.TabIndex = 39;
            this.lblStuID.Text = "Student ID";
            // 
            // lblStuSurname
            // 
            this.lblStuSurname.AutoSize = true;
            this.lblStuSurname.Location = new System.Drawing.Point(29, 84);
            this.lblStuSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuSurname.Name = "lblStuSurname";
            this.lblStuSurname.Size = new System.Drawing.Size(49, 13);
            this.lblStuSurname.TabIndex = 37;
            this.lblStuSurname.Text = "Surname";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(312, 58);
            this.lblStuPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(38, 13);
            this.lblStuPhone.TabIndex = 38;
            this.lblStuPhone.Text = "Phone";
            // 
            // txbStuPhone
            // 
            this.txbStuPhone.Location = new System.Drawing.Point(394, 58);
            this.txbStuPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuPhone.Name = "txbStuPhone";
            this.txbStuPhone.Size = new System.Drawing.Size(146, 20);
            this.txbStuPhone.TabIndex = 43;
            // 
            // txbStuID
            // 
            this.txbStuID.Location = new System.Drawing.Point(112, 16);
            this.txbStuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuID.Name = "txbStuID";
            this.txbStuID.Size = new System.Drawing.Size(146, 20);
            this.txbStuID.TabIndex = 44;
            // 
            // dgvManageStudent
            // 
            this.dgvManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageStudent.Location = new System.Drawing.Point(228, 32);
            this.dgvManageStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvManageStudent.Name = "dgvManageStudent";
            this.dgvManageStudent.RowHeadersWidth = 51;
            this.dgvManageStudent.RowTemplate.Height = 24;
            this.dgvManageStudent.Size = new System.Drawing.Size(578, 141);
            this.dgvManageStudent.TabIndex = 14;
            this.dgvManageStudent.SelectionChanged += new System.EventHandler(this.dgvManageStudent_SelectionChanged);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(46, 146);
            this.btnDeleteS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(104, 28);
            this.btnDeleteS.TabIndex = 13;
            this.btnDeleteS.Text = "Delete Student";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(46, 98);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(104, 22);
            this.btnSearchStudent.TabIndex = 11;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txbSearchStudent
            // 
            this.txbSearchStudent.Location = new System.Drawing.Point(29, 58);
            this.txbSearchStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSearchStudent.Name = "txbSearchStudent";
            this.txbSearchStudent.Size = new System.Drawing.Size(145, 20);
            this.txbSearchStudent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by Student ID";
            // 
            // lblManageS
            // 
            this.lblManageS.AutoSize = true;
            this.lblManageS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageS.Location = new System.Drawing.Point(9, 20);
            this.lblManageS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageS.Name = "lblManageS";
            this.lblManageS.Size = new System.Drawing.Size(277, 37);
            this.lblManageS.TabIndex = 0;
            this.lblManageS.Text = "Manage students";
            // 
            // pnlManageTop
            // 
            this.pnlManageTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlManageTop.Controls.Add(this.lblManageS);
            this.pnlManageTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageTop.Location = new System.Drawing.Point(0, 0);
            this.pnlManageTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlManageTop.Name = "pnlManageTop";
            this.pnlManageTop.Size = new System.Drawing.Size(835, 81);
            this.pnlManageTop.TabIndex = 3;
            // 
            // lbxModules
            // 
            this.lbxModules.FormattingEnabled = true;
            this.lbxModules.Location = new System.Drawing.Point(599, 59);
            this.lbxModules.Name = "lbxModules";
            this.lbxModules.Size = new System.Drawing.Size(165, 69);
            this.lbxModules.TabIndex = 50;
            // 
            // cbxModules
            // 
            this.cbxModules.FormattingEnabled = true;
            this.cbxModules.Location = new System.Drawing.Point(599, 32);
            this.cbxModules.Name = "cbxModules";
            this.cbxModules.Size = new System.Drawing.Size(165, 21);
            this.cbxModules.TabIndex = 51;
            // 
            // btnaddMod
            // 
            this.btnaddMod.Location = new System.Drawing.Point(599, 144);
            this.btnaddMod.Name = "btnaddMod";
            this.btnaddMod.Size = new System.Drawing.Size(75, 23);
            this.btnaddMod.TabIndex = 52;
            this.btnaddMod.Text = "Add";
            this.btnaddMod.UseVisualStyleBackColor = true;
            this.btnaddMod.Click += new System.EventHandler(this.btnaddMod_Click);
            // 
            // btnRemoveMod
            // 
            this.btnRemoveMod.Location = new System.Drawing.Point(689, 144);
            this.btnRemoveMod.Name = "btnRemoveMod";
            this.btnRemoveMod.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMod.TabIndex = 53;
            this.btnRemoveMod.Text = "Remove";
            this.btnRemoveMod.UseVisualStyleBackColor = true;
            this.btnRemoveMod.Click += new System.EventHandler(this.btnRemoveMod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Modules";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageContainer);
            this.Controls.Add(this.pnlManageTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStudent";
            this.Size = new System.Drawing.Size(835, 542);
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.pnlManageContainer.ResumeLayout(false);
            this.pnlManageContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudent)).EndInit();
            this.pnlManageTop.ResumeLayout(false);
            this.pnlManageTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageContainer;
        private System.Windows.Forms.Label lblManageS;
        private System.Windows.Forms.Panel pnlManageTop;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txbSearchStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.DataGridView dgvManageStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblStuGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txbStuSurname;
        private System.Windows.Forms.Label lblStuDOB;
        private System.Windows.Forms.Label lblStuSurname;
        private System.Windows.Forms.TextBox txbStuPhone;
        private System.Windows.Forms.TextBox txbStuID;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.TextBox txbStuAddress;
        private System.Windows.Forms.TextBox txbStuName;
        private System.Windows.Forms.Label lblStuAddress;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveMod;
        private System.Windows.Forms.Button btnaddMod;
        private System.Windows.Forms.ComboBox cbxModules;
        private System.Windows.Forms.ListBox lbxModules;
    }
}

namespace Project_PRG_282.Controls
{
    partial class CreateStudent
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
            this.pnlCreateTop = new System.Windows.Forms.Panel();
            this.lblManageS = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblStuGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txbStuSurname = new System.Windows.Forms.TextBox();
            this.lblStuDOB = new System.Windows.Forms.Label();
            this.lblStuSurname = new System.Windows.Forms.Label();
            this.txbStuPhone = new System.Windows.Forms.TextBox();
            this.txbStuID = new System.Windows.Forms.TextBox();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.txbStuAddress = new System.Windows.Forms.TextBox();
            this.txbStuName = new System.Windows.Forms.TextBox();
            this.lblStuAddress = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lsbModules = new System.Windows.Forms.ListBox();
            this.cbxNodules = new System.Windows.Forms.ComboBox();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveMod = new System.Windows.Forms.Button();
            this.pnlCreateTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCreateTop
            // 
            this.pnlCreateTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlCreateTop.Controls.Add(this.lblManageS);
            this.pnlCreateTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCreateTop.Name = "pnlCreateTop";
            this.pnlCreateTop.Size = new System.Drawing.Size(835, 81);
            this.pnlCreateTop.TabIndex = 4;
            // 
            // lblManageS
            // 
            this.lblManageS.AutoSize = true;
            this.lblManageS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageS.Location = new System.Drawing.Point(9, 20);
            this.lblManageS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageS.Name = "lblManageS";
            this.lblManageS.Size = new System.Drawing.Size(257, 37);
            this.lblManageS.TabIndex = 0;
            this.lblManageS.Text = "Create students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(200, 410);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(134, 30);
            this.btnAddStudent.TabIndex = 20;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(243, 266);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(146, 21);
            this.cbxGender.TabIndex = 19;
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(161, 266);
            this.lblStuGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(42, 13);
            this.lblStuGender.TabIndex = 18;
            this.lblStuGender.Text = "Gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(243, 223);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(146, 20);
            this.dtpDOB.TabIndex = 17;
            // 
            // txbStuSurname
            // 
            this.txbStuSurname.Location = new System.Drawing.Point(243, 185);
            this.txbStuSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuSurname.Name = "txbStuSurname";
            this.txbStuSurname.Size = new System.Drawing.Size(146, 20);
            this.txbStuSurname.TabIndex = 12;
            // 
            // lblStuDOB
            // 
            this.lblStuDOB.AutoSize = true;
            this.lblStuDOB.Location = new System.Drawing.Point(161, 228);
            this.lblStuDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuDOB.Name = "lblStuDOB";
            this.lblStuDOB.Size = new System.Drawing.Size(30, 13);
            this.lblStuDOB.TabIndex = 6;
            this.lblStuDOB.Text = "DOB";
            // 
            // lblStuSurname
            // 
            this.lblStuSurname.AutoSize = true;
            this.lblStuSurname.Location = new System.Drawing.Point(161, 187);
            this.lblStuSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuSurname.Name = "lblStuSurname";
            this.lblStuSurname.Size = new System.Drawing.Size(49, 13);
            this.lblStuSurname.TabIndex = 7;
            this.lblStuSurname.Text = "Surname";
            // 
            // txbStuPhone
            // 
            this.txbStuPhone.Location = new System.Drawing.Point(243, 307);
            this.txbStuPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuPhone.Name = "txbStuPhone";
            this.txbStuPhone.Size = new System.Drawing.Size(146, 20);
            this.txbStuPhone.TabIndex = 13;
            // 
            // txbStuID
            // 
            this.txbStuID.Enabled = false;
            this.txbStuID.Location = new System.Drawing.Point(243, 119);
            this.txbStuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuID.Name = "txbStuID";
            this.txbStuID.Size = new System.Drawing.Size(146, 20);
            this.txbStuID.TabIndex = 14;
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(161, 307);
            this.lblStuPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(38, 13);
            this.lblStuPhone.TabIndex = 8;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(161, 119);
            this.lblStuID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(58, 13);
            this.lblStuID.TabIndex = 9;
            this.lblStuID.Text = "Student ID";
            // 
            // txbStuAddress
            // 
            this.txbStuAddress.Location = new System.Drawing.Point(243, 341);
            this.txbStuAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuAddress.Name = "txbStuAddress";
            this.txbStuAddress.Size = new System.Drawing.Size(146, 20);
            this.txbStuAddress.TabIndex = 15;
            // 
            // txbStuName
            // 
            this.txbStuName.Location = new System.Drawing.Point(243, 153);
            this.txbStuName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbStuName.Name = "txbStuName";
            this.txbStuName.Size = new System.Drawing.Size(146, 20);
            this.txbStuName.TabIndex = 16;
            // 
            // lblStuAddress
            // 
            this.lblStuAddress.AutoSize = true;
            this.lblStuAddress.Location = new System.Drawing.Point(161, 341);
            this.lblStuAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuAddress.Name = "lblStuAddress";
            this.lblStuAddress.Size = new System.Drawing.Size(45, 13);
            this.lblStuAddress.TabIndex = 10;
            this.lblStuAddress.Text = "Address";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(161, 153);
            this.lblStuName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(35, 13);
            this.lblStuName.TabIndex = 11;
            this.lblStuName.Text = "Name";
            // 
            // lsbModules
            // 
            this.lsbModules.FormattingEnabled = true;
            this.lsbModules.Location = new System.Drawing.Point(489, 174);
            this.lsbModules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbModules.Name = "lsbModules";
            this.lsbModules.Size = new System.Drawing.Size(186, 186);
            this.lsbModules.TabIndex = 21;
            // 
            // cbxNodules
            // 
            this.cbxNodules.FormattingEnabled = true;
            this.cbxNodules.Location = new System.Drawing.Point(489, 145);
            this.cbxNodules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxNodules.Name = "cbxNodules";
            this.cbxNodules.Size = new System.Drawing.Size(186, 21);
            this.cbxNodules.TabIndex = 22;
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(489, 364);
            this.btnAddMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(90, 19);
            this.btnAddMod.TabIndex = 23;
            this.btnAddMod.Text = "Add";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Modules";
            // 
            // btnRemoveMod
            // 
            this.btnRemoveMod.Location = new System.Drawing.Point(595, 364);
            this.btnRemoveMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveMod.Name = "btnRemoveMod";
            this.btnRemoveMod.Size = new System.Drawing.Size(80, 19);
            this.btnRemoveMod.TabIndex = 25;
            this.btnRemoveMod.Text = "Remove";
            this.btnRemoveMod.UseVisualStyleBackColor = true;
            this.btnRemoveMod.Click += new System.EventHandler(this.btnRemoveMod_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoveMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.cbxNodules);
            this.Controls.Add(this.lsbModules);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.lblStuGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txbStuSurname);
            this.Controls.Add(this.lblStuDOB);
            this.Controls.Add(this.lblStuSurname);
            this.Controls.Add(this.txbStuPhone);
            this.Controls.Add(this.txbStuID);
            this.Controls.Add(this.lblStuPhone);
            this.Controls.Add(this.lblStuID);
            this.Controls.Add(this.txbStuAddress);
            this.Controls.Add(this.txbStuName);
            this.Controls.Add(this.lblStuAddress);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.pnlCreateTop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateStudent";
            this.Size = new System.Drawing.Size(835, 542);
            this.Load += new System.EventHandler(this.CreateStudent_Load);
            this.pnlCreateTop.ResumeLayout(false);
            this.pnlCreateTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateTop;
        private System.Windows.Forms.Label lblManageS;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label lblStuGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
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
        private System.Windows.Forms.ListBox lsbModules;
        private System.Windows.Forms.ComboBox cbxNodules;
        private System.Windows.Forms.Button btnAddMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveMod;
    }
}

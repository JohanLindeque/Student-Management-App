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
            this.pnlCreateTop.Name = "pnlCreateTop";
            this.pnlCreateTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlCreateTop.TabIndex = 4;
            // 
            // lblManageS
            // 
            this.lblManageS.AutoSize = true;
            this.lblManageS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageS.Location = new System.Drawing.Point(12, 25);
            this.lblManageS.Name = "lblManageS";
            this.lblManageS.Size = new System.Drawing.Size(315, 46);
            this.lblManageS.TabIndex = 0;
            this.lblManageS.Text = "Create students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(457, 494);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(179, 37);
            this.btnAddStudent.TabIndex = 20;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(515, 316);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(193, 24);
            this.cbxGender.TabIndex = 19;
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(405, 316);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(52, 16);
            this.lblStuGender.TabIndex = 18;
            this.lblStuGender.Text = "Gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(515, 264);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(193, 22);
            this.dtpDOB.TabIndex = 17;
            // 
            // txbStuSurname
            // 
            this.txbStuSurname.Location = new System.Drawing.Point(515, 216);
            this.txbStuSurname.Name = "txbStuSurname";
            this.txbStuSurname.Size = new System.Drawing.Size(193, 22);
            this.txbStuSurname.TabIndex = 12;
            // 
            // lblStuDOB
            // 
            this.lblStuDOB.AutoSize = true;
            this.lblStuDOB.Location = new System.Drawing.Point(405, 269);
            this.lblStuDOB.Name = "lblStuDOB";
            this.lblStuDOB.Size = new System.Drawing.Size(36, 16);
            this.lblStuDOB.TabIndex = 6;
            this.lblStuDOB.Text = "DOB";
            // 
            // lblStuSurname
            // 
            this.lblStuSurname.AutoSize = true;
            this.lblStuSurname.Location = new System.Drawing.Point(405, 219);
            this.lblStuSurname.Name = "lblStuSurname";
            this.lblStuSurname.Size = new System.Drawing.Size(61, 16);
            this.lblStuSurname.TabIndex = 7;
            this.lblStuSurname.Text = "Surname";
            // 
            // txbStuPhone
            // 
            this.txbStuPhone.Location = new System.Drawing.Point(515, 367);
            this.txbStuPhone.Name = "txbStuPhone";
            this.txbStuPhone.Size = new System.Drawing.Size(193, 22);
            this.txbStuPhone.TabIndex = 13;
            // 
            // txbStuID
            // 
            this.txbStuID.Location = new System.Drawing.Point(515, 136);
            this.txbStuID.Name = "txbStuID";
            this.txbStuID.Size = new System.Drawing.Size(193, 22);
            this.txbStuID.TabIndex = 14;
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(405, 367);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(46, 16);
            this.lblStuPhone.TabIndex = 8;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(405, 136);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 16);
            this.lblStuID.TabIndex = 9;
            this.lblStuID.Text = "Student ID";
            // 
            // txbStuAddress
            // 
            this.txbStuAddress.Location = new System.Drawing.Point(515, 408);
            this.txbStuAddress.Name = "txbStuAddress";
            this.txbStuAddress.Size = new System.Drawing.Size(193, 22);
            this.txbStuAddress.TabIndex = 15;
            // 
            // txbStuName
            // 
            this.txbStuName.Location = new System.Drawing.Point(515, 177);
            this.txbStuName.Name = "txbStuName";
            this.txbStuName.Size = new System.Drawing.Size(193, 22);
            this.txbStuName.TabIndex = 16;
            // 
            // lblStuAddress
            // 
            this.lblStuAddress.AutoSize = true;
            this.lblStuAddress.Location = new System.Drawing.Point(405, 408);
            this.lblStuAddress.Name = "lblStuAddress";
            this.lblStuAddress.Size = new System.Drawing.Size(58, 16);
            this.lblStuAddress.TabIndex = 10;
            this.lblStuAddress.Text = "Address";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(405, 177);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(44, 16);
            this.lblStuName.TabIndex = 11;
            this.lblStuName.Text = "Name";
            // 
            // lsbModules
            // 
            this.lsbModules.FormattingEnabled = true;
            this.lsbModules.ItemHeight = 16;
            this.lsbModules.Location = new System.Drawing.Point(862, 316);
            this.lsbModules.Name = "lsbModules";
            this.lsbModules.Size = new System.Drawing.Size(174, 84);
            this.lsbModules.TabIndex = 21;
            // 
            // cbxNodules
            // 
            this.cbxNodules.FormattingEnabled = true;
            this.cbxNodules.Location = new System.Drawing.Point(862, 261);
            this.cbxNodules.Name = "cbxNodules";
            this.cbxNodules.Size = new System.Drawing.Size(174, 24);
            this.cbxNodules.TabIndex = 22;
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(862, 421);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(75, 23);
            this.btnAddMod.TabIndex = 23;
            this.btnAddMod.Text = "Add";
            this.btnAddMod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Modules";
            // 
            // btnRemoveMod
            // 
            this.btnRemoveMod.Location = new System.Drawing.Point(943, 421);
            this.btnRemoveMod.Name = "btnRemoveMod";
            this.btnRemoveMod.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMod.TabIndex = 25;
            this.btnRemoveMod.Text = "Remove";
            this.btnRemoveMod.UseVisualStyleBackColor = true;
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "CreateStudent";
            this.Size = new System.Drawing.Size(1113, 667);
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

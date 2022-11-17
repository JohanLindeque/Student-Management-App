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
            this.pnlManageContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlManageContainer.Name = "pnlManageContainer";
            this.pnlManageContainer.Size = new System.Drawing.Size(1113, 567);
            this.pnlManageContainer.TabIndex = 4;
            this.pnlManageContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlManageContainer_Paint);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(20, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 237);
            this.panel1.TabIndex = 50;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(526, 20);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(193, 24);
            this.cbxGender.TabIndex = 49;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(39, 61);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(44, 16);
            this.lblStuName.TabIndex = 41;
            this.lblStuName.Text = "Name";
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(775, 85);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(138, 34);
            this.btnUpdateS.TabIndex = 13;
            this.btnUpdateS.Text = "Update Student";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(416, 20);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(52, 16);
            this.lblStuGender.TabIndex = 48;
            this.lblStuGender.Text = "Gender";
            // 
            // lblStuAddress
            // 
            this.lblStuAddress.AutoSize = true;
            this.lblStuAddress.Location = new System.Drawing.Point(416, 112);
            this.lblStuAddress.Name = "lblStuAddress";
            this.lblStuAddress.Size = new System.Drawing.Size(58, 16);
            this.lblStuAddress.TabIndex = 40;
            this.lblStuAddress.Text = "Address";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // txbStuName
            // 
            this.txbStuName.Location = new System.Drawing.Point(149, 61);
            this.txbStuName.Name = "txbStuName";
            this.txbStuName.Size = new System.Drawing.Size(193, 22);
            this.txbStuName.TabIndex = 46;
            // 
            // txbStuSurname
            // 
            this.txbStuSurname.Location = new System.Drawing.Point(149, 100);
            this.txbStuSurname.Name = "txbStuSurname";
            this.txbStuSurname.Size = new System.Drawing.Size(193, 22);
            this.txbStuSurname.TabIndex = 42;
            // 
            // txbStuAddress
            // 
            this.txbStuAddress.Location = new System.Drawing.Point(526, 112);
            this.txbStuAddress.Name = "txbStuAddress";
            this.txbStuAddress.Size = new System.Drawing.Size(193, 22);
            this.txbStuAddress.TabIndex = 45;
            // 
            // lblStuDOB
            // 
            this.lblStuDOB.AutoSize = true;
            this.lblStuDOB.Location = new System.Drawing.Point(39, 144);
            this.lblStuDOB.Name = "lblStuDOB";
            this.lblStuDOB.Size = new System.Drawing.Size(36, 16);
            this.lblStuDOB.TabIndex = 36;
            this.lblStuDOB.Text = "DOB";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(39, 20);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 16);
            this.lblStuID.TabIndex = 39;
            this.lblStuID.Text = "Student ID";
            // 
            // lblStuSurname
            // 
            this.lblStuSurname.AutoSize = true;
            this.lblStuSurname.Location = new System.Drawing.Point(39, 103);
            this.lblStuSurname.Name = "lblStuSurname";
            this.lblStuSurname.Size = new System.Drawing.Size(61, 16);
            this.lblStuSurname.TabIndex = 37;
            this.lblStuSurname.Text = "Surname";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(416, 71);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(46, 16);
            this.lblStuPhone.TabIndex = 38;
            this.lblStuPhone.Text = "Phone";
            // 
            // txbStuPhone
            // 
            this.txbStuPhone.Location = new System.Drawing.Point(526, 71);
            this.txbStuPhone.Name = "txbStuPhone";
            this.txbStuPhone.Size = new System.Drawing.Size(193, 22);
            this.txbStuPhone.TabIndex = 43;
            // 
            // txbStuID
            // 
            this.txbStuID.Location = new System.Drawing.Point(149, 20);
            this.txbStuID.Name = "txbStuID";
            this.txbStuID.Size = new System.Drawing.Size(193, 22);
            this.txbStuID.TabIndex = 44;
            // 
            // dgvManageStudent
            // 
            this.dgvManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageStudent.Location = new System.Drawing.Point(304, 40);
            this.dgvManageStudent.Name = "dgvManageStudent";
            this.dgvManageStudent.RowHeadersWidth = 51;
            this.dgvManageStudent.RowTemplate.Height = 24;
            this.dgvManageStudent.Size = new System.Drawing.Size(771, 174);
            this.dgvManageStudent.TabIndex = 14;
            this.dgvManageStudent.SelectionChanged += new System.EventHandler(this.dgvManageStudent_SelectionChanged);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(62, 180);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(138, 34);
            this.btnDeleteS.TabIndex = 13;
            this.btnDeleteS.Text = "Delete Student";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(62, 120);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(138, 27);
            this.btnSearchStudent.TabIndex = 11;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txbSearchStudent
            // 
            this.txbSearchStudent.Location = new System.Drawing.Point(39, 72);
            this.txbSearchStudent.Name = "txbSearchStudent";
            this.txbSearchStudent.Size = new System.Drawing.Size(192, 22);
            this.txbSearchStudent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by Student ID";
            // 
            // lblManageS
            // 
            this.lblManageS.AutoSize = true;
            this.lblManageS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageS.Location = new System.Drawing.Point(12, 25);
            this.lblManageS.Name = "lblManageS";
            this.lblManageS.Size = new System.Drawing.Size(339, 46);
            this.lblManageS.TabIndex = 0;
            this.lblManageS.Text = "Manage students";
            // 
            // pnlManageTop
            // 
            this.pnlManageTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlManageTop.Controls.Add(this.lblManageS);
            this.pnlManageTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageTop.Location = new System.Drawing.Point(0, 0);
            this.pnlManageTop.Name = "pnlManageTop";
            this.pnlManageTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlManageTop.TabIndex = 3;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageContainer);
            this.Controls.Add(this.pnlManageTop);
            this.Name = "ManageStudent";
            this.Size = new System.Drawing.Size(1113, 667);
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
    }
}

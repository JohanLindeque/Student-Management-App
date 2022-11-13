namespace Project_PRG_282
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnMangeModules = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudent.Location = new System.Drawing.Point(18, 217);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(176, 53);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStudent.Location = new System.Drawing.Point(18, 129);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(176, 53);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Students & Modules";
            this.btnViewStudent.UseVisualStyleBackColor = false;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageStudents.Location = new System.Drawing.Point(18, 276);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(176, 53);
            this.btnManageStudents.TabIndex = 0;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlNav.Controls.Add(this.btnLogOut);
            this.pnlNav.Controls.Add(this.btnAddModule);
            this.pnlNav.Controls.Add(this.btnMangeModules);
            this.pnlNav.Controls.Add(this.btnViewStudent);
            this.pnlNav.Controls.Add(this.btnAddStudent);
            this.pnlNav.Controls.Add(this.btnManageStudents);
            this.pnlNav.Location = new System.Drawing.Point(-6, -8);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(213, 675);
            this.pnlNav.TabIndex = 2;
            // 
            // btnAddModule
            // 
            this.btnAddModule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddModule.Location = new System.Drawing.Point(18, 376);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(176, 53);
            this.btnAddModule.TabIndex = 2;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = false;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnMangeModules
            // 
            this.btnMangeModules.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMangeModules.Location = new System.Drawing.Point(18, 435);
            this.btnMangeModules.Name = "btnMangeModules";
            this.btnMangeModules.Size = new System.Drawing.Size(176, 53);
            this.btnMangeModules.TabIndex = 3;
            this.btnMangeModules.Text = "Manage Modules";
            this.btnMangeModules.UseVisualStyleBackColor = false;
            this.btnMangeModules.Click += new System.EventHandler(this.btnMangeModules_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(208, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1113, 667);
            this.pnlMain.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(18, 577);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(176, 50);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 665);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNav);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnMangeModules;
        private System.Windows.Forms.Button btnLogOut;
    }
}
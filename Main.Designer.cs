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
            this.button4 = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudent.Location = new System.Drawing.Point(18, 146);
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
            this.btnViewStudent.Location = new System.Drawing.Point(18, 205);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(176, 53);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View students";
            this.btnViewStudent.UseVisualStyleBackColor = false;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnManageStudents.Location = new System.Drawing.Point(18, 264);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(176, 53);
            this.btnManageStudents.TabIndex = 0;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(18, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 53);
            this.button4.TabIndex = 1;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.LightGreen;
            this.pnlNav.Controls.Add(this.btnViewStudent);
            this.pnlNav.Controls.Add(this.button4);
            this.pnlNav.Controls.Add(this.btnAddStudent);
            this.pnlNav.Controls.Add(this.btnManageStudents);
            this.pnlNav.Location = new System.Drawing.Point(-6, -8);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(213, 675);
            this.pnlNav.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(208, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1113, 667);
            this.pnlMain.TabIndex = 3;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlMain;
    }
}
namespace Project_PRG_282.Controls
{
    partial class AddModule
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
            this.btnAddModule = new System.Windows.Forms.Button();
            this.lblModuleDescription = new System.Windows.Forms.Label();
            this.txbModuleCode = new System.Windows.Forms.TextBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.txbModuleLink = new System.Windows.Forms.TextBox();
            this.txbModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleResource = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.pnlCreateMTop = new System.Windows.Forms.Panel();
            this.lblManageM = new System.Windows.Forms.Label();
            this.rtbModuleDes = new System.Windows.Forms.RichTextBox();
            this.pnlCreateMTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(328, 450);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(179, 37);
            this.btnAddModule.TabIndex = 36;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            // 
            // lblModuleDescription
            // 
            this.lblModuleDescription.AutoSize = true;
            this.lblModuleDescription.Location = new System.Drawing.Point(566, 165);
            this.lblModuleDescription.Name = "lblModuleDescription";
            this.lblModuleDescription.Size = new System.Drawing.Size(123, 16);
            this.lblModuleDescription.TabIndex = 23;
            this.lblModuleDescription.Text = "Module Description";
            // 
            // txbModuleCode
            // 
            this.txbModuleCode.Location = new System.Drawing.Point(156, 165);
            this.txbModuleCode.Name = "txbModuleCode";
            this.txbModuleCode.Size = new System.Drawing.Size(193, 22);
            this.txbModuleCode.TabIndex = 30;
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(46, 165);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(88, 16);
            this.lblModuleCode.TabIndex = 25;
            this.lblModuleCode.Text = "Module Code";
            // 
            // txbModuleLink
            // 
            this.txbModuleLink.Location = new System.Drawing.Point(156, 312);
            this.txbModuleLink.Name = "txbModuleLink";
            this.txbModuleLink.Size = new System.Drawing.Size(193, 22);
            this.txbModuleLink.TabIndex = 31;
            // 
            // txbModuleName
            // 
            this.txbModuleName.Location = new System.Drawing.Point(156, 239);
            this.txbModuleName.Name = "txbModuleName";
            this.txbModuleName.Size = new System.Drawing.Size(193, 22);
            this.txbModuleName.TabIndex = 32;
            // 
            // lblModuleResource
            // 
            this.lblModuleResource.AutoSize = true;
            this.lblModuleResource.Location = new System.Drawing.Point(46, 312);
            this.lblModuleResource.Name = "lblModuleResource";
            this.lblModuleResource.Size = new System.Drawing.Size(66, 16);
            this.lblModuleResource.TabIndex = 26;
            this.lblModuleResource.Text = "Resource";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(46, 239);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(44, 16);
            this.lblModuleName.TabIndex = 27;
            this.lblModuleName.Text = "Name";
            // 
            // pnlCreateMTop
            // 
            this.pnlCreateMTop.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlCreateMTop.Controls.Add(this.lblManageM);
            this.pnlCreateMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateMTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateMTop.Name = "pnlCreateMTop";
            this.pnlCreateMTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlCreateMTop.TabIndex = 21;
            // 
            // lblManageM
            // 
            this.lblManageM.AutoSize = true;
            this.lblManageM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageM.Location = new System.Drawing.Point(12, 25);
            this.lblManageM.Name = "lblManageM";
            this.lblManageM.Size = new System.Drawing.Size(294, 46);
            this.lblManageM.TabIndex = 0;
            this.lblManageM.Text = "Create Module";
            // 
            // rtbModuleDes
            // 
            this.rtbModuleDes.Location = new System.Drawing.Point(569, 196);
            this.rtbModuleDes.Name = "rtbModuleDes";
            this.rtbModuleDes.Size = new System.Drawing.Size(320, 180);
            this.rtbModuleDes.TabIndex = 37;
            this.rtbModuleDes.Text = "";
            // 
            // AddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbModuleDes);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.lblModuleDescription);
            this.Controls.Add(this.txbModuleCode);
            this.Controls.Add(this.lblModuleCode);
            this.Controls.Add(this.txbModuleLink);
            this.Controls.Add(this.txbModuleName);
            this.Controls.Add(this.lblModuleResource);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.pnlCreateMTop);
            this.Name = "AddModule";
            this.Size = new System.Drawing.Size(1113, 667);
            this.pnlCreateMTop.ResumeLayout(false);
            this.pnlCreateMTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Label lblModuleDescription;
        private System.Windows.Forms.TextBox txbModuleCode;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.TextBox txbModuleLink;
        private System.Windows.Forms.TextBox txbModuleName;
        private System.Windows.Forms.Label lblModuleResource;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Panel pnlCreateMTop;
        private System.Windows.Forms.Label lblManageM;
        private System.Windows.Forms.RichTextBox rtbModuleDes;
    }
}

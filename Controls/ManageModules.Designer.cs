namespace Project_PRG_282.Controls
{
    partial class ManageModules
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
            this.rtbModDesc = new System.Windows.Forms.RichTextBox();
            this.lblModuleDescription = new System.Windows.Forms.Label();
            this.txbModuleCode = new System.Windows.Forms.TextBox();
            this.lblModuleCode = new System.Windows.Forms.Label();
            this.txbModuleLink = new System.Windows.Forms.TextBox();
            this.txbModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleResource = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.dgvManageModule = new System.Windows.Forms.DataGridView();
            this.btnUpdateM = new System.Windows.Forms.Button();
            this.btnDeleteM = new System.Windows.Forms.Button();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.txbSearchModule = new System.Windows.Forms.TextBox();
            this.lblSearchM = new System.Windows.Forms.Label();
            this.pnlManageMTop = new System.Windows.Forms.Panel();
            this.lblManageM = new System.Windows.Forms.Label();
            this.pnlManageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageModule)).BeginInit();
            this.pnlManageMTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageContainer
            // 
            this.pnlManageContainer.Controls.Add(this.rtbModDesc);
            this.pnlManageContainer.Controls.Add(this.lblModuleDescription);
            this.pnlManageContainer.Controls.Add(this.txbModuleCode);
            this.pnlManageContainer.Controls.Add(this.lblModuleCode);
            this.pnlManageContainer.Controls.Add(this.txbModuleLink);
            this.pnlManageContainer.Controls.Add(this.txbModuleName);
            this.pnlManageContainer.Controls.Add(this.lblModuleResource);
            this.pnlManageContainer.Controls.Add(this.lblModuleName);
            this.pnlManageContainer.Controls.Add(this.dgvManageModule);
            this.pnlManageContainer.Controls.Add(this.btnUpdateM);
            this.pnlManageContainer.Controls.Add(this.btnDeleteM);
            this.pnlManageContainer.Controls.Add(this.btnSearchModule);
            this.pnlManageContainer.Controls.Add(this.txbSearchModule);
            this.pnlManageContainer.Controls.Add(this.lblSearchM);
            this.pnlManageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlManageContainer.Name = "pnlManageContainer";
            this.pnlManageContainer.Size = new System.Drawing.Size(1113, 576);
            this.pnlManageContainer.TabIndex = 6;
            // 
            // rtbModDesc
            // 
            this.rtbModDesc.Location = new System.Drawing.Point(842, 195);
            this.rtbModDesc.Name = "rtbModDesc";
            this.rtbModDesc.Size = new System.Drawing.Size(193, 181);
            this.rtbModDesc.TabIndex = 40;
            this.rtbModDesc.Text = "";
            // 
            // lblModuleDescription
            // 
            this.lblModuleDescription.AutoSize = true;
            this.lblModuleDescription.Location = new System.Drawing.Point(735, 195);
            this.lblModuleDescription.Name = "lblModuleDescription";
            this.lblModuleDescription.Size = new System.Drawing.Size(75, 16);
            this.lblModuleDescription.TabIndex = 39;
            this.lblModuleDescription.Text = "Description";
            // 
            // txbModuleCode
            // 
            this.txbModuleCode.Location = new System.Drawing.Point(842, 57);
            this.txbModuleCode.Name = "txbModuleCode";
            this.txbModuleCode.Size = new System.Drawing.Size(193, 22);
            this.txbModuleCode.TabIndex = 36;
            // 
            // lblModuleCode
            // 
            this.lblModuleCode.AutoSize = true;
            this.lblModuleCode.Location = new System.Drawing.Point(732, 57);
            this.lblModuleCode.Name = "lblModuleCode";
            this.lblModuleCode.Size = new System.Drawing.Size(88, 16);
            this.lblModuleCode.TabIndex = 33;
            this.lblModuleCode.Text = "Module Code";
            // 
            // txbModuleLink
            // 
            this.txbModuleLink.Location = new System.Drawing.Point(842, 147);
            this.txbModuleLink.Name = "txbModuleLink";
            this.txbModuleLink.Size = new System.Drawing.Size(193, 22);
            this.txbModuleLink.TabIndex = 37;
            // 
            // txbModuleName
            // 
            this.txbModuleName.Location = new System.Drawing.Point(842, 100);
            this.txbModuleName.Name = "txbModuleName";
            this.txbModuleName.Size = new System.Drawing.Size(193, 22);
            this.txbModuleName.TabIndex = 38;
            // 
            // lblModuleResource
            // 
            this.lblModuleResource.AutoSize = true;
            this.lblModuleResource.Location = new System.Drawing.Point(732, 147);
            this.lblModuleResource.Name = "lblModuleResource";
            this.lblModuleResource.Size = new System.Drawing.Size(66, 16);
            this.lblModuleResource.TabIndex = 34;
            this.lblModuleResource.Text = "Resource";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Location = new System.Drawing.Point(732, 100);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(44, 16);
            this.lblModuleName.TabIndex = 35;
            this.lblModuleName.Text = "Name";
            // 
            // dgvManageModule
            // 
            this.dgvManageModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageModule.Location = new System.Drawing.Point(304, 46);
            this.dgvManageModule.Name = "dgvManageModule";
            this.dgvManageModule.RowHeadersWidth = 51;
            this.dgvManageModule.RowTemplate.Height = 24;
            this.dgvManageModule.Size = new System.Drawing.Size(390, 447);
            this.dgvManageModule.TabIndex = 14;
            this.dgvManageModule.SelectionChanged += new System.EventHandler(this.dgvManageModule_SelectionChanged);
            // 
            // btnUpdateM
            // 
            this.btnUpdateM.Location = new System.Drawing.Point(926, 424);
            this.btnUpdateM.Name = "btnUpdateM";
            this.btnUpdateM.Size = new System.Drawing.Size(120, 53);
            this.btnUpdateM.TabIndex = 13;
            this.btnUpdateM.Text = "Update Module";
            this.btnUpdateM.UseVisualStyleBackColor = true;
            this.btnUpdateM.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnDeleteM
            // 
            this.btnDeleteM.Location = new System.Drawing.Point(780, 424);
            this.btnDeleteM.Name = "btnDeleteM";
            this.btnDeleteM.Size = new System.Drawing.Size(115, 53);
            this.btnDeleteM.TabIndex = 13;
            this.btnDeleteM.Text = "Delete Module";
            this.btnDeleteM.UseVisualStyleBackColor = true;
            this.btnDeleteM.Click += new System.EventHandler(this.btnDeleteM_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Location = new System.Drawing.Point(87, 120);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(97, 23);
            this.btnSearchModule.TabIndex = 11;
            this.btnSearchModule.Text = "Search";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // txbSearchModule
            // 
            this.txbSearchModule.Location = new System.Drawing.Point(39, 72);
            this.txbSearchModule.Name = "txbSearchModule";
            this.txbSearchModule.Size = new System.Drawing.Size(192, 22);
            this.txbSearchModule.TabIndex = 10;
            // 
            // lblSearchM
            // 
            this.lblSearchM.AutoSize = true;
            this.lblSearchM.Location = new System.Drawing.Point(36, 40);
            this.lblSearchM.Name = "lblSearchM";
            this.lblSearchM.Size = new System.Drawing.Size(152, 16);
            this.lblSearchM.TabIndex = 9;
            this.lblSearchM.Text = "Search by Module Code";
            // 
            // pnlManageMTop
            // 
            this.pnlManageMTop.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlManageMTop.Controls.Add(this.lblManageM);
            this.pnlManageMTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageMTop.Location = new System.Drawing.Point(0, 0);
            this.pnlManageMTop.Name = "pnlManageMTop";
            this.pnlManageMTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlManageMTop.TabIndex = 5;
            // 
            // lblManageM
            // 
            this.lblManageM.AutoSize = true;
            this.lblManageM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageM.Location = new System.Drawing.Point(12, 25);
            this.lblManageM.Name = "lblManageM";
            this.lblManageM.Size = new System.Drawing.Size(339, 46);
            this.lblManageM.TabIndex = 0;
            this.lblManageM.Text = "Manage modules";
            // 
            // ManageModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageContainer);
            this.Controls.Add(this.pnlManageMTop);
            this.Name = "ManageModules";
            this.Size = new System.Drawing.Size(1113, 676);
            this.Load += new System.EventHandler(this.ManageModules_Load);
            this.pnlManageContainer.ResumeLayout(false);
            this.pnlManageContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageModule)).EndInit();
            this.pnlManageMTop.ResumeLayout(false);
            this.pnlManageMTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageContainer;
        private System.Windows.Forms.DataGridView dgvManageModule;
        private System.Windows.Forms.Button btnUpdateM;
        private System.Windows.Forms.Button btnDeleteM;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.TextBox txbSearchModule;
        private System.Windows.Forms.Label lblSearchM;
        private System.Windows.Forms.Panel pnlManageMTop;
        private System.Windows.Forms.Label lblManageM;
        private System.Windows.Forms.TextBox txbModuleCode;
        private System.Windows.Forms.Label lblModuleCode;
        private System.Windows.Forms.TextBox txbModuleLink;
        private System.Windows.Forms.TextBox txbModuleName;
        private System.Windows.Forms.Label lblModuleResource;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.RichTextBox rtbModDesc;
        private System.Windows.Forms.Label lblModuleDescription;
    }
}

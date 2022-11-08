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
            this.lblManageS = new System.Windows.Forms.Label();
            this.pnlManageTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlManageContainer.SuspendLayout();
            this.pnlManageTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageContainer
            // 
            this.pnlManageContainer.Controls.Add(this.button2);
            this.pnlManageContainer.Controls.Add(this.button1);
            this.pnlManageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlManageContainer.Name = "pnlManageContainer";
            this.pnlManageContainer.Size = new System.Drawing.Size(1113, 567);
            this.pnlManageContainer.TabIndex = 4;
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
            this.pnlManageTop.BackColor = System.Drawing.Color.Yellow;
            this.pnlManageTop.Controls.Add(this.lblManageS);
            this.pnlManageTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageTop.Location = new System.Drawing.Point(0, 0);
            this.pnlManageTop.Name = "pnlManageTop";
            this.pnlManageTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlManageTop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 53);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlManageContainer);
            this.Controls.Add(this.pnlManageTop);
            this.Name = "ManageStudent";
            this.Size = new System.Drawing.Size(1113, 667);
            this.pnlManageContainer.ResumeLayout(false);
            this.pnlManageTop.ResumeLayout(false);
            this.pnlManageTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageContainer;
        private System.Windows.Forms.Label lblManageS;
        private System.Windows.Forms.Panel pnlManageTop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

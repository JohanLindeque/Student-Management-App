namespace Project_PRG_282.Controls
{
    partial class ViewStudent
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
            this.pnlViewTop = new System.Windows.Forms.Panel();
            this.lblNewS = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlViewTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewTop
            // 
            this.pnlViewTop.BackColor = System.Drawing.Color.Turquoise;
            this.pnlViewTop.Controls.Add(this.lblNewS);
            this.pnlViewTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewTop.Location = new System.Drawing.Point(0, 0);
            this.pnlViewTop.Name = "pnlViewTop";
            this.pnlViewTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlViewTop.TabIndex = 2;
            // 
            // lblNewS
            // 
            this.lblNewS.AutoSize = true;
            this.lblNewS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewS.Location = new System.Drawing.Point(12, 25);
            this.lblNewS.Name = "lblNewS";
            this.lblNewS.Size = new System.Drawing.Size(336, 46);
            this.lblNewS.TabIndex = 0;
            this.lblNewS.Text = "View all students";
            this.lblNewS.Click += new System.EventHandler(this.lblNewS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 189);
            this.dataGridView1.TabIndex = 3;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlViewTop);
            this.Name = "ViewStudent";
            this.Size = new System.Drawing.Size(1113, 667);
            this.pnlViewTop.ResumeLayout(false);
            this.pnlViewTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewTop;
        private System.Windows.Forms.Label lblNewS;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

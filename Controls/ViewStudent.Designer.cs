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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlViewTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewTop
            // 
            this.pnlViewTop.BackColor = System.Drawing.Color.Orange;
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
            this.lblNewS.Size = new System.Drawing.Size(496, 46);
            this.lblNewS.TabIndex = 0;
            this.lblNewS.Text = "All Students and Modules";
            this.lblNewS.Click += new System.EventHandler(this.lblNewS_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(36, 157);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(1042, 273);
            this.dgvStudents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modules";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 472);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 155);
            this.dataGridView1.TabIndex = 6;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlViewTop);
            this.Name = "ViewStudent";
            this.Size = new System.Drawing.Size(1113, 667);
            this.pnlViewTop.ResumeLayout(false);
            this.pnlViewTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewTop;
        private System.Windows.Forms.Label lblNewS;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

namespace Project_PRG_282.Controls
{
    partial class NewStudent
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
            this.lblNewS = new System.Windows.Forms.Label();
            this.pnlCreateTop = new System.Windows.Forms.Panel();
            this.pnlCreateContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.pnlCreateTop.SuspendLayout();
            this.pnlCreateContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewS
            // 
            this.lblNewS.AutoSize = true;
            this.lblNewS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewS.Location = new System.Drawing.Point(12, 25);
            this.lblNewS.Name = "lblNewS";
            this.lblNewS.Size = new System.Drawing.Size(382, 46);
            this.lblNewS.TabIndex = 0;
            this.lblNewS.Text = "Create new student";
            this.lblNewS.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlCreateTop
            // 
            this.pnlCreateTop.BackColor = System.Drawing.Color.Coral;
            this.pnlCreateTop.Controls.Add(this.lblNewS);
            this.pnlCreateTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateTop.Name = "pnlCreateTop";
            this.pnlCreateTop.Size = new System.Drawing.Size(1113, 100);
            this.pnlCreateTop.TabIndex = 1;
            // 
            // pnlCreateContainer
            // 
            this.pnlCreateContainer.Controls.Add(this.btnNewStudent);
            this.pnlCreateContainer.Controls.Add(this.textBox4);
            this.pnlCreateContainer.Controls.Add(this.label4);
            this.pnlCreateContainer.Controls.Add(this.textBox3);
            this.pnlCreateContainer.Controls.Add(this.label3);
            this.pnlCreateContainer.Controls.Add(this.textBox2);
            this.pnlCreateContainer.Controls.Add(this.label2);
            this.pnlCreateContainer.Controls.Add(this.textBox1);
            this.pnlCreateContainer.Controls.Add(this.label1);
            this.pnlCreateContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlCreateContainer.Name = "pnlCreateContainer";
            this.pnlCreateContainer.Size = new System.Drawing.Size(1113, 567);
            this.pnlCreateContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "DOB";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 22);
            this.textBox4.TabIndex = 1;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(147, 353);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(214, 45);
            this.btnNewStudent.TabIndex = 2;
            this.btnNewStudent.Text = "Submit";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            // 
            // NewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCreateContainer);
            this.Controls.Add(this.pnlCreateTop);
            this.Name = "NewStudent";
            this.Size = new System.Drawing.Size(1113, 667);
            this.pnlCreateTop.ResumeLayout(false);
            this.pnlCreateTop.PerformLayout();
            this.pnlCreateContainer.ResumeLayout(false);
            this.pnlCreateContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewS;
        private System.Windows.Forms.Panel pnlCreateTop;
        private System.Windows.Forms.Panel pnlCreateContainer;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

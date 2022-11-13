namespace Project_PRG_282
{
    partial class Login
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
            this.pnlUserOptions = new System.Windows.Forms.Panel();
            this.lblSignup = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlUserOptions
            // 
            this.pnlUserOptions.Location = new System.Drawing.Point(-5, -4);
            this.pnlUserOptions.Name = "pnlUserOptions";
            this.pnlUserOptions.Size = new System.Drawing.Size(652, 442);
            this.pnlUserOptions.TabIndex = 1;
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Location = new System.Drawing.Point(577, 445);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(52, 16);
            this.lblSignup.TabIndex = 2;
            this.lblSignup.Text = "SignUp";
            this.lblSignup.Click += new System.EventHandler(this.lblSignup_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(522, 444);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 16);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(129, 445);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 23);
            this.btnMain.TabIndex = 4;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 466);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.pnlUserOptions);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlUserOptions;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnMain;
    }
}


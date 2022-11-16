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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserOptions
            // 
            this.pnlUserOptions.Controls.Add(this.label1);
            this.pnlUserOptions.Controls.Add(this.btnLogin);
            this.pnlUserOptions.Controls.Add(this.txbPassword);
            this.pnlUserOptions.Controls.Add(this.lblPassword);
            this.pnlUserOptions.Controls.Add(this.txbUsername);
            this.pnlUserOptions.Controls.Add(this.lblUsername);
            this.pnlUserOptions.Location = new System.Drawing.Point(-5, -4);
            this.pnlUserOptions.Name = "pnlUserOptions";
            this.pnlUserOptions.Size = new System.Drawing.Size(652, 442);
            this.pnlUserOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 54);
            this.label1.TabIndex = 22;
            this.label1.Text = "LogIn";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(218, 347);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 34);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(230, 288);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(196, 22);
            this.txbPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(227, 257);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(230, 202);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(196, 22);
            this.txbUsername.TabIndex = 18;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(227, 171);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Location = new System.Drawing.Point(557, 441);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(52, 16);
            this.lblSignup.TabIndex = 2;
            this.lblSignup.Text = "SignUp";
            this.lblSignup.Click += new System.EventHandler(this.lblSignup_Click);
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
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.pnlUserOptions);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlUserOptions.ResumeLayout(false);
            this.pnlUserOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlUserOptions;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}


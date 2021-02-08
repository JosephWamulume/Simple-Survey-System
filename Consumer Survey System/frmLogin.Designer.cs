namespace Consumer_Survey_System
{
    partial class frmLogin
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
            System.Windows.Forms.LinkLabel linklblRegister;
            this.pbxHidePassword = new System.Windows.Forms.PictureBox();
            this.pbxViewPassword = new System.Windows.Forms.PictureBox();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            linklblRegister = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxHidePassword
            // 
            this.pbxHidePassword.Location = new System.Drawing.Point(19, 174);
            this.pbxHidePassword.Name = "pbxHidePassword";
            this.pbxHidePassword.Size = new System.Drawing.Size(25, 24);
            this.pbxHidePassword.TabIndex = 21;
            this.pbxHidePassword.TabStop = false;
            this.pbxHidePassword.Visible = false;
            // 
            // pbxViewPassword
            // 
            this.pbxViewPassword.Location = new System.Drawing.Point(19, 174);
            this.pbxViewPassword.Name = "pbxViewPassword";
            this.pbxViewPassword.Size = new System.Drawing.Size(25, 24);
            this.pbxViewPassword.TabIndex = 20;
            this.pbxViewPassword.TabStop = false;
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblLoginHeader.Location = new System.Drawing.Point(94, 21);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(98, 27);
            this.lblLoginHeader.TabIndex = 19;
            this.lblLoginHeader.Text = "LOGIN";
            this.lblLoginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRegister.Location = new System.Drawing.Point(47, 249);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(120, 12);
            this.lblRegister.TabIndex = 18;
            this.lblRegister.Text = "Don\'t have an account?";
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.Font = new System.Drawing.Font("SansSerif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            linklblRegister.Location = new System.Drawing.Point(167, 249);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new System.Drawing.Size(46, 12);
            linklblRegister.TabIndex = 17;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Register";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLogin.Location = new System.Drawing.Point(19, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(243, 26);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPassword.Location = new System.Drawing.Point(19, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPassword.Location = new System.Drawing.Point(19, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(243, 25);
            this.txtPassword.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblEmail.Location = new System.Drawing.Point(19, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtEmail.Location = new System.Drawing.Point(19, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 25);
            this.txtEmail.TabIndex = 13;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 282);
            this.Controls.Add(this.pbxHidePassword);
            this.Controls.Add(this.pbxViewPassword);
            this.Controls.Add(this.lblLoginHeader);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(linklblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Name = "frmLogin";
            this.Text = "Consumer Survey System";
            ((System.ComponentModel.ISupportInitialize)(this.pbxHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHidePassword;
        private System.Windows.Forms.PictureBox pbxViewPassword;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
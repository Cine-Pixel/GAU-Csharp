
namespace BankManagement {
    partial class Login {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.tbLoginPass = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(151, 124);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(151, 173);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 20);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(294, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 34);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginEmail.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginEmail.ForeColor = System.Drawing.Color.White;
            this.tbLoginEmail.Location = new System.Drawing.Point(155, 147);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(389, 20);
            this.tbLoginEmail.TabIndex = 2;
            // 
            // tbLoginPass
            // 
            this.tbLoginPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbLoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLoginPass.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPass.ForeColor = System.Drawing.Color.White;
            this.tbLoginPass.Location = new System.Drawing.Point(155, 196);
            this.tbLoginPass.Name = "tbLoginPass";
            this.tbLoginPass.Size = new System.Drawing.Size(389, 20);
            this.tbLoginPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login to BM";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoginPass);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(683, 453);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.MaskedTextBox tbLoginPass;
        private System.Windows.Forms.Label label1;
    }
}

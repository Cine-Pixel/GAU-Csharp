
namespace BankManagement {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelNavContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSignedInBankir = new System.Windows.Forms.Panel();
            this.btnReportPage = new System.Windows.Forms.Button();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.btnDepositRequests = new System.Windows.Forms.Button();
            this.btnLoanRequests = new System.Windows.Forms.Button();
            this.panelSignedIn = new System.Windows.Forms.Panel();
            this.btnMakeDeposit = new System.Windows.Forms.Button();
            this.btnGetLoan = new System.Windows.Forms.Button();
            this.panelSignedOut = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.login1 = new BankManagement.Login();
            this.register1 = new BankManagement.Register();
            this.loan1 = new BankManagement.Loan();
            this.bankirDashboard1 = new BankManagement.BankirDashboard();
            this.depositPage1 = new BankManagement.DepositPage();
            this.bankirDepositsDashboard1 = new BankManagement.BankirDepositsDashboard();
            this.searchPage1 = new BankManagement.SearchPage();
            this.btnDeleteMyself = new System.Windows.Forms.Button();
            this.panelNavContainer.SuspendLayout();
            this.panelSignedInBankir.SuspendLayout();
            this.panelSignedIn.SuspendLayout();
            this.panelSignedOut.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavContainer
            // 
            this.panelNavContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelNavContainer.Controls.Add(this.panel2);
            this.panelNavContainer.Controls.Add(this.panelSignedInBankir);
            this.panelNavContainer.Controls.Add(this.panelSignedIn);
            this.panelNavContainer.Controls.Add(this.panelSignedOut);
            this.panelNavContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavContainer.Location = new System.Drawing.Point(0, 0);
            this.panelNavContainer.Name = "panelNavContainer";
            this.panelNavContainer.Size = new System.Drawing.Size(176, 453);
            this.panelNavContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(176, 116);
            this.panel2.TabIndex = 0;
            // 
            // panelSignedInBankir
            // 
            this.panelSignedInBankir.Controls.Add(this.btnDeleteMyself);
            this.panelSignedInBankir.Controls.Add(this.btnReportPage);
            this.panelSignedInBankir.Controls.Add(this.btnSearchPage);
            this.panelSignedInBankir.Controls.Add(this.btnDepositRequests);
            this.panelSignedInBankir.Controls.Add(this.btnLoanRequests);
            this.panelSignedInBankir.Location = new System.Drawing.Point(0, 116);
            this.panelSignedInBankir.Name = "panelSignedInBankir";
            this.panelSignedInBankir.Size = new System.Drawing.Size(176, 337);
            this.panelSignedInBankir.TabIndex = 5;
            // 
            // btnReportPage
            // 
            this.btnReportPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportPage.FlatAppearance.BorderSize = 0;
            this.btnReportPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPage.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPage.ForeColor = System.Drawing.Color.White;
            this.btnReportPage.Location = new System.Drawing.Point(0, 151);
            this.btnReportPage.Name = "btnReportPage";
            this.btnReportPage.Size = new System.Drawing.Size(176, 47);
            this.btnReportPage.TabIndex = 0;
            this.btnReportPage.Text = "Reports";
            this.btnReportPage.UseVisualStyleBackColor = true;
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPage.FlatAppearance.BorderSize = 0;
            this.btnSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPage.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPage.ForeColor = System.Drawing.Color.White;
            this.btnSearchPage.Location = new System.Drawing.Point(0, 96);
            this.btnSearchPage.Name = "btnSearchPage";
            this.btnSearchPage.Size = new System.Drawing.Size(176, 47);
            this.btnSearchPage.TabIndex = 0;
            this.btnSearchPage.Text = "Search";
            this.btnSearchPage.UseVisualStyleBackColor = true;
            this.btnSearchPage.Click += new System.EventHandler(this.btnSearchPage_Click);
            // 
            // btnDepositRequests
            // 
            this.btnDepositRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepositRequests.FlatAppearance.BorderSize = 0;
            this.btnDepositRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositRequests.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositRequests.ForeColor = System.Drawing.Color.White;
            this.btnDepositRequests.Location = new System.Drawing.Point(0, 50);
            this.btnDepositRequests.Name = "btnDepositRequests";
            this.btnDepositRequests.Size = new System.Drawing.Size(176, 47);
            this.btnDepositRequests.TabIndex = 0;
            this.btnDepositRequests.Text = "Deposit Requests";
            this.btnDepositRequests.UseVisualStyleBackColor = true;
            this.btnDepositRequests.Click += new System.EventHandler(this.btnDepositRequests_Click);
            // 
            // btnLoanRequests
            // 
            this.btnLoanRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoanRequests.FlatAppearance.BorderSize = 0;
            this.btnLoanRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanRequests.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanRequests.ForeColor = System.Drawing.Color.White;
            this.btnLoanRequests.Location = new System.Drawing.Point(0, 0);
            this.btnLoanRequests.Name = "btnLoanRequests";
            this.btnLoanRequests.Size = new System.Drawing.Size(176, 47);
            this.btnLoanRequests.TabIndex = 0;
            this.btnLoanRequests.Text = "Loan Requests";
            this.btnLoanRequests.UseVisualStyleBackColor = true;
            this.btnLoanRequests.Click += new System.EventHandler(this.btnLoanRequests_Click);
            // 
            // panelSignedIn
            // 
            this.panelSignedIn.Controls.Add(this.btnMakeDeposit);
            this.panelSignedIn.Controls.Add(this.btnGetLoan);
            this.panelSignedIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignedIn.Location = new System.Drawing.Point(0, 0);
            this.panelSignedIn.Name = "panelSignedIn";
            this.panelSignedIn.Size = new System.Drawing.Size(176, 453);
            this.panelSignedIn.TabIndex = 4;
            // 
            // btnMakeDeposit
            // 
            this.btnMakeDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnMakeDeposit.FlatAppearance.BorderSize = 0;
            this.btnMakeDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeDeposit.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDeposit.ForeColor = System.Drawing.Color.White;
            this.btnMakeDeposit.Location = new System.Drawing.Point(0, 57);
            this.btnMakeDeposit.Name = "btnMakeDeposit";
            this.btnMakeDeposit.Size = new System.Drawing.Size(176, 48);
            this.btnMakeDeposit.TabIndex = 0;
            this.btnMakeDeposit.Text = "Make Deposit";
            this.btnMakeDeposit.UseVisualStyleBackColor = false;
            this.btnMakeDeposit.Click += new System.EventHandler(this.btnMakeDeposit_Click);
            // 
            // btnGetLoan
            // 
            this.btnGetLoan.BackColor = System.Drawing.Color.Transparent;
            this.btnGetLoan.FlatAppearance.BorderSize = 0;
            this.btnGetLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLoan.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLoan.ForeColor = System.Drawing.Color.White;
            this.btnGetLoan.Location = new System.Drawing.Point(0, 3);
            this.btnGetLoan.Name = "btnGetLoan";
            this.btnGetLoan.Size = new System.Drawing.Size(176, 48);
            this.btnGetLoan.TabIndex = 0;
            this.btnGetLoan.Text = "Get Loan";
            this.btnGetLoan.UseVisualStyleBackColor = false;
            this.btnGetLoan.Click += new System.EventHandler(this.btnGetLoan_Click);
            // 
            // panelSignedOut
            // 
            this.panelSignedOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSignedOut.Controls.Add(this.btnRegister);
            this.panelSignedOut.Controls.Add(this.btnLogin);
            this.panelSignedOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignedOut.Location = new System.Drawing.Point(0, 0);
            this.panelSignedOut.Name = "panelSignedOut";
            this.panelSignedOut.Size = new System.Drawing.Size(176, 453);
            this.panelSignedOut.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(0, 50);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegister.Size = new System.Drawing.Size(176, 50);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(176, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelContainer.Controls.Add(this.login1);
            this.panelContainer.Controls.Add(this.register1);
            this.panelContainer.Controls.Add(this.loan1);
            this.panelContainer.Controls.Add(this.bankirDashboard1);
            this.panelContainer.Controls.Add(this.depositPage1);
            this.panelContainer.Controls.Add(this.bankirDepositsDashboard1);
            this.panelContainer.Controls.Add(this.searchPage1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(176, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(683, 453);
            this.panelContainer.TabIndex = 1;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.DodgerBlue;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(683, 453);
            this.login1.TabIndex = 0;
            // 
            // register1
            // 
            this.register1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register1.BackColor = System.Drawing.Color.DodgerBlue;
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(683, 453);
            this.register1.TabIndex = 1;
            // 
            // loan1
            // 
            this.loan1.BackColor = System.Drawing.Color.DodgerBlue;
            this.loan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loan1.Location = new System.Drawing.Point(0, 0);
            this.loan1.Name = "loan1";
            this.loan1.Size = new System.Drawing.Size(683, 453);
            this.loan1.TabIndex = 2;
            // 
            // bankirDashboard1
            // 
            this.bankirDashboard1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bankirDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankirDashboard1.Location = new System.Drawing.Point(0, 0);
            this.bankirDashboard1.Name = "bankirDashboard1";
            this.bankirDashboard1.Size = new System.Drawing.Size(683, 453);
            this.bankirDashboard1.TabIndex = 3;
            // 
            // depositPage1
            // 
            this.depositPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.depositPage1.Location = new System.Drawing.Point(0, 0);
            this.depositPage1.Name = "depositPage1";
            this.depositPage1.Size = new System.Drawing.Size(683, 453);
            this.depositPage1.TabIndex = 4;
            // 
            // bankirDepositsDashboard1
            // 
            this.bankirDepositsDashboard1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bankirDepositsDashboard1.Location = new System.Drawing.Point(0, 0);
            this.bankirDepositsDashboard1.Name = "bankirDepositsDashboard1";
            this.bankirDepositsDashboard1.Size = new System.Drawing.Size(683, 453);
            this.bankirDepositsDashboard1.TabIndex = 5;
            // 
            // searchPage1
            // 
            this.searchPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPage1.Location = new System.Drawing.Point(0, 0);
            this.searchPage1.Name = "searchPage1";
            this.searchPage1.Size = new System.Drawing.Size(683, 453);
            this.searchPage1.TabIndex = 6;
            // 
            // btnDeleteMyself
            // 
            this.btnDeleteMyself.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMyself.FlatAppearance.BorderSize = 0;
            this.btnDeleteMyself.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMyself.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMyself.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMyself.Location = new System.Drawing.Point(0, 278);
            this.btnDeleteMyself.Name = "btnDeleteMyself";
            this.btnDeleteMyself.Size = new System.Drawing.Size(176, 47);
            this.btnDeleteMyself.TabIndex = 0;
            this.btnDeleteMyself.Text = "Delete";
            this.btnDeleteMyself.UseVisualStyleBackColor = true;
            this.btnDeleteMyself.Click += new System.EventHandler(this.btnDeleteMyself_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 453);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelNavContainer);
            this.Name = "MainForm";
            this.Text = "Bank Management";
            this.panelNavContainer.ResumeLayout(false);
            this.panelSignedInBankir.ResumeLayout(false);
            this.panelSignedIn.ResumeLayout(false);
            this.panelSignedOut.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSignedOut;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelContainer;
        private Login login1;
        private Register register1;
        private System.Windows.Forms.Panel panelSignedIn;
        private System.Windows.Forms.Button btnMakeDeposit;
        private System.Windows.Forms.Button btnGetLoan;
        private Loan loan1;
        private System.Windows.Forms.Panel panelSignedInBankir;
        private System.Windows.Forms.Button btnLoanRequests;
        private BankirDashboard bankirDashboard1;
        private System.Windows.Forms.Button btnDepositRequests;
        private DepositPage depositPage1;
        private BankirDepositsDashboard bankirDepositsDashboard1;
        private System.Windows.Forms.Button btnReportPage;
        private System.Windows.Forms.Button btnSearchPage;
        private SearchPage searchPage1;
        private System.Windows.Forms.Button btnDeleteMyself;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement {
    public partial class MainForm : Form {
        private AuthUser currentUser;
        public delegate void OnRegister(AuthUser user);
        public delegate void OnLoanRequest(decimal amount, string currency, string backer);
        public delegate void OnDepositRequest(decimal amount, string currency, int percent);
        public delegate AuthUser CurrentUser();

        public MainForm() {
            InitializeComponent();
            OnRegister onRegister = new OnRegister(SetCurrentUser);
            register1.onSubmit = onRegister;
            login1.onSubmit = onRegister;
            panelSignedOut.BringToFront();
            login1.BringToFront();
            OnLoanRequest onRequest = new OnLoanRequest(RequestLoan);
            loan1.onSubmit = onRequest;
            OnDepositRequest onDepRequest = new OnDepositRequest(RequestDeposit);
            depositPage1.onSubmit = onDepRequest;
            CurrentUser onCurrentUser = new CurrentUser(GetCurrentUser);
            bankirDashboard1.onGetCurrentUser = onCurrentUser;
            bankirDepositsDashboard1.onGetCurrentUser = onCurrentUser;
            depositPage1.onGetCurrentUser = onCurrentUser;
            loan1.onGetCurrentUser = onCurrentUser;
        }

        public void SetCurrentUser(AuthUser user) {
            currentUser = user;
            if (currentUser.role.Equals("user")) {
                panelSignedIn.BringToFront();
                loan1.BringToFront();
            } else {
                panelSignedInBankir.BringToFront();
                bankirDashboard1.BringToFront();
            }
        }
        public AuthUser GetCurrentUser() {
            return currentUser;
        }

        public void RequestLoan(decimal amount, string currency, string backer) {
            UserLoan loan = new UserLoan(currentUser, currency, amount, backer);
            loan.AddToPending();
        }

        public void RequestDeposit(decimal amount, string currency, int percent) {
            Deposit deposit = new Deposit(currentUser, amount, currency, percent);
            deposit.AddToPending();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            login1.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            register1.BringToFront();
        }

        private void btnGetLoan_Click(object sender, EventArgs e) {
            loan1.BringToFront();
        }

        private void btnMakeDeposit_Click(object sender, EventArgs e) {
            depositPage1.BringToFront();
        }

        private void btnLoanRequests_Click(object sender, EventArgs e) {
            bankirDashboard1.BringToFront();
        }

        private void btnDepositRequests_Click(object sender, EventArgs e) {
            bankirDepositsDashboard1.BringToFront();
        }

        private void btnSearchPage_Click(object sender, EventArgs e) {
            searchPage1.BringToFront();
        }

        private void btnDeleteMyself_Click(object sender, EventArgs e) {
            string guid = currentUser.UserGuid;
            AuthUser.DeleteByGuid(guid);
            login1.BringToFront();
            panelSignedOut.BringToFront();
            MessageBox.Show("Account delete");
        }
    }
}

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
    public partial class Loan : UserControl {
        private Delegate getCurrentUser;
        public Delegate onGetCurrentUser {
            set { getCurrentUser = value; }
        }

        private Delegate requestLoan;
        public Delegate onSubmit {
            set { requestLoan = value; }
        }
        public Loan() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            decimal amount = decimal.Parse(tbGetLoanAmount.Text);
            string currency = cbGetLoanCurrency.Text;
            string backerPn = tbBackPerNum.Text;
            requestLoan.DynamicInvoke(amount, currency, backerPn);
        }

        private void btnListLoans_Click(object sender, EventArgs e) {
            AuthUser currentUser = getCurrentUser.DynamicInvoke() as AuthUser;
            myLoans.DataSource = Helper.GetMyLoans(currentUser.UserGuid);
        }
    }
}

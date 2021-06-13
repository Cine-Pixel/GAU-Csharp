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
    public partial class BankirDashboard : UserControl {
        private Delegate getCurrentUser;
        public Delegate onGetCurrentUser {
            set { getCurrentUser = value; }
        }
        public BankirDashboard() {
            InitializeComponent();
            List<UserLoan>loans = Helper.GetPendingLoans();
            pendingLoans.DataSource = loans;
        }

        private void btnListPending_Click(object sender, EventArgs e) {
            //List<UserLoan>loans = Helper.GetPendingLoans();
            pendingLoans.DataSource = Helper.GetPendingLoans();
        }

        private void pendingLoans_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            string owner = pendingLoans.CurrentRow.Cells["Owner"].Value.ToString();
            string amount = pendingLoans.CurrentRow.Cells["Amount"].Value.ToString();
            string currency = pendingLoans.CurrentRow.Cells["Currency"].Value.ToString();
            MessageBox.Show(owner + " " + amount + " " + currency);
        }

        private void button1_Click(object sender, EventArgs e) {
            AuthUser currentUser = getCurrentUser.DynamicInvoke() as AuthUser;
            string ownerId = pendingLoans.CurrentRow.Cells["Owner"].Value.ToString();
            NaturalPerson owner = NaturalPerson.GetPersonByGuid(ownerId);
            string amount = pendingLoans.CurrentRow.Cells["Amount"].Value.ToString();
            int percent = int.Parse(tbPercent.Text);
            int duration = int.Parse(tbDuration.Text);
            string currency = pendingLoans.CurrentRow.Cells["Currency"].Value.ToString();
            string backer = pendingLoans.CurrentRow.Cells["Backer"].Value.ToString();
            UserLoan userLoan = new UserLoan(owner, currency, decimal.Parse(amount), percent, duration, currentUser, backer);
            userLoan.ApproveLoan();
        }
    }
}

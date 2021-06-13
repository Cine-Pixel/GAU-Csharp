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
    public partial class BankirDepositsDashboard : UserControl {
        private Delegate getCurrentUser;
        public Delegate onGetCurrentUser {
            set { getCurrentUser = value; }
        }
        public BankirDepositsDashboard() {
            InitializeComponent();
            List<Deposit> deposits= Helper.GetPendingDeposits();
            pendingDeposits.DataSource = deposits;
        }

        private void pendingDeposits_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            string owner = pendingDeposits.CurrentRow.Cells["Owner"].Value.ToString();
            string amount = pendingDeposits.CurrentRow.Cells["Amount"].Value.ToString();
            string currency = pendingDeposits.CurrentRow.Cells["Currency"].Value.ToString();
            string percent = pendingDeposits.CurrentRow.Cells["Percent"].Value.ToString();
            MessageBox.Show(owner + " " + amount + " " + currency);
        }

        private void btnApproveDeposit_Click(object sender, EventArgs e) {
            try {
                AuthUser currentUser = getCurrentUser.DynamicInvoke() as AuthUser;
                string ownerId = pendingDeposits.CurrentRow.Cells["Owner"].Value.ToString();
                NaturalPerson owner = NaturalPerson.GetPersonByGuid(ownerId);
                string amount = pendingDeposits.CurrentRow.Cells["Amount"].Value.ToString();
                string currency = pendingDeposits.CurrentRow.Cells["Currency"].Value.ToString();
                string percent = pendingDeposits.CurrentRow.Cells["Percent"].Value.ToString();
                Deposit deposit = new Deposit(owner, DateTime.Now, decimal.Parse(amount), currency, int.Parse(percent), currentUser);
                deposit.ApproveDeposit();
                MessageBox.Show("Deposit approved");
            } catch(Exception ex) {
                MessageBox.Show("Invalid input");
            }
        }
    }
}

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
    public partial class DepositPage : UserControl {
        private Delegate getCurrentUser;
        public Delegate onGetCurrentUser {
            set { getCurrentUser = value; }
        }

        private Delegate requestDeposit;
        public Delegate onSubmit {
            set { requestDeposit = value; }
        }
        public DepositPage() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string amount = tbDepositAmount.Text;
            string percent = tbDepositPercent.Text;
            string currency = comboBox1.Text;
            requestDeposit.DynamicInvoke(decimal.Parse(amount), currency, int.Parse(percent));
            MessageBox.Show("Request sent wait for it to get approved");
        }

        private void btnListDeposits_Click(object sender, EventArgs e) {
            AuthUser currentUser = getCurrentUser.DynamicInvoke() as AuthUser;
            MyDeposits.DataSource = Helper.GetMyDeposits(currentUser.UserGuid);
        }
    }
}

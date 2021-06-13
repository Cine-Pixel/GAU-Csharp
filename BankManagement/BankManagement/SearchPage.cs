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
    public partial class SearchPage : UserControl {
        public SearchPage() {
            InitializeComponent();
        }

        private void btnClientsFromDate_Click(object sender, EventArgs e) {
            DateTime from = dtFrom.Value;
            DateTime to = dtTo.Value;

            List<NaturalPerson> filteredPersons = Helper.UsersFromDate(from, to);
            filteredByDate.DataSource = filteredPersons;
        }

        private void btnClientsTopM_Click(object sender, EventArgs e) {
            try {
                int top = int.Parse(tbTopM.Text);
                List<NaturalPerson> topPersons = Helper.TopUsers(top);
                topUsers.DataSource = topPersons;
            } catch (Exception ex) {
                MessageBox.Show("Invalid value\n" + ex.Message);
            }
        }
    }
}

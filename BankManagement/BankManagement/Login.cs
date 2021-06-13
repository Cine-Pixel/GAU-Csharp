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
    public partial class Login : UserControl {
        private Delegate submit;
        public Delegate onSubmit {
            set { submit = value; }
        }

        public Login() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string email = tbLoginEmail.Text;
            string password = tbLoginPass.Text;
            try {
                AuthUser currentUser = AuthUser.Authenticate(email, password);
                submit.DynamicInvoke(currentUser);
            } catch(Exception err) {
                MessageBox.Show($"Incorrect email or password\n{err.Message}");
            }
        }
    }
}

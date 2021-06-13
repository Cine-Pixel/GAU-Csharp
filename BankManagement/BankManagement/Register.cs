using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement {
    public partial class Register : UserControl {
        private Delegate submit;
        public Delegate onSubmit {
            set { submit = value; }
        }
        public Register() {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            string firstname = tbRegisterFirstname.Text;
            if(firstname.Length < 2 || firstname.Length > 50) {
                MessageBox.Show("First name must be 2 to 50 letters");
                return;
            }
            string lastname = tbRegisterLastname.Text;
            if(lastname.Length < 2 || lastname.Length > 50) {
                MessageBox.Show("Last name must be 2 to 50 letters");
                return;
            }
            string email = tbRegisterEmail.Text;
            if(!Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")) {
                MessageBox.Show("Invalid email address");
                return;
            }
            string pn = tbPn.Text;
            if(pn.Length != 11 || !Regex.IsMatch(pn, @"\d")) {
                MessageBox.Show("Personal number must be 11 digist long");
                return;
            }
            string gender = cbGender.Text;
            if(!(gender.Equals("Male") || gender.Equals("Female"))) {
                MessageBox.Show($"Invlid value for gender");
                return;
            }
            string country = cbCountry.Text;
            string city = cbCity.Text;

            DateTime birthDay = dateBirth.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDay.Year;
            if (birthDay.Date > today.AddYears(-age)) age--;
            int maxAge = (gender.Equals("Female") ? 60 : 65);
            if(age < 18 || age > maxAge) {
                MessageBox.Show($"Invalid age, 18 to {maxAge} are allowed for {gender}s");
                return;
            }

            string phone = tbPhone.Text;
            if(phone.Length < 4 || phone.Length > 50) {
                MessageBox.Show("Invalid phone number, 4 to 50 digits are allowed");
                return;
            }

            string pass1 = tbRegisterPass1.Text;
            string pass2 = tbRegisterPass2.Text;

            if(!(pass1.Equals(pass2))) {
                MessageBox.Show("Passwords don't match");
                return;
            }
            string username = $"{firstname} {lastname}";
            //MessageBox.Show($"{firstname} {lastname} {email} {phone} {pn} {gender} {country} {city} {birthDay} {pass1} {pass2}");

            AuthUser currentUser = new AuthUser(firstname, lastname, username, pass1, email, gender, pn, birthDay, country, city,phone, "user");
            currentUser.AddPerson();
            submit.DynamicInvoke(currentUser);
        }
    }
}

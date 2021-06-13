using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement {
    public class UserLoan: IComparable<UserLoan>, IComparer<UserLoan> {
        private NaturalPerson owner;
        private DateTime createdAt;
        private decimal amount;
        private string currency;
        private int percent;
        private decimal amountLeft;
        private int deadline;
        private string backer;
        private AuthUser approvedBy;

        public string Owner { get => owner.UserGuid; }
        public decimal Amount { get => amount; }
        public string Currency { get => currency; }
        public string Backer { get => backer; }
        public int Deadline { get => deadline; }

        public UserLoan(NaturalPerson owner, string currency, decimal amount, string backer) {
            this.owner = owner;
            this.currency = currency;
            this.amount = amount;
            this.backer = backer;
        }

        public UserLoan(NaturalPerson owner, string currency, decimal amount, int percent, int deadline, AuthUser approvedBy, string backer) {
            this.owner = owner;
            this.createdAt = DateTime.Now;
            this.currency = currency;
            this.amount = amount;
            this.percent = percent;
            this.amountLeft = amount + (amount * percent/100);
            this.approvedBy = approvedBy;
            this.backer = backer;
            this.deadline = deadline;
        }

        public void AddToPending() {
            XElement document = XElement.Load(Helper.PendingLoansPath);
            XElement newLoan = new XElement("Loan",
                new XElement("Owner", this.owner.UserGuid),
                new XElement("Amount", this.amount),
                new XElement("Currency", this.currency),
                new XElement("Backer", this.backer)
            );
            document.Add(newLoan);
            document.Save(Helper.PendingLoansPath);
        }

        public void ApproveLoan() {
            XElement document = XElement.Load(Helper.ApprovedLoansPath);
            XElement newLoan = new XElement("Loan",
                new XElement("Owner", this.owner.UserGuid),
                new XElement("CreatedAt", this.createdAt),
                new XElement("Amount", this.amount),
                new XElement("Currency", this.currency),
                new XElement("Percent", this.percent),
                new XElement("AmountLeft", this.amountLeft),
                new XElement("Deadline", this.deadline),
                new XElement("Backer", this.backer),
                new XElement("ApprovedBy", this.approvedBy.UserGuid)
            );
            document.Add(newLoan);
            document.Save(Helper.ApprovedLoansPath);
        }

        public string getInfo() {
            return $"{owner} {currency} {amount}";
        }

        public void Pay(decimal amount) {
            this.amountLeft -= amount;
        }

        public int Compare(UserLoan x, UserLoan y) {
            return x.deadline.CompareTo(y.deadline);
        }

        public int CompareTo(UserLoan obj) {
            return deadline.CompareTo(obj.Deadline);
        }
    }
}

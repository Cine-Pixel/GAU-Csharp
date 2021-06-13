using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement {
    public class Deposit: IComparable<Deposit>, IComparer<Deposit> {
        private NaturalPerson owner;
        private DateTime createdAt;
        private decimal amount;
        private string currency;
        private int percent;
        private AuthUser approvedBy;

        public string Owner { get => owner.UserGuid; }
        public decimal Amount { get => amount; }
        public string Currency { get => currency; }
        public int Percent { get => percent; }

        public Deposit(NaturalPerson owner, decimal amount, string currency, int percent) {
            this.owner = owner;
            this.amount = amount;
            this.currency = currency;
            this.percent = percent;
        }

        public Deposit(NaturalPerson owner, DateTime createdAt, decimal amount, string currency, int percent, AuthUser approvedBy) {
            this.owner = owner;
            this.createdAt = createdAt;
            this.amount = amount;
            this.currency = currency;
            this.percent = percent;
            this.approvedBy = approvedBy;
        }

        public string GetInfo() {
            return $"{owner.UserGuid} {amount} {currency}";
        }

        public void AddToPending() {
            XElement document = XElement.Load(Helper.PendingDepositsPath);
            XElement newLoan = new XElement("Deposit",
                new XElement("Owner", this.owner.UserGuid),
                new XElement("Amount", this.amount),
                new XElement("Currency", this.currency),
                new XElement("Percent", this.percent)
            );
            document.Add(newLoan);
            document.Save(Helper.PendingDepositsPath);
        }

        public void ApproveDeposit() {
            XElement document = XElement.Load(Helper.ApprovedDepositsPath);
            XElement newLoan = new XElement("Deposit",
                new XElement("Owner", this.owner.UserGuid),
                new XElement("CreatedAt", this.createdAt),
                new XElement("Amount", this.amount),
                new XElement("Currency", this.currency),
                new XElement("Percent", this.percent),
                new XElement("ApprovedBy", this.approvedBy.UserGuid)
            );
            document.Add(newLoan);
            document.Save(Helper.ApprovedDepositsPath);
        }

        public int Compare(Deposit x, Deposit y) {
            return x.Amount.CompareTo(y.Amount);
        }

        public int CompareTo(Deposit obj) {
            return Amount.CompareTo(obj.Amount);
        }
    }
}

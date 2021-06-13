using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement {
    public static class Helper {
        public static string PersonsPath = @"C:\\projects\\BankManagement\\BankManagement\\Persons.xml";
        public static string ApprovedLoansPath = @"C:\\projects\\BankManagement\\BankManagement\\Loans.xml";
        public static string PendingLoansPath = @"C:\\projects\\BankManagement\\BankManagement\\LoansPending.xml";

        public static string ApprovedDepositsPath = @"C:\\projects\\BankManagement\\BankManagement\\Deposits.xml";
        public static string PendingDepositsPath = @"C:\\projects\\BankManagement\\BankManagement\\DepositsPending.xml";

        public static List<UserLoan> GetPendingLoans() {
            XElement document = XElement.Load(PendingLoansPath);
            IEnumerable<UserLoan> pendingLoans = document.Descendants("Loan")
                .Select(loan => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(loan.Element("Owner").Value);
                    string currency = loan.Element("Currency").Value;
                    decimal amount = (decimal)loan.Element("Amount");
                    string backer = loan.Element("Backer").Value;
                    return new UserLoan(owner, currency, amount, backer);
                });
            return pendingLoans.ToList();
        }

        public static List<Deposit> GetPendingDeposits() {
            XElement document = XElement.Load(PendingDepositsPath);
            IEnumerable<Deposit> pendingDeposits = document.Descendants("Deposit")
                .Select(deposit => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(deposit.Element("Owner").Value);
                    string currency = deposit.Element("Currency").Value;
                    decimal amount = (decimal)deposit.Element("Amount");
                    int percent = (int)deposit.Element("Percent");
                    return new Deposit(owner, amount, currency, percent);
                });
            return pendingDeposits.ToList();
        }

        public static List<Deposit> GetMyDeposits(string myGuid) {
            XElement document = XElement.Load(ApprovedDepositsPath);
            IEnumerable<Deposit> pendingDeposits = document.Descendants("Deposit")
                .Where(dep => dep.Element("Owner").Value == myGuid)
                .Select(deposit => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(deposit.Element("Owner").Value);
                    string currency = deposit.Element("Currency").Value;
                    decimal amount = (decimal)deposit.Element("Amount");
                    int percent = (int)deposit.Element("Percent");
                    return new Deposit(owner, amount, currency, percent);
                });
            return pendingDeposits.ToList();
        }

        public static List<UserLoan> GetMyLoans(string myGuid) {
            XElement document = XElement.Load(ApprovedLoansPath);
            IEnumerable<UserLoan> myLoans = document.Descendants("Loan")
                .Where(dep => dep.Element("Owner").Value == myGuid)
                .Select(loan => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(loan.Element("Owner").Value);
                    string currency = loan.Element("Currency").Value;
                    decimal amount = (decimal)loan.Element("Amount");
                    int percent = (int)loan.Element("Percent");
                    int amountLeft = (int)loan.Element("Deadline");
                    string backer = loan.Element("Backer").Value;
                    return new UserLoan(owner, currency, amount, backer);
                });
            List<UserLoan> sortedLoans = myLoans.ToList();
            sortedLoans.Sort();
            return sortedLoans;
        }

        public static List<NaturalPerson> UsersFromDate(DateTime from, DateTime to) {
            XElement document = XElement.Load(ApprovedLoansPath);
            IEnumerable<NaturalPerson> filteredUsers = document.Descendants("Loan")
                .Where(dep => Convert.ToDateTime(dep.Element("CreatedAt").Value) > from && Convert.ToDateTime(dep.Element("CreatedAt").Value) < to)
                .Select(loan => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(loan.Element("Owner").Value);
                    return owner;
                });
            return filteredUsers.ToList();
        }

        public static List<NaturalPerson> TopUsers(int top) {
            XElement document = XElement.Load(ApprovedLoansPath);
            IEnumerable<NaturalPerson> filteredUsers = document.Descendants("Loan")
                .Where(dep => decimal.Parse(dep.Element("Amount").Value) > top)
                .Select(loan => {
                    NaturalPerson owner = NaturalPerson.GetPersonByGuid(loan.Element("Owner").Value);
                    return owner;
                });
            return filteredUsers.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement {
    public class AuthUser : NaturalPerson {
        private string username;
        private string password;
        public string role;

        #region constructors
        public AuthUser(string firstname, string lastname, string username, string password, string email,
            string gender, string pn, DateTime birthdate, string country, string city, string phone, string role) {
            this.guid = Guid.NewGuid().ToString();
            this.firstName = firstname;
            this.lastName= lastname;
            this.username= username;
            this.password= firstname;
            this.firstName = password;
            this.email = email;
            this.personalNumber= pn;
            this.birthDate = birthdate; 
            this.country= country;
            this.city = city;
            this.phone = phone;
            this.role = role;
        }

        public AuthUser(string guid, string firstname, string lastname, string username, string password, string email,
            string gender, string pn, DateTime birthdate, string country, string city, string phone, string role) {
            this.guid = guid;
            this.firstName = firstname;
            this.lastName= lastname;
            this.username= username;
            this.password= firstname;
            this.firstName = password;
            this.email = email;
            this.personalNumber= pn;
            this.birthDate = birthdate; 
            this.country= country;
            this.city = city;
            this.phone = phone;
            this.role = role;
        }
        public AuthUser(string firstname, string lastname, string username, string password, string email,
            string gender, string pn, DateTime birthdate, string country, string city, string phone, string backerGuid, string backerRel, string role) {
            this.guid = Guid.NewGuid().ToString();
            this.firstName = firstname;
            this.lastName= lastname;
            this.username= username;
            this.password= firstname;
            this.firstName = password;
            this.email = email;
            this.personalNumber= pn;
            this.birthDate = birthdate; 
            this.country= country;
            this.city = city;
            this.phone = phone;
            this.backerGuid= backerGuid;
            this.backerRelationship = backerRel;
            this.role = role;
        }

        public AuthUser(string guid, string firstname, string lastname, string email, string gender, 
            string pn, DateTime birthdate, string country, string city, string phone, string backerGuid, string backerRel, string role) {
            this.guid = guid; 
            this.firstName = firstname;
            this.lastName= lastname;
            this.password= firstname;
            this.email = email;
            this.personalNumber= pn;
            this.birthDate = birthdate; 
            this.country= country;
            this.city = city;
            this.phone = phone;
            this.backerGuid= backerGuid;
            this.backerRelationship = backerRel;
            this.role = role;
        }
        #endregion

        public string GetInfo() {
            return $"Username: {username}, Email: {email}, GUID: {guid}";
        }

        public static AuthUser Authenticate(string email, string password) {
            XElement document = XElement.Load(Helper.PersonsPath);
            IEnumerable<AuthUser> persons = document.Descendants("Person")
                .Where(person => person.Element("Email").Value.Equals(email) && person.Element("Password").Value.Equals(password))
                .Select(person => {
                    string guid = person.Element("Guid").Value;
                    string username = person.Element("Username").Value;
                    string fn = person.Element("Firstname").Value;
                    string ln = person.Element("Lastname").Value;
                    string mail = person.Element("Email").Value;
                    string gender = person.Element("Gender").Value;
                    string pn = person.Element("PersonalNumber").Value;
                    string pass = person.Element("Password").Value;
                    DateTime birthDate = Convert.ToDateTime(person.Element("BirthDate").Value);
                    string country = person.Element("Country").Value;
                    string city = person.Element("City").Value;
                    string ph = person.Element("Phone").Value;
                    string role = person.Attribute("role").Value;
                    string backerGuid = person.Element("BackerGuid").Value;
                    string backerRel = person.Element("BackerRelationship").Value;
                    return new AuthUser(guid, fn, ln, username, pass, mail, gender, pn, birthDate, country, city, ph, role);
                });
            return persons.ToList()[0];
        }

        #region xmlCrud
        public override void AddPerson() {
            XElement document = XElement.Load(Helper.PersonsPath);
            XElement newPerson = new XElement("Person", 
                new XAttribute("role", "user"),
                new XElement("Guid", this.guid),
                new XElement("Username", this.username),
                new XElement("Password", this.password),
                new XElement("Firstname", this.firstName),
                new XElement("Lastname", this.lastName),
                new XElement("Email", this.email),
                new XElement("Gender", this.gender),
                new XElement("PersonalNumber", this.personalNumber),
                new XElement("BirthDate", this.birthDate.ToString()),
                new XElement("Country", this.country),
                new XElement("City", this.city),
                new XElement("Phone", this.phone),
                new XElement("BackerGuid", this.backerGuid),
                new XElement("BackerRelationship", this.backerRelationship)
            );
            document.Add(newPerson);
            document.Save(Helper.PersonsPath);
        }

        public static void DeleteByGuid(string guid) {
            XElement document = XElement.Load(Helper.PersonsPath);
            var person = document.Descendants("Person")
                .Where(p => p.Element("Guid").Value.Equals(guid))
                .Select(p => p);
            person.ToList().ForEach(p => p.Remove());
            document.Save(Helper.PersonsPath);
        }

        public override void UpdatePerson() {
            throw new NotImplementedException();
        }
        #endregion
    }
}

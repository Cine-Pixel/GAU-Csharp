using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagement {
    public abstract class NaturalPerson {
        protected string guid;
        protected string firstName;
        protected string lastName;
        protected string personalNumber;
        protected string gender;
        protected DateTime birthDate;
        protected string country;
        protected string city;
        protected string phone;
        protected string email;
        protected string backerGuid;
        protected string backerRelationship;

        public string UserGuid { get => guid; }
        public string FirstName { get => firstName;  }
        public string LirstName { get => lastName;  }

        public abstract void AddPerson();

        public abstract void UpdatePerson();

        public void RemovePerson() {
            throw new NotImplementedException();
        }

        public static NaturalPerson GetPersonByGuid(string guid) {
            XElement document = XElement.Load(Helper.PersonsPath);
            IEnumerable<NaturalPerson> persons = document.Descendants("Person")
                .Where(person => person.Element("Guid").Value.Equals(guid))
                .Select(person => {
                    string id = person.Element("Guid").Value;
                    string username = person.Element("Username").Value;
                    string fn = person.Element("Firstname").Value;
                    string ln = person.Element("Lastname").Value;
                    string mail = person.Element("Email").Value;
                    string gender = person.Element("Gender").Value;
                    string pn = person.Element("PersonalNumber").Value;
                    DateTime birthDate = Convert.ToDateTime(person.Element("BirthDate").Value);
                    string country = person.Element("Country").Value;
                    string city = person.Element("City").Value;
                    string ph = person.Element("Phone").Value;
                    string role = person.Attribute("role").Value;
                    string backerGuid = person.Element("BackerGuid").Value;
                    string backerRel = person.Element("BackerRelationship").Value;
                    return new AuthUser(id, fn, ln, mail, gender, pn, birthDate, country, city, ph, backerGuid, backerRel, role);
                });
            return persons.ToList()[0];
        }
    }
}

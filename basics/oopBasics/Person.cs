using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// task 7.1.4

namespace oopBasics {
    public class Person {
        private string firstName;
        private string lastName;
        private int age;

        public Person() {
            firstName = "Anonymus";
            lastName = "User";
            age = 0;
        }

        public Person(string firstName, string lastName, int age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string GetInfo() => $"Fullname: {firstName} {lastName}, Age: {age}";
    }

    public class Doctor:Person {
        public string department;
        public string position;
        public string hospital;
        public string experience;
    }
}

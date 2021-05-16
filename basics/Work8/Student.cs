using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work8 {
    public class Student {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Tax { get; set; }
        public string Faculty { get; set; }
        public string Phone { get; set; }

        public void displayInfo() {
            Console.WriteLine($"Student {Firstname} {Lastname} studies on {Faculty}. Tax: {Tax}, Phone: {Phone}");
        }
    }
}

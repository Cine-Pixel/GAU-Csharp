using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Work8 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\projects\csharp\basics\Work8\";
            List<Student> students = new List<Student>() {
                new Student{Firstname= "Nikola", Lastname = "Tesla", Faculty="Engineering", Tax=5000, Phone="995 54 902 234"},
                new Student{Firstname= "Albert", Lastname = "Einstein", Faculty="Phisics", Tax=12000, Phone="995 12 502 224"},
                new Student{Firstname= "Stephen", Lastname = "Hawking", Faculty="Phisics", Tax=8000, Phone="995 57 345 234"},
                new Student{Firstname= "Wilhelm", Lastname = "Wien", Faculty="Radiology", Tax=20000, Phone="995 90 234 845"},
                new Student{Firstname= "Geoffrey", Lastname = "Hinton", Faculty="Psocology", Tax=4000, Phone="995 89 234 765"},
                new Student{Firstname= "Timnit", Lastname = "Gebru", Faculty="Computer Science", Tax=15000, Phone="765 02 952 008"}
            };

            XDocument studentsXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("StudentsList")
            );

            foreach(Student student in students) {
                studentsXML.Element("StudentsList")
                    .Add(new XElement("Student", 
                        new XElement("firstname", student.Firstname),
                        new XElement("lastname", student.Lastname),
                        new XElement("faculty", student.Faculty),
                        new XElement("tax", student.Tax),
                        new XElement("phone", student.Phone)
                    ));
            }

            studentsXML.Save(path+"\\students.xml");


            XDocument savedXML = XDocument.Load(path + "\\students.xml");

            IEnumerable<XElement> phisicists = savedXML.Descendants("Student")
                .Where(st => st.Element("faculty").Value == "Phisics");

            Console.WriteLine("Select phisicists");
            foreach(XElement st in phisicists) {
                Console.Write(st.Element("firstname").Value + " ");
                Console.Write(st.Element("lastname").Value + " ");
                Console.Write(st.Element("faculty").Value + " ");
                Console.Write(st.Element("tax").Value + " ");
                Console.Write(st.Element("phone").Value);
                Console.WriteLine();
            }
            Console.WriteLine();

            IEnumerable<XElement> ordered = savedXML.Descendants("Student")
                .OrderBy(st => (double)st.Element("tax"));

            Console.WriteLine("Order by tax");
            foreach(XElement st in ordered) {
                Console.Write(st.Element("firstname").Value + " ");
                Console.Write(st.Element("lastname").Value + " ");
                Console.Write(st.Element("faculty").Value + " ");
                Console.Write(st.Element("tax").Value + " ");
                Console.Write(st.Element("phone").Value);
                Console.WriteLine();
            }
            Console.WriteLine();


            IEnumerable<Student> asStudentsClass = savedXML.Descendants("Student")
                .Where(st => (double)st.Element("tax") < 15000)
                .Select(st => new Student {
                        Firstname = st.Element("firstname").Value,
                        Lastname = st.Element("lastname").Value,
                        Faculty = st.Element("faculty").Value,
                        Tax = (double)st.Element("tax"),
                        Phone = st.Element("phone").Value
                });

            Console.WriteLine("XML to Student object");
            foreach(Student st in asStudentsClass) {
                st.displayInfo();
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}

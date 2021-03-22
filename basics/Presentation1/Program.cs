using System;

namespace Presentation1 {
    class Program {
        static void Main(string[] args) {
            Car car = new Car("Mustang", "Ford");
            Car car2 = new Car();
            car2.model = "F125";
            car2.Brand = "Ferrari";
            Console.WriteLine($"Car model {car.model} and car brand is {car.Brand}");
            Console.WriteLine($"Car model {car2.model} and car brand is {car2.Brand}");

            Sedan s1 = new Sedan(4, "Camry", "Toyota");
            Sedan s2 = new Sedan();
            Console.WriteLine(s1.ReturnInfo());
            Console.WriteLine(s2.ReturnInfo());

            Plane p1 = new Plane("b595", "Arial", "Boeing");
            Console.WriteLine(p1.ReturnInfo());

            Console.WriteLine();
            object obj = new object();
            NotTopClass ntc = new NotTopClass("top");
            Type t1 = ntc.GetType();
            Type t2 = obj.GetType();

            Console.WriteLine($"{t1.BaseType} {t1.Name} {t1.FullName} {t1.Namespace}\n");
            Console.WriteLine($"{t2.BaseType} {t2.Name} {t2.FullName} {t2.Namespace}\n");

            Console.ReadKey();
        }
    }
}

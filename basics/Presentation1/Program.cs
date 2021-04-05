using System;

namespace Presentation1 {
    class Program {
        static void Main(string[] args) {
            Car car = new Car("Mustang", "Ford", "25L per 100km", "New", "98%");
            Car car2 = new Car("F125", "Ferrari", "16L per 100km", "New", "95%");
            Sedan s1 = new Sedan(4, "Camry", "Toyota", "13L per 100km", "Used", "55%");
            Sedan s2 = new Sedan();
            Plane p1 = new Plane("b595", "Arial", "Boeing", "CK234GSF", "100L per 2000KM", "New", "100%");
            Train t1 = new Train("TM-524", "TM", "3kw0-2340-2wer", 10, "Iron Ore", "50L per 100KM", "Long Used", "40%");

            Vehicle[] vehicles = { car, car2, s1, s2, p1, t1 };

            foreach(Vehicle vehicle in vehicles) {
                Console.WriteLine(vehicle.ReturnInfo());
                Console.WriteLine(vehicle.GetConditionInfo());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

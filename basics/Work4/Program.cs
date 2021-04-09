using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4 {
    class Program {
        static void Main(string[] args) {
            // 7.5.1
            Square sq = new Square(14, 15, 14, 15);
            Triangle tr = new Triangle(10, 10, 12);
            Console.WriteLine($"Perimeter of Square: {sq.Perimetri()}");
            Console.WriteLine($"Perimeter of Triangle: {tr.Perimetri()}\n");

            // 7.5.2
            Electric electricTrain = new Electric(500, 250);
            Diessel diessedTrain = new Diessel(140, 6);
            Console.WriteLine($"Energy spent by electric train: {electricTrain.Gamotvla()}");
            Console.WriteLine($"Energy spent by diesel train: {diessedTrain.Gamotvla()}\n");

            // 7.5.3
            ChildTv t1 = new ChildTv(0.55, 5);
            Console.WriteLine($"Engergy consumed by TV: {t1.Metodi()}\n");

            // 7.5.4
            Driver d1 = new Driver(1200, 6);
            Console.WriteLine($"Total salary for driver: {d1.Metodi()}");

            Console.ReadKey();
        }
    }
}

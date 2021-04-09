using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4 {
    abstract class Tanamshromeli {
        public abstract double Metodi();
    }

    class Driver : Tanamshromeli {
        private double salaryPerMonth;
        private int monthsWorked;

        public Driver(double salary, int months) {
            salaryPerMonth = salary;
            monthsWorked = months;
        }

        public override double Metodi() {
            return salaryPerMonth * monthsWorked;
        }
    }
}

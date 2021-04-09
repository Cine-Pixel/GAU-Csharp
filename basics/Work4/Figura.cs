using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4 {
    // 7.5.1
    abstract class Figura {
        public abstract double Perimetri();
    }

    class Square : Figura {
        private double s1;
        private double s2;
        private double s3;
        private double s4;

        public Square(double s1, double s2, double s3, double s4) {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        public override double Perimetri() {
            return s1 + s2 + s3 + s4;
        }
    }

    class Triangle : Figura {
        private double s1;
        private double s2;
        private double s3;

        public Triangle(double s1, double s2, double s3) {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public override double Perimetri() {
            return s1 + s2 + s3;
        }
    }
}

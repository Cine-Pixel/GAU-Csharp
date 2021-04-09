using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4 {
    // 7.5.2
    abstract class Matarebeli {
        public abstract double Gamotvla();
    }

    class Diessel : Matarebeli {
        private double velocity;
        private double timeTraveled;

        public Diessel(double v, double t) {
            velocity = v;
            timeTraveled = t;
        }

        public override double Gamotvla() {
            return velocity * timeTraveled;
        }
    }

    class Electric : Matarebeli {
        private double energyPerKM;
        private double distanceTraveled;

        public Electric(double energy, double distance) {
            energyPerKM = energy;
            distanceTraveled = distance;
        }

        public override double Gamotvla() {
            return energyPerKM * distanceTraveled;
        }
    }
}

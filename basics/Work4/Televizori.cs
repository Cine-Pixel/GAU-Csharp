using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4 {
    // 7.5.3
    abstract class Televizori {
        public abstract double Metodi();
    }

    class ChildTv : Televizori {
        private double energyPerHour;
        private double activeHours;

        public ChildTv(double en, double ah) {
            energyPerHour = en;
            activeHours = ah;
        }

        public override double Metodi() {
            return energyPerHour * activeHours;
        }
    }
}

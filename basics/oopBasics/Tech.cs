using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopBasics {
    class Televizori {
        protected double WattInHour;
        protected float ActiveHours;

        public Televizori(double wih, float ah) {
            WattInHour = wih;
            ActiveHours = ah;
        }
    }
    class Memkvidre_1:Televizori {
        protected float WorkingHours;

        public Memkvidre_1(double wih, float ah, float wh):base(wih, ah) {
            WorkingHours = wh;
        }
    }
    class Memkvidre_2:Memkvidre_1 {
        private double WattsUsed;
        public Memkvidre_2(double wih, double totalHours):base(wih, totalHours) {

        }
    }
}

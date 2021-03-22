using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation1 {
    class Sedan : Car {
        public int numberOfDoors;

        public override string ReturnInfo() {
            return ($"Car model: {model}, Car brand: {Brand}, number of doors: {numberOfDoors}");
        }

        public Sedan() {
            numberOfDoors = 4;
        }
        
        public Sedan(int nod, string model, string brand) : base(model, brand) {
            numberOfDoors = nod;
        }
    }
}

using System;

namespace Presentation1 {
    class Sedan : Car {
        public int numberOfDoors;

        public override string ReturnInfo() {
            return ($"Car model: {model}, Car brand: {Brand}, number of doors: {numberOfDoors}");
        }

        public Sedan() {
            numberOfDoors = 4;
        }
        
        public Sedan(int nod, string model, string brand, string fc, string ec, string bl) : base(model, brand, fc, ec, bl) {
            numberOfDoors = nod;
        }
    }
}

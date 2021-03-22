using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation1 {
    class Car : Vehicle {
        public string model;

        public Car() : this("unknown model", "unknown brand") { }
        public Car(string model, string brand) {
            Brand = brand;
            this.model = model;
        }

        public override string ReturnInfo() {
            return $"Car: {model}; Brand: {Brand}";
        }
    }
}

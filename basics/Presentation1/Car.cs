using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation1 {
    class Car : Vehicle {
        public string model;

        public Car() : this("unknown model", "unknown brand", "none", "none", "none") { }

        public Car(string model, string brand, string fc, string ec, string bl) {
            Brand = brand;
            fuel_consunption = fc;
            engine_condition = ec;
            battary_level = bl;
            this.model = model;
        }

        public override string ReturnInfo() {
            return $"Car: {model}; Brand: {Brand}";
        }

        public override string GetConditionInfo() {
            return $"Current Car has {battary_level} of battary left, consumed {fuel_consunption} liters of fuel, engine condition is {engine_condition}";
        }
    }
}

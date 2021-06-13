using System;

namespace Presentation1 {
    class Plane : Vehicle {
        public string model;
        public string type;

        public Plane(string model, string type, string brand, string sn, string fc, string ec, string bl) {
            this.model = model;
            this.type = type;
            fuel_consunption = fc;
            engine_condition = ec;
            battary_level = bl;
            Brand = brand;
            SerialNumber = sn;
        }

        public override string ReturnInfo() {
            return $"Plane: {model}; Brand: {Brand}; Type: {type}; Serial number: {SerialNumber}";
        }

        public override string GetConditionInfo() {
            return $"Current plane has {battary_level} of battary left, consumed {fuel_consunption} liters of fuel, engine condition is {engine_condition}";
        }
    }
}

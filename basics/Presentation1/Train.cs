using System.Threading.Tasks;

namespace Presentation1 {
    class Train : Vehicle {
        private string model;
        private int number_of_cars;
        private string cargo_type;

        public Train() {
            number_of_cars = 0;
            cargo_type = "none";
            model = "unknown";
        }

        public Train(string m, string b, string sn, int noc, string ct, string fc, string ec, string bl) {
            model = m;
            fuel_consunption = fc;
            engine_condition = ec;
            battary_level = bl;
            Brand = b;
            SerialNumber = sn;
            number_of_cars = noc;
            cargo_type = ct;
        }

        public override string ReturnInfo() {
            return $"Train: {model}; Brand: {Brand}; Number of Cars: {number_of_cars}; Cargo Type: {cargo_type}";
        }
        public override string GetConditionInfo() {
            return $"Current train has {battary_level} of battary left, consumed {fuel_consunption} liters of fuel, engine condition is {engine_condition}";
        }
    }
}

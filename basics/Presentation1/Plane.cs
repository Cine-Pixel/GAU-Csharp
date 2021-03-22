using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation1 {
    class Plane : Vehicle {
        public string model;
        public string type;

        public override string ReturnInfo() {
            return $"Plane: {model}; Brand: {Brand}; Type: {type}";
        }

        public Plane(string model, string type, string brand) {
            this.model = model;
            this.type = type;
            Brand = brand;
        }
    }
}

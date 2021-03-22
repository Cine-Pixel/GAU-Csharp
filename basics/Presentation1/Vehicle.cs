using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation1 {
    abstract class Vehicle {
        private string brand;

        public string Brand {
            get { return brand; }
            set {
                if (value.Length > 15) brand = "unknown";
                else brand = value;
            }
        }

        public abstract string ReturnInfo();
    }
}

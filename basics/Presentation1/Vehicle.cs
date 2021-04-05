using System;

namespace Presentation1 {
    abstract class Vehicle {
        protected string brand;
        protected string fuel_consunption;
        protected string engine_condition;
        protected string battary_level;
        public string SerialNumber { get; set; }

        public string Brand {
            get { return brand; }
            set {
                if (value.Length > 20) brand = "unknown";
                else brand = value;
            }
        }

        public abstract string ReturnInfo();
        public abstract string GetConditionInfo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6_Inheritance {
    class CuddlyToy : Toy {
        public CuddlyToy(double price, string what) : base(price, what) { }
        string animal;
        public string Animal { set { animal = value; } }

        public override string Description{
            get => $"Cuddly toy: {what}, {animal}, Price: {price}";
        }
    }
}

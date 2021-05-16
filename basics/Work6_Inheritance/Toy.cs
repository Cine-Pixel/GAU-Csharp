using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work6_Inheritance {
    class Toy {
        public static List<Toy> Toys = new List<Toy>();

        protected double price;
        protected string what;

        public Toy(double price,string what) {
            this.price = price;
            this.what = what;
        }

        public void Buy() {
            Toys.Add(this);
        }

        public virtual string Description {
            get => $"Toy: {what}, Price: {price.ToString()}";
        }
    }
}

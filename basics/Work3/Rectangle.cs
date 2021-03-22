using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3 {
    // 7.1.3
    class RectangleBase {
        private int baseSide;

        public int BaseSide {
            get { return baseSide; }
        }

        public void PrintBase() {
            Console.WriteLine(baseSide);
        }
        public RectangleBase(int s) {
            baseSide = s;
        }
    }
    class Rectangle : RectangleBase {
        private int height;

        public int GetArea() {
            return height * BaseSide;
        }
        public Rectangle(int h, int s) : base(s) { 
            height = h;
        }
    }
}

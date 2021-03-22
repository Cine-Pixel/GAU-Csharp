using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2 {
    class Otxkutxedi {
        public static int s1;
        public static int s2;
        public static int s3;
        public static int s4;

        public void GetPerimeter() {
            Console.WriteLine(s1 + s2 + s3 + s4);
        }

        public static void StartGetPerimeter() {
            Otxkutxedi square = new Otxkutxedi(10, 20, 20, 10);
            square.GetPerimeter();
        }

        public Otxkutxedi(int s1, int s2, int s3, int s4) {
            Otxkutxedi.s1 = s1;
            Otxkutxedi.s2 = s2;
            Otxkutxedi.s3 = s3;
            Otxkutxedi.s4 = s4;
        }
    }
}

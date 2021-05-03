using System;

namespace work1 {
    public class BasicHelperFunctions {
        public static double HeronsFormula(double a, double b, double c) {
            // task 2.1.10
            if (a + b <= c || a + c <= b || b + c <= a) throw new Exception("Invalid Triangle Sides");
            if (a < 0 || b < 0 || c < 0) throw new Exception("Only positive numbers are accepted");
            double p = a + b + c;
            double s = Math.Sqrt((p - a) * (p - b) * (p - c) * p);
            return s;
        } 

        public static double PercentCalculator(double a, double p) {
            // task 2.1.22
            return p * a / 100;
        }

        public static bool WeirdNumber(float x) {
            //task 3.3.4
            return x == 30 || x < 5;
        }

        public static int ArithmeticProgression(int n) {
            // task 3.4.4
            int c = 2, result=0;
            while(c<2*n) {
                result += c;
                c += 2;
            }
            return result;
        }

        public static int NumberInArray(int [] numbers) {
            // task 4.1.27
            int count = 0;
            for(int i=0; i<numbers.Length; i++) {
                if (numbers[i] > 20) count++;
            }
            return count;
        }

        public static void RelpaceNegativeN(ref int[] numbers) { 
            // task 4.1.43
            for(int i=0; i<numbers.Length; i++) {
                if (numbers[i] < 0) numbers[i] = 0;
            }
        }
    }
}

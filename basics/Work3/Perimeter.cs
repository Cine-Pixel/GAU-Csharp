using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3 {
    // 7.4.2
    class SumClass{
        public virtual int Metodi1(int[] nums) {
            return nums.Sum();
        }
    }
    
    class ProductClass : SumClass {
        public override int Metodi1(int[] nums) {
            int prod = 1;
            foreach(int num in nums) {
                prod *= num;
            }
            return prod;
        }
    }
}

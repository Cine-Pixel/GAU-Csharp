using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExer {
    class MyList : IEnumerator {
        public int[] myArray = new int[5] { 1, 2, 3, 4, 5}; 
        private int index = -1;

        public object Current => myArray[index];

        public bool MoveNext() {
            index++;
            return index < myArray.Length;
        }

        public void Reset() {
            index = -1;
        }
        public IEnumerator GetEnumerator() {
            for(int i=0; i<myArray.Length; i++) {
                yield return myArray[i];
            }
        }
    }
    class Program {
        static void Main(string[] args) {

            //MyList someList = new MyList();

            //foreach(var item in someList) {
            //    Console.WriteLine(item);
            //}

            string name = "4";
            Console.WriteLine(Convert.ToInt32(name));

            Console.ReadLine();
        }
    }
}

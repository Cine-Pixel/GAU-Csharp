using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work10 {
    class Program {
        public static void StackOperations() {
            // Task 14.2.4
            // შექმენით 10-ელემენტიანი სტეკი. წაიკითხეთ და ეკრანზე გამოიტანეთ სტეკის
            // უკანასკნელი ელემენტის მნიშვნელობა მისი წაშლის გარეშე. ეკრანზე გამოიტანეთ სტეკში
            // არსებული ელემენტების რაოდენობა და სტეკის ყველა ელემენტი. სტეკიდან ყველა ელემენტი
            // წაშალეთ.
            Random random = new Random();
            Stack<int> grades = new Stack<int>();
            for (int i=0; i<10; i++) {
                grades.Push(random.Next(50, 101));
            }

            Console.WriteLine($"Last element of stack: {grades.Peek()}");
            Console.WriteLine($"There are {grades.Count} element in the stack");
            Console.WriteLine($"Stack elements: {string.Join(", ", grades)}");
            grades.Clear();
            Console.WriteLine($"There are {grades.Count} elements in the stack");
        }

        public static void BitArrayOperations() {
            // Task 14.2.5
            // შექმენით ბიტების 2 მასივი, თითოეული 10-ელემენტიანი. ამ მასივებზე შეასრულეთ და,
            // ან, არა და გამომრიცხავი ან ოპერაციები.
            Random random = new Random();
            int arrayLength = 10;
            BitArray ba1 = new BitArray(arrayLength);
            BitArray ba2 = new BitArray(arrayLength);

            for (int i=0; i<random.Next(1, arrayLength); i++) {
                int randomIdx = random.Next(0, arrayLength);
                ba1[randomIdx] = !ba1[randomIdx];

                int randomIdx2 = random.Next(0, arrayLength);
                ba2[randomIdx2] = !ba1[randomIdx2];
            }

            for (int i=0; i<arrayLength; i++) {
                Console.WriteLine($"ba1[{i}] AND ba2[{i}]: {ba1[i] & ba2[i]}");
                Console.WriteLine($"ba1[{i}] OR ba2[{i}]: {ba1[i] | ba2[i]}");
                Console.WriteLine($"NOT ba1[{i}]: {!ba1[i]}");
                Console.WriteLine($"NOT ba2[{i}]: {!ba2[i]}");
                Console.WriteLine($"ba1[{i}] XOR ba2[{i}]: {ba1[i] ^ ba2[i]}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Task 14.2.4");
            Console.WriteLine("Stack operations");
            StackOperations();
            Console.WriteLine();

            Console.WriteLine("Task 14.2.5");
            Console.WriteLine("BitArray operations");
            BitArrayOperations();

            Console.ReadLine();
        }
    }
}

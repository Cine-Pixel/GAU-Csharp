using System;
using basic_function_library;

namespace basics {
    class Program {
        static void Main(string[] args) {
            string input;
            Console.WriteLine("Chapter 2, task 2.1.10");
            Console.WriteLine("Area of triangle:");
            Console.Write("Enter 3 sides: ");
            input = Console.ReadLine();
            var numbers = input.Split(' ');
            Console.WriteLine($"The area is {BasicHelperFunctions.HeronsFormula(double.Parse(numbers[0]), double.Parse(numbers[1]), double.Parse(numbers[2]))}\n");

            Console.WriteLine("Chapter 2, task 2.1.10");
            Console.Write("Enter number and percent you want to find: ");
            input = Console.ReadLine();
            var nums = input.Split(' ');
            Console.WriteLine($"{nums[1]} percent of {nums[0]} is {BasicHelperFunctions.PercentCalculator(double.Parse(nums[0]), double.Parse(nums[1]))}\n");

            Console.WriteLine("Chapter 3, task 3.3.4");
            Console.WriteLine("Enter 1 number: ");
            float x = float.Parse(Console.ReadLine());
            if (BasicHelperFunctions.WeirdNumber(x)) Console.WriteLine($"The number {x} is equalt to 30 or is less than 5");
            else Console.WriteLine($"The number {x} is not equal to 30 and is not less than 5j\n");

            Console.WriteLine("Chapter 3, task 3.4.4");
            Console.WriteLine(BasicHelperFunctions.ArithmeticProgression(12));

            Console.WriteLine("\nChapter 4, task 4.1.27");
            Console.WriteLine("Enter length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[arrayLength]; 
            for(int i=0; i<arrayLength; i++) {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Number of elements greater than 20 is: ");
            Console.WriteLine(BasicHelperFunctions.NumberInArray(numbersArray));

            Console.WriteLine("\nChapter 4, task 4.1.43");
            BasicHelperFunctions.RelpaceNegativeN(ref numbersArray);
            foreach(int num in numbersArray) {
                Console.Write("{0} ", num);
            }

            Console.ReadKey();
        }
    }
}

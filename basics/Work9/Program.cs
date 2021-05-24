using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Work9 {
    class Program {
        public static int CountPalindrome(string sentence) {
            // Task 12.3.52
            // დაადგინეთ რამდენი პალინდრომია მოცემულ ტექსტში. პალინდრომია, მაგალითად,"აბგგბა", 123321 და ა.შ.
            int palindromeWords = 0;
            string parsedSentence = Regex.Replace(sentence.ToLower(), @"[^\w\s]", "");

            foreach(string word in parsedSentence.Split(' ')) {
                if (word.SequenceEqual(word.Reverse())) palindromeWords++;
            }

            return palindromeWords;
        }

        public static int CountAlmas(string sentence) {
            // Task 12.3.53
            // სიტყვას, რომელიც იწყება და მთავრდება ერთი და იგივე სიმბოლოთი უწოდებენ
            // ალმასისმაგვარს. შეადგინეთ პროგრამა, რომელიც სტრიქონში დათვლის ალმასისმაგვარი
            // სიტყვების რაოდენობას.
            int almasWords = 0;
            string parsedSentence = Regex.Replace(sentence.ToLower(), @"[^\w\s]", "");

            foreach(string word in parsedSentence.Split(' ')) {
                if (word[0] == word[word.Length - 1]) almasWords++;
            }

            return almasWords;
        }

        static void Main(string[] args) {
            Console.WriteLine("Task 12.3.52");
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"There are {CountPalindrome(sentence)} palindrome words.");
            Console.WriteLine();

            Console.WriteLine("Task 12.3.53");
            Console.Write("Enter sentence: ");
            string sentence2 = Console.ReadLine();
            Console.WriteLine($"There are {CountAlmas(sentence2)} almas words.");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

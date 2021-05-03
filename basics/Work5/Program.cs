using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work5 {
    class Program {
        #region ProblemSolutions
        static List<int> RunningSum(List<int> nums) {
            /*
            [[ List ]]
            Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
            Return the running sum of nums.
            https://leetcode.com/problems/running-sum-of-1d-array/
            */
            List<int> rnSum = new List<int>();
            rnSum.Add(nums[0]);
            for(int i=1; i<nums.Count; i++) {
                rnSum.Add(rnSum[i - 1] + nums[i]);
            }
            return rnSum;
        }

        static bool ValidParentheses(string s) {
            /*
            [[ Stack ]]
            Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
            An input string is valid if:
            1. Open brackets must be closed by the same type of brackets.
            2. Open brackets must be closed in the correct order.
            https://leetcode.com/problems/valid-parentheses/
            */

            Stack<char> seq = new Stack<char>();
            for(int i=0; i<s.Length; i++) {
                char c = s[i];
                if(c == '(' || c == '[' || c == '{') {
                    seq.Push(c);
                } else {
                    if (seq.Count == 0) return false;
                    if (c == ')' && seq.Peek() != '(') return false;
                    if (c == ']' && seq.Peek() != '[') return false;
                    if (c == '}' && seq.Peek() != '{') return false;
                    seq.Pop();
                }
            }
            if (seq.Count == 0) return true;
            else return false;
        }
        static int singleNumber(List<int> nums) {
            /* 
            [[ Dictionary ]]
            Given an integer array nums where every element appears three times except for one, which appears exactly once. 
            Find the single element and return it.
            https://leetcode.com/problems/single-number-ii/
            */
            var map = new Dictionary<int, int>();
            foreach(var n in nums){
                if(map.ContainsKey(n))
                    map[n]++;
                else map.Add(n,1);
            }
        
        return map.FirstOrDefault(x => x.Value == 1).Key;
        }
        #endregion

        static void Main(string[] args) {
            #region List
            Console.WriteLine("List example");
            List<int> runningSumInput = new List<int> { 1, 2, 3, 4 };
            List<int> runningSumOutput = RunningSum(runningSumInput);
            Console.WriteLine("Expected output: 1 3 6 10");
            Console.Write("Actual output: ");
            runningSumOutput.ForEach(delegate(int num) { Console.Write($"{num} "); });
            Console.WriteLine("\n");
            #endregion

            #region Stack
            Console.WriteLine("Stack example");
            string valPharenthesesInput = "()[]{}";
            Console.WriteLine("Expected output: True");
            Console.WriteLine($"Actual output: {ValidParentheses(valPharenthesesInput)}");
            Console.WriteLine();
            #endregion

            #region Dictionary
            Console.WriteLine("Dictionary example");
            List<int> singleNumberInput = new List<int> { 2, 2, 3, 2 };
            Console.WriteLine("Expected output: 3");
            Console.WriteLine($"Actual output: {singleNumber(singleNumberInput)}");
            #endregion

            Console.ReadLine();
        }
    }
}

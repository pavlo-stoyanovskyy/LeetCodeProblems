using System;

namespace LeetCodeProblems._020_Valid_Parentheses
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();

            PrintCase(s, string.Empty);
            PrintCase(s, "()");
            PrintCase(s, "()[]{}");
            PrintCase(s, "(]");
            PrintCase(s, "([)]");
            PrintCase(s, "{[]}");
        }

        public static void PrintCase(Solution s, string input)
        {
            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: " + s.IsValid(input));
        }
    }
}

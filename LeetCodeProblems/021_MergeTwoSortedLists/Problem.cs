using System;
using LeetCodeProblems._021_MergeTwoSortedLists.Classes;

namespace LeetCodeProblems._021_MergeTwoSortedLists
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();

            //PrintCase(s, null, null);
            PrintCase(s, new ListNode(1), new ListNode(2));
            //PrintCase(s, "()");
            //PrintCase(s, "()[]{}");
            //PrintCase(s, "(]");
            //PrintCase(s, "([)]");
            //PrintCase(s, "{[]}");
        }

        public static void PrintCase(Solution s, ListNode l1, ListNode l2)
        {
            var res = s.MergeTwoLists(l1, l2);

            //Console.WriteLine("Input: " + input);
            //Console.WriteLine("Output: " + s.IsValid(input));
        }
    }
}

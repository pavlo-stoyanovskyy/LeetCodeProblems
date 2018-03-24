using System;
using System.Collections.Generic;

namespace LeetCodeProblems._127_WordLadder
{
    /// <summary>
    /// https://leetcode.com/problems/word-ladder/description/
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();

            int result = s.LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
            Console.WriteLine(result);
        }
    }
}

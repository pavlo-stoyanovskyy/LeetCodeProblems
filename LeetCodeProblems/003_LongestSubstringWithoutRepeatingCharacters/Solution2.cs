using System;
using System.Collections.Generic;

namespace LeetCodeProblems._003_LongestSubstringWithoutRepeatingCharacters
{
    class Solution2
    {
        /// <summary>
        /// Sliding Window
        /// </summary>
        public int LengthOfLongestSubstring(string s)
        {
            int i = 0, j = 0, result = 0;
            var set = new HashSet<char>();
            while (i < s.Length && j < s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    var ch = s[j];
                    set.Add(ch);
                    j++;
                    result = Math.Max(result, j - i);
                }
                else
                {
                    var ch = s[i];
                    i++;
                    set.Remove(ch);
                }
            }
            return result;
        }
    }
}

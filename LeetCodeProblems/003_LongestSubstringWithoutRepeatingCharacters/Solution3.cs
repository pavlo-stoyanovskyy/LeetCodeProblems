using System;
using System.Collections.Generic;

namespace LeetCodeProblems._003_LongestSubstringWithoutRepeatingCharacters
{
    class Solution3
    {
        /// <summary>
        /// Sliding Window Optimized
        /// </summary>
        public int LengthOfLongestSubstring(string s)
        {
            int currentMax = -1, result = 0;
            var dictionary = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (dictionary.ContainsKey(ch))
                {
                    currentMax = Math.Max(dictionary[ch], currentMax);                    
                }
                dictionary[ch] = i;
                result = Math.Max(result, i - currentMax);
            }
            return result;
        }
    }
}

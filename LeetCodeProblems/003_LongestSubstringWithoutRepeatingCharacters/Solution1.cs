using System.Collections.Generic;

namespace LeetCodeProblems._003_LongestSubstringWithoutRepeatingCharacters
{
    class Solution1
    {
        /// <summary>
        /// Brute Force
        /// </summary>        
        public int LengthOfLongestSubstring(string s)
        {
            var length = s.Length;
            for (var i = 0; i < length; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    var longestLength = length - i;
                    if (AreNoRepeatingCharacters(s.Substring(j, longestLength)))
                    {
                        return longestLength;
                    }
                }
            }
            return 0;
        }

        private bool AreNoRepeatingCharacters(string s)
        {
            var set = new HashSet<char>(s.Length);
            for (var i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (set.Contains(ch))
                {
                    return false;
                }
                set.Add(ch);
            }
            return true;
        }
    }
}

namespace LeetCodeProblems._001_TwoSum
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();

            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var result = s.TwoSum(nums, target);
        }
    }
}

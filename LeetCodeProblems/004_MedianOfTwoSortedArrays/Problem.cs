namespace LeetCodeProblems._004_MedianOfTwoSortedArrays
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            int[] nums1 = null;
            int[] nums2 = null;

            //The median is 2.0
            nums1 = new int[] { 1, 3 };
            nums2 = new int[] { 2 };

            ////The median is 2.0
            //nums1 = new int[] { 1, 2 };
            //nums2 = new int[] { 4, 4 };

            var s = new Solution();
            var r = s.FindMedianSortedArrays(nums1, nums2);
        }
    }
}

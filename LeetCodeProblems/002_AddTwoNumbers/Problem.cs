namespace LeetCodeProblems._002_AddTwoNumbers
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/description/
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();
            //var l1 = s.CreateList(new int[] { 2, 4, 3});
            //var l2 = s.CreateList(new int[] { 5, 6, 4 });
            //var l1 = s.CreateList(new int[] { 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9 });
            //var l2 = s.CreateList(new int[] { 5, 6, 4, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 2, 4, 3, 9, 9, 9, 9 });
            var l1 = s.CreateList(new int[] { 5 });
            var l2 = s.CreateList(new int[] { 5 });
            var result = s.AddTwoNumbers(l1, l2);
        }
    }
}

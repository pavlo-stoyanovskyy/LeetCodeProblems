namespace LeetCodeProblems._035_SearchInsertPosition
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position
    /// </summary>
    class Problem
    {
        public static void Solve(string[] args)
        {
            Solution s = new Solution();

            //2
            var res1 = s.SearchInsert(new[] { 1, 3, 5, 6 }, 5);
            //1
            var res2 = s.SearchInsert(new[] { 1, 3, 5, 6 }, 2);
            //4
            var res3 = s.SearchInsert(new[] { 1, 3, 5, 6 }, 7);
            //0
            var res4 = s.SearchInsert(new[] { 1, 3, 5, 6 }, 0);
            //0
            var res5 = s.SearchInsert(new[] { 1, 3 }, 0);
            //1
            var res6 = s.SearchInsert(new[] { 1, 3 }, 2);
        }
    }
}

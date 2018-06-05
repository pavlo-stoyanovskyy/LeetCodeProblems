namespace LeetCodeProblems._035_SearchInsertPosition
{
    class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        private int BinarySearch(int[] nums, int l, int h, int target)
        {
            if (l <= h)
            {
                int mid = l + (h - l) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                int new_l = 0, new_h = 0;
                if (nums[mid] > target)
                {
                    new_l = l;
                    new_h = mid - 1;
                }
                if (nums[mid] < target)
                {
                    new_l = mid + 1;
                    new_h = h;
                }
                if (new_l > new_h)
                {
                    return SearchClosest(nums, mid, target);
                }
                return BinarySearch(nums, new_l, new_h, target);
            }
            return -1;
        }

        private int SearchClosest(int[] nums, int mid, int target)
        {
            if (nums[mid] > target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                return mid + 1;
            }
            return -1;
        }
    }
}

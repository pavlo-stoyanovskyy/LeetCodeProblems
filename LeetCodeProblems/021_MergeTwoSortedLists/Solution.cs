using LeetCodeProblems._021_MergeTwoSortedLists.Classes;

namespace LeetCodeProblems._021_MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            if (l1 == null && l2 != null)
                return l2;
            if (l1 != null && l2 == null)
                return l1;
            var head = (ListNode)null;
            var node = (ListNode)null;
            while (l1 != null || l2 != null)
            {
                var val = 0;
                if (l1 != null &&  (l2 == null || l1.val < l2.val))
                {
                    val = l1.val;
                    l1 = l1.next;
                }
                else if (l2 != null && ( l1 == null || l2.val <= l1.val))
                {
                    val = l2.val;
                    l2 = l2.next;
                }
                if (head == null)
                {
                    head = new ListNode(val);
                    node = head;
                }
                else
                {
                    node.next = new ListNode(val);
                    node = node.next;
                }
            }
            return head;
        }
    }
}

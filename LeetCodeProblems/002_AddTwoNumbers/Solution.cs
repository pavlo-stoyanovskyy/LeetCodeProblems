using LeetCodeProblems._002_AddTwoNumbers.Classes;

namespace LeetCodeProblems._002_AddTwoNumbers
{
    class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var c1 = l1;
            var c2 = l2;
            var carry = 0;
            var head = (ListNode)null;
            var current = (ListNode)null;            
            while (c1 != null || c2 !=null || carry != 0)
            {
                var val1 = 0;                
                if (c1 != null)
                {
                    val1 = c1.val;
                    c1 = c1.next;
                }
                var val2 = 0;
                if (c2 != null)
                {
                    val2 = c2.val;
                    c2 = c2.next;
                }
                var sum = val1 + val2 + carry;
                carry = sum / 10;
                var newNode = new ListNode(sum % 10);
                if (head == null)
                {
                    head = newNode;
                    current = head;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }              
            }
            return head;
        }

        public ListNode CreateList(int[] values)
        {
            var head = (ListNode)null;
            var current = (ListNode)null;
            foreach (var val in values)
            {
                var newNode = new ListNode(val);
                if (head == null)
                {
                    head = newNode;
                    current = head;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }
            }
            return head;
        }
    }
}

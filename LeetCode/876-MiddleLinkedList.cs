//Problem: https://leetcode.com/problems/middle-of-the-linked-list/
namespace LeetCode {
    public partial class Solution {
        public ListNode MiddleNode(ListNode head) {
            ListNode middle = head;
            head = head.next;
            while(head != null) {
                head = head.next?.next;
                middle = middle.next;
            }

            return middle;
        }
    }
}
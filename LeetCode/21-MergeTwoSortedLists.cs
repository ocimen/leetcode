//Problem: https://leetcode.com/problems/merge-two-sorted-lists/
namespace LeetCode {
    public partial class Solution {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            if(l1==null) return l2;
            if(l2==null) return l1;
            ListNode head;
            if(l1.val <= l2.val) {
                head = l1;
                l1 = l1.next;
            }
            else {
                head = l2;
                l2 = l2.next;
            }
            head.next = MergeTwoLists(l1,l2);
            return head;
        }
    }
}
// Problem: https://leetcode.com/problems/reverse-linked-list/

namespace LeetCode {
    public partial class Solution {
        public ListNode ReverseList(ListNode head) {
            if(head == null) {
                return null;
            }
            
            ListNode prev = null;
            ListNode next;
            
            while(head != null) {
                next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            
            return prev;
        }
    }
}
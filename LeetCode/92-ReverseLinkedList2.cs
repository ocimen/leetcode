// Problem: https://leetcode.com/problems/reverse-linked-list-ii/

namespace LeetCode {
    public partial class Solution {
        public ListNode ReverseBetween(ListNode head, int left, int right) {
            if(head == null) {
                return null;
            }
            
            if(left == right)  {
                return head;
            }
            
            ListNode current = head, previous = null;

            // find left
            while(left > 1) {
                previous = current;
                current = current.next;
                left--;
                right--;
            }

            ListNode lastNodeOfFirstPart = previous;
            ListNode lastNodeOfSubList = current;
            ListNode next;

            while(right > 0) {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                right--;
            }

            if(lastNodeOfFirstPart != null) {
                lastNodeOfFirstPart.next = previous;
            }
            else {
                head = previous;
            }

            lastNodeOfSubList.next = current;
            return head;
        }
    }
}
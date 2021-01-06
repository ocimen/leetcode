//Problem:https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
namespace LeetCode {
    public partial class Solution {
        public int GetDecimalValue(ListNode head) {
            var num = head.val;
            while(head.next != null) {
                num = (num * 2) + head.next.val;
                head = head.next;
            }

            return num;
        }
    }    
}
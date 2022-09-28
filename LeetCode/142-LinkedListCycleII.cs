// Problem https://leetcode.com/problems/linked-list-cycle-ii/

namespace LeetCode {
    public partial class Solution {
        public ListNode DetectCycle(ListNode head) {
            if(head != null) {
            var hashSet = new HashSet<ListNode>();
            while(head.next != null) {
                if(hashSet.Contains(head)) {
                    return head;
                }
                hashSet.Add(head);
                head = head.next;
            }}
            
            return null;
        }
    }
}
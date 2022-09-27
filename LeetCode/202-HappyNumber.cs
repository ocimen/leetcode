//Problem: https://leetcode.com/problems/happy-number/

using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public bool IsHappyTwoPointer(int n) {
            int slow = n, fast = n;
            do {
                slow = FindSquares(slow);
                fast = FindSquares(FindSquares(fast));
            } while (slow != fast);
            
            return slow == 1;
        }

        public bool IsHappyHashSet(int num)
        {
            var hashSet = new HashSet<int>();
            while (!hashSet.Contains(num) && num != 1)
            {
                hashSet.Add(num);
                num = FindSquares(num);
            }
            
            return num == 1;
        }
        
        public int FindSquares(int n) {
            int sum = 0, digit;
            while(n > 0) {
                digit = n % 10;
                sum += digit * digit;
                n = n / 10;
            }
            
            return sum;
        }
    }
}
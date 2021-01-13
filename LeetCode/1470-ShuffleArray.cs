//Problem: https://leetcode.com/problems/shuffle-the-array/
namespace LeetCode {
    public partial class Solution {
        public int[] Shuffle(int[] nums, int n) {
            var result = new int[nums.Length];
            var current = 0;
            for(int i=0; i < n; i++) {
                result[current++] = nums[i];               
                result[current++] = nums[n+i];
            }
            
            return result;
        }
    }
}
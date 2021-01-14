//Problem: https://leetcode.com/problems/running-sum-of-1d-array/
namespace LeetCode {
    public partial class Solution {
        public int[] RunningSum(int[] nums) {
            for(var i=1; i < nums.Length; i++) {
                nums[i] += nums[i-1];
            }
            
            return nums;
        }
    }
}
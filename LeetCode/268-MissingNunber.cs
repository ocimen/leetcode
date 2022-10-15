// Problem: https://leetcode.com/problems/missing-number/

namespace LeetCode {
    public partial class Solution {
        public int MissingNumber(int[] nums) {
            int i =0;
            while(i < nums.Length) {
                if(nums[i] < nums.Length && nums[i] != nums[nums[i]]) {
                    swap(nums, i, nums[i]);
                }
                else
                {
                    i++;
                }
            }
            
            for(i = 0; i < nums.Length; i++) {
                if(i != nums[i]) {
                    return i;
                }
            }
            
            return nums.Length;
        }
        
        private void swap(int[] nums, int i, int j) {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
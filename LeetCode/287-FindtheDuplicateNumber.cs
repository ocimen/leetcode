// Problem: https://leetcode.com/problems/find-the-duplicate-number/

namespace LeetCode {
    public partial class Solution {
        public int FindDuplicate(int[] nums) {
            int i = 0;
            while(i < nums.Length) {
                if(nums[i] != nums[nums[i] - 1]) {
                    swap(nums, i, nums[i] - 1);
                }
                else {
                    i++;
                }
            }
            
            return nums[nums.Length - 1];
        }
        
        private void swap(int[] nums, int i, int j) {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
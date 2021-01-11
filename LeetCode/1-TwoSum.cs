// Problem:https://leetcode.com/problems/two-sum/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public int[] TwoSum(int[] nums, int target) {
            var dict = new Dictionary<int,int>();
            for(int i = 0; i< nums.Length;i++) {
                var diff = target - nums[i];
                if(dict.ContainsKey(diff)) {
                    return new int[] {dict[diff], i};
                }
                else {
                    dict.Add(nums[i], i);
                }
            }
            
            return null;
        }
    }
}
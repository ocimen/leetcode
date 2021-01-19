// Problem: https://leetcode.com/problems/number-of-good-pairs/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public int NumIdenticalPairs(int[] nums) {
            var counter = 0;
            var dict = new Dictionary<int, List<int>>();
            var list = new List<int>();
            for(int i = 0; i < nums.Length; i++) {
                if(dict.ContainsKey(nums[i])) {
                    list = dict.GetValueOrDefault(nums[i]);
                    list.Add(i);
                    dict[nums[i]] = list;
                }
                else {
                    dict.Add(nums[i], new List<int>() {i});    
                }       
            }

            foreach (var item in dict)
            {
                counter += item.Value.Count * (item.Value.Count - 1);
            }

            return counter / 2;
        }
    }
}
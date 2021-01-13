//Problem: https://leetcode.com/problems/find-lucky-integer-in-an-array/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public int FindLucky(int[] arr) {
            var dict = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++) {
                if(dict.ContainsKey(arr[i])){
                    dict[arr[i]] = dict[arr[i]] + 1;
                }
                else {
                    dict.Add(arr[i], 1);
                }
            }

            var result = -1;
            foreach(var item in dict) {
                if(item.Key == item.Value) {
                    if(item.Value > result) {
                        result = item.Key;
                    }
                }
            }
            
            return result;
        }
    }
}
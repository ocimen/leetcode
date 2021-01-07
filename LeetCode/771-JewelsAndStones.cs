//Problem: https://leetcode.com/problems/jewels-and-stones/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public int NumJewelsInStones(string jewels, string stones) {
            var hashSet = new HashSet<char>(jewels);
            int count = 0;
            for(int i= 0; i < stones.Length; i++) {
                if(hashSet.Contains(stones[i])) {
                    count++;
                }
            }
            
            return count;
        }
    }
}
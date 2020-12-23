//Problem:https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
using System.Collections.Generic;
using System.Linq;

namespace LeetCode {
    public partial class Solution {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
            var result = new List<bool>();
            var max = candies.Max();

            for(var i=0; i < candies.Length; i++) {
                result.Add(candies[i] + extraCandies >= max);
            }

            return result;
        }
    }
}
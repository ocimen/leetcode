// Problem: https://leetcode.com/problems/contains-duplicate/
using System.Collections.Generic;

namespace LeetCode {
  public partial class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashSet = new HashSet<int>(nums);
        return hashSet.Count != nums.Length;
    }
  }
}
//Problem: https://leetcode.com/problems/count-the-number-of-consistent-strings/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public int CountConsistentStrings(string allowed, string[] words) {
            int count = 0;
            var allow = new HashSet<char>(allowed);

            for (int i = 0; i < words.Length; i++) {
                for(int j = 0; j < words[i].Length;j++) {
                    if(!allow.Contains(words[i][j])) {
                        break;
                    }
                    if(j == words[i].Length-1) {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
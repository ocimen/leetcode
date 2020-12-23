//Problem: https://leetcode.com/problems/reverse-string/
namespace LeetCode {
    public partial class Solution {
        public void ReverseString(char[] s) {
            int n = s.Length;
            char temp;
            for(int i=0; i < s.Length / 2; i++, n--) {
                temp = s[i];
                s[i] = s[n-1];
                s[n-1] = temp;
            }
        }
    }
}
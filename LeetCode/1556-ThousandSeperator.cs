//Problem:https://leetcode.com/problems/thousand-separator/
using System.Text;

namespace LeetCode {
    public partial class Solution {
        public string ThousandSeparator(int n) {
        var str = n.ToString();
        var builder = new StringBuilder();
        for(int i = 0; i < str.Length;) {
            builder.Append(str[i]);
            i++;
            if((str.Length - i) % 3 == 0 && i != str.Length) {
                builder.Append('.');
            }
        }

        return builder.ToString();
        }
    }
}
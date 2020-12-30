//Problem:https://leetcode.com/problems/defanging-an-ip-address/
using System.Text;

namespace LeetCode {
    public partial class Solution {
        //Runtime:84ms Memorry:23.2MB
        public string DefangIPaddr(string address) {
            var builder = new StringBuilder();
            foreach(var character in address) {
                if(character == '.') {
                    builder.Append("[.]");
                }
                else {
                    builder.Append(character);
                }
            }
            
            return builder.ToString();
        }

        //Runtime: 72ms Memory:23.6MB
        public string DefangIPaddrWithReplace(string address) {
        return address.Replace(".", "[.]");
        }
    }    
}
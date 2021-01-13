//Problem: https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
namespace LeetCode {
    public partial class Solution {
        public int NumberOfSteps (int num) {
            int counter = 0;
            while(num > 0) {
                if(num % 2 == 0) {
                    num = num / 2;
                }
                else {
                    num = num -1;
                }
                counter++;
            }
            
            return counter;
        }
    }
}
// Problem: https://leetcode.com/problems/fizz-buzz/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public IList<string> FizzBuzz(int n) {
            int index = 1;
            var resultList = new List<string>();
            while(index <= n) {
                if (index % 3 == 0 && index % 5 == 0) {
                    resultList.Add("FizzBuzz");
                    index++;
                    continue;
                }
                else if(index % 3 == 0) {
                    resultList.Add("Fizz");
                    index++;
                    continue;
                }
                else if(index % 5 == 0) {
                    resultList.Add("Buzz");
                    index++;
                    continue;
                }
                else {
                    resultList.Add($"{index}");
                    index++;
                }
            }

            return resultList;
        }
    }
}
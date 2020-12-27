//Problem: https://leetcode.com/problems/baseball-game
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode {
    public partial class Solution {
        public int CalPoints(string[] ops) {
            var baseball = new Stack<int>();
            for(int i=0; i < ops.Length; i++) {
                if(ops[i] == "+") {
                    var last = baseball.Pop();
                    var previous = baseball.Peek();
                    baseball.Push(last);
                    baseball.Push(last + previous);
                }
                else if(ops[i] == "D") {
                    var peek = baseball.Peek();                
                    baseball.Push(peek * 2);
                }
                else if(ops[i] == "C") {
                    baseball.Pop();
                }
                else {
                    baseball.Push(Convert.ToInt32(ops[i]));
                }
            }
            
            return baseball.Sum();
        }
    }
}
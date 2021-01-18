// Problem: https://leetcode.com/problems/goal-parser-interpretation/
using System.Collections.Generic;

namespace LeetCode {
    public partial class Solution {
        public string Interpret(string command) {
            var interpreted = new List<char>();
            for(int i = 0; i < command.Length; i++) {
                if(command[i] == 'G') {
                    interpreted.Add('G');
                }
                else {
                    if(command[i] == ')' && command[i-1] == '(') {
                        interpreted.Add('o');                    
                    }
                    else if(command[i] ==')' && command[i-1] =='l') {
                        interpreted.Add('a');                    
                        interpreted.Add('l');                    
                    }
                }
                
            }
            return new string(interpreted.ToArray());
        }
    }
}
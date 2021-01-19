// Problem: https://leetcode.com/problems/richest-customer-wealth/
using System;

namespace LeetCode {
    public partial class Solution {
        public int MaximumWealth(int[][] accounts) {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < accounts.Length; i++) {
                count = 0;
                for(int j =0; j < accounts[i].Length; j++) {
                    count += accounts[i][j];
                }
                sum = Math.Max(sum,count);
            }
            return sum;
        }
    }
}
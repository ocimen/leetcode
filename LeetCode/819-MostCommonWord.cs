// Problem: https://leetcode.com/problems/most-common-word/
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode {
    public partial class Solution {
        public string MostCommonWord(string paragraph, string[] banned) {
            var wordList = Regex.Replace(paragraph, @"[^\w\s]", " ").ToLower().Split(' ');
            var wordCount = new Dictionary<string, int>();
            var bannedList = banned.ToList();
            
            for(int i = 0; i < wordList.Length; i++) {
                if(wordList[i] == string.Empty || bannedList.Contains(wordList[i])) {
                    continue;
                }
                if(wordCount.ContainsKey(wordList[i])) {
                    var value = wordCount.GetValueOrDefault(wordList[i]);
                    wordCount[wordList[i]] = value + 1;
                }
                else {
                    wordCount.Add(wordList[i], 1);    
                }            
            }
                    
            return wordCount.OrderByDescending(x => x.Value).FirstOrDefault().Key;            
        }
    }
}
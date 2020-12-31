namespace LeetCode {
    public partial class Solution {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
            return string.Join("", word1).GetHashCode() == string.Join("", word2).GetHashCode();
        }
    }
}
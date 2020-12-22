//Problem: https://leetcode.com/problems/fibonacci-number/
public class Solution {
    public int Fib(int N) {
        if(N <= 1) {
            return N;
        }
        
        int[] map = new int[N+1];
        map[0] = 0;
        map[1] = 1;
        
        for(int i=2; i <=N; i++) {
            map[i] = map[i-1] + map[i-2];
        }
        
        return map[N];
    }
}
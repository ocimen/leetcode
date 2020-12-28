//Problems:https://leetcode.com/problems/number-of-recent-calls/
using System.Collections.Generic;
using System.Linq;

namespace LeetCode {
    public class RecentCounter {

    Queue<int> requests;
    
    public RecentCounter() {
        requests = new Queue<int>();
    }
    
    public int Ping(int t) {
        requests.Enqueue(t);
        while(t - requests.Peek() > 3000) {
            requests.Dequeue();
        }
        
        return requests.Count();
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
}
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>();

        foreach(var num in nums)
        {
            pq.Enqueue(num, -num);
        }
        int res = 0;
        for(int i = 1; i <= k; i++)
        {
            if(i == k)
                res = pq.Peek();
            pq.Dequeue();
        }

        return res;
    }
}

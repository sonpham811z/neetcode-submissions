class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        pq = []
        for i in stones:
            heapq.heappush(pq, -i)
        
        while(len(pq) > 1):
            heapq.heappush(pq, -(abs(-heapq.heappop(pq) + heapq.heappop(pq))))
    
        return -heapq.heappop(pq)
        
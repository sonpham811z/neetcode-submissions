class Solution:
    def lastStoneWeight(self, stones: List[int]) -> int:
        pq = []
        for i in stones:
            heapq.heappush(pq, -i)
        
        while(len(pq) > 1):
            number_1 = -heapq.heappop(pq)
            number_2 = -heapq.heappop(pq)
            heapq.heappush(pq, -(abs(number_1 - number_2)))
    
        return -heapq.heappop(pq)
        
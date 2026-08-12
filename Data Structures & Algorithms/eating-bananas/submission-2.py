class Solution:
    def check(self, piles: List[int],k: int,  h: int)->bool:
        total=0
        for i in piles:
            total += math.ceil(i/k)
            if(total > h):
                return False
        return True
            
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        low = 1
        hight = max(piles)
        min_res = float('inf')

        while(low <= hight):
            mid = (low+hight)//2
            
            # min_res = min(min_res, total)
            if(self.check(piles, mid, h) == True):
                min_res = min(min_res, mid)
                hight = mid - 1
            else:
                low= mid+1
           
        return min_res
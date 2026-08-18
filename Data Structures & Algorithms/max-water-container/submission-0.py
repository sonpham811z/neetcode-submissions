class Solution:
    def maxArea(self, heights: List[int]) -> int:
        i = 0
        j = len(heights) - 1
        max_s = -1
        while(i < j):
            s = abs(j-i) * min(heights[i], heights[j])
            max_s = max(max_s, s)
            
            if(heights[i] > heights[j]):
                j = j - 1
            else:
                i = i + 1

        return max_s

        
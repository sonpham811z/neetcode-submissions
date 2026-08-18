class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if(len(nums) == 0):
            return 0
        nums_set = set(nums)

        count = 1
        for i in nums_set:
            k = i
            if(i - 1 not in nums_set):
                tmp = 1
                while(k+1 in nums_set):
                    tmp = tmp + 1
                    k = k+1
                count = max(count, tmp)

        return count        
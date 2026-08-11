class Solution:
    # ---------------------------------------------------------
    # HÀM CỦA BRO (Tui đã fix lỗi syntax, giữ nguyên logic)
    # ---------------------------------------------------------
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        res = []
        nums.sort() # Đã sửa: không gán nums = nums.sort()
       
        
        for i in range(len(nums)-2):
            a = i+1
            b = len(nums) - 1
            if(i > 0 and nums[i] == nums[i-1]):
                continue
            while(a<b):
                tmp = nums[i]+nums[a]+nums[b]
                if(tmp == 0):
                    res.append([nums[i], nums[a], nums[b]])
                    b=b-1
                    a=a+1
                elif(tmp > 0):
                    b=b-1
                elif(tmp < 0):
                    a=a+1
        result = []
        for sub in res:
            if sub not in result:
                result.append(sub)
        return result

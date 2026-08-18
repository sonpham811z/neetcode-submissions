class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if(len(s) == 0):
            return 0
        max_length = -float("inf")
        current_length = 0
        left = 0

        set_s = set()

        for right in range(len(s)):
            if(s[right] not in set_s):
                set_s.add(s[right])
                max_length = max(max_length, right - left + 1)
                continue
            
            while(s[right] in set_s):
                set_s.remove(s[left])
                left += 1
            set_s.add(s[right])


        return max_length


        
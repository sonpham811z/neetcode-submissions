class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        const = [0] * 26
        left = 0
        max_length = -1

        for right in range(len(s)):
            const[ord(s[right]) - ord('A')] += 1
            
            while((right - left + 1) - max(const) > k):

                const[ord(s[left]) - ord('A')] -= 1
                left = left + 1
            
            print(right, left)
            max_length = max(max_length, (right - left + 1) )

        return max_length
class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        max_length = 0
        left = 0
        char_index_map = {}  # Lưu ký tự và vị trí xuất hiện cuối cùng của nó

        for right in range(len(s)):
            # Nếu ký tự đã tồn tại và nằm trong cửa sổ hiện tại
            if s[right] in char_index_map and char_index_map[s[right]] >= left:
                # Dịch left sang bên phải vị trí cũ của ký tự đó
                left = char_index_map[s[right]] + 1
            
            # Cập nhật vị trí mới nhất của ký tự
            char_index_map[s[right]] = right
            # Tính toán chiều dài lớn nhất
            max_length = max(max_length, right - left + 1)

        return max_length

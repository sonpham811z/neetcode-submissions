class Solution:
    def binary_search(self, arr, target) -> bool:
        low = 0
        high = len(arr) - 1

        while low <= high:
            mid = (low + high) // 2
            
            if arr[mid] == target:
                return True
            elif arr[mid] < target:
                low = mid + 1
            else:
                high = mid - 1
        
        return False

    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for i in range(len(matrix)):
            if matrix[i][-1] == target:
                return True
            if matrix[i][-1] < target:
                continue
            if matrix[i][-1] > target:
                if(self.binary_search(matrix[i], target)):
                    return True
        
        return False

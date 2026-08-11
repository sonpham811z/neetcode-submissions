# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def validateBST(self, node: Optional[TreeNode], minVal, maxVal) -> bool:
        if not node:
            return True
        if node.val <= minVal or node.val >= maxVal:
            return False

        return self.validateBST(node.left, minVal, node.val) and self.validateBST(node.right, node.val, maxVal) 
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        return self.validateBST(root, float('-inf'), float('inf'))

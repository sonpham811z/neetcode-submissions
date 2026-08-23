# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def buildTree(self, preorder: List[int], inorder: List[int]) -> Optional[TreeNode]:
        inorder_map = {val: idx for idx, val in enumerate(inorder)}
        
        # Con trỏ theo dõi node root hiện tại trong preorder
        self.pre_idx = 0

        def helper(in_left: int, in_right: int) -> Optional[TreeNode]:
            # Nếu không còn phần tử nào trong khoảng inorder hiện tại
            if in_left > in_right:
                return None

            # Lấy root hiện tại từ preorder
            root_val = preorder[self.pre_idx]
            self.pre_idx += 1
            root = TreeNode(root_val)

            # Lấy vị trí của root trong inorder
            mid = inorder_map[root_val]

            # QUAN TRỌNG: Phải dựng cây con TRÁI trước rồi mới đến PHẢI
            # vì preorder duyệt theo thứ tự: Root -> Left -> Right
            root.left = helper(in_left, mid - 1)
            root.right = helper(mid + 1, in_right)

            return root

        return helper(0, len(inorder) - 1)
        
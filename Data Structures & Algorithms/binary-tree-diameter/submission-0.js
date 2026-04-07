/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     constructor(val = 0, left = null, right = null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    /**
     * @param {TreeNode} root
     * @return {number}
     */
    diameterOfBinaryTree(root) {
        let res = 0
        
        const depth = (node) => {
            if(node === null)
                return 0
            
            // tính chiều sâu hai nhánh
            let left = depth(node.left)
            let right = depth(node.right)

            //Cập nhật đường kính
            res = Math.max(res, left+right)

            //return chiều sau của node
            return 1+Math.max(left,right)
        }

        depth(root)
        return res
        
    }
}

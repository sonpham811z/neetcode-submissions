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
     * @return {boolean}
     */
    isBalanced(root) {
        let res = 0
        let flag = true
        
        const depth = (node) => {
            if(node === null)
                return 0
            
            // tính chiều sâu hai nhánh
            let left = depth(node.left)
            let right = depth(node.right)

            //Cập nhật chênh lệch độ sâu
            res = Math.max(res, Math.abs(left-right))

            //return chiều sau của node
            return 1+Math.max(left,right)
        }

        depth(root)
        return res <= 1 ? true : false
    }
}

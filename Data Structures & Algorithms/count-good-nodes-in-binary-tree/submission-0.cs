/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        return DFS( root, root.val);
    }

    public int DFS(TreeNode node, int max)
    {
        if(node == null)
            return 0;
        int count = 0;

        if(node.val >= max)
        {
            count = 1;
            max = node.val;
        }

        count += DFS(node.left, max);
        count += DFS(node.right, max);

        return count; 
    }
}

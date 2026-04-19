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
    public List<int> RightSideView(TreeNode root) {
        var res = new List<int>();
        DFS(root, 0, res);

        return res;
    }

    public void DFS(TreeNode node, int level, List<int> res)
    {
        if(node == null)
            return;
        
        if(level == res.Count)
            res.Add(node.val);
        
        DFS(node.right, level + 1, res);
        DFS(node.left, level + 1, res);
    }
}

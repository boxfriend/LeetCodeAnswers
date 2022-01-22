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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        
        return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
    }
}
//Runtime: 176 ms, faster than 5.10%
//Memory Usage: 36.8 MB, less than 83.99%

public class Solution1 {
    public int MaxDepth(TreeNode root) => (root == null) ? 0 : 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
}
//Runtime: 113 ms, faster than 42.88%
//Memory Usage: 37 MB, less than 56.88%
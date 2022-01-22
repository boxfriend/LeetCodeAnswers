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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        if (p == null || q == null || p.val != q.val)
            return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
//Runtime: 165 ms, faster than 13.24%
//Memory Usage: 37.4 MB, less than 96.53%
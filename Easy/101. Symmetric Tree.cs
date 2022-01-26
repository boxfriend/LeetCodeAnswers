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
    public bool IsSymmetric(TreeNode root) {
        return IsSymmetric(root.left, root.right);
    }
    
    private bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if(left == null && right == null) return true;
        if(left == null || right == null || left.val != right.val) return false;
        
        return IsSymmetric(left.left,right.right) && IsSymmetric(left.right, right.left);
    }
}
//Runtime: 163 ms, faster than 18.17%
//Memory Usage: 38 MB, less than 86.65%
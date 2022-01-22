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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, long.MinValue, long.MaxValue);
    }
    
    private bool IsValid(TreeNode node, long min, long max)
    {
        if(node == null) return true;
        
        if(node.val <= min || node.val >= max)
            return false;
        
        return IsValid(node.left, min, node.val) && IsValid(node.right, node.val,max);
    }
}
//Runtime: 108 ms, faster than 52.06%
//Memory Usage: 41.3 MB, less than 49.69%
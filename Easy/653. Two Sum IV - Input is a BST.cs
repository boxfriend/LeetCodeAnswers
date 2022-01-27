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
    private HashSet<int> hash = new HashSet<int>();
    public bool FindTarget(TreeNode root, int k) {
        if(root == null) return false;
        
        if(hash.Contains(k-root.val)) return true;
        
        hash.Add(root.val);
                
        return FindTarget(root.left,k) || FindTarget(root.right,k);
    }
}
//Runtime: 192 ms, faster than 25.77%
//Memory Usage: 41.3 MB, less than 78.43%
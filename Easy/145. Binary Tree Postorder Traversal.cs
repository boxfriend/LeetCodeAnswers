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
    public IList<int> PostorderTraversal(TreeNode root) {
        var list = new List<int>();
        if(root == null) return list;
        
        Traverse(root, list);
        return list;
    }
    
    private void Traverse(TreeNode node, List<int> list)
    {
        if (node.left != null) Traverse(node.left, list);
        if (node.right != null) Traverse(node.right, list);    
        list.Add(node.val);
    }
}
//Runtime: 116 ms, faster than 93.35%
//Memory Usage: 40.6 MB, less than 15.08%
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
    public IList<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();
        if(root == null) return list;
        
        Traverse(root, list);
        return list;
    }
    
    private void Traverse(TreeNode node, List<int> list)
    {
        list.Add(node.val);
        if (node.left != null) Traverse(node.left, list);
        if (node.right != null) Traverse(node.right, list);    
    }
}
//Runtime: 132 ms, faster than 52.52%
//Memory Usage: 40.6 MB, less than 12.36%
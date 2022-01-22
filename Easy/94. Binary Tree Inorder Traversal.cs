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
    public IList<int> InorderTraversal(TreeNode root) {
        var list = new List<int>();
        if(root == null) return list;
        
        Traverse(root, list);
        return list;
    }
    
    private void Traverse(TreeNode node, List<int> list)
    {
        if (node.left != null) Traverse(node.left, list);
			
        list.Add(node.val);
        
        if (node.right != null) Traverse(node.right, list);    
    }
}
//Runtime: 231 ms, faster than 9.88%
//Memory Usage: 38.6 MB, less than 82.09%
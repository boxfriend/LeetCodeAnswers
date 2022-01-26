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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var list = new List<int>();
        AddToList(root1, list);
        AddToList(root2, list);
        list.Sort();
        return list;
    }
    
    private void AddToList(TreeNode node, List<int> list)
    {
        if(node == null) return;
        
        if(node.left != null) AddToList(node.left, list);
        list.Add(node.val);
        if(node.right != null) AddToList(node.right, list);
    }
}
//Runtime: 228 ms, faster than 87.78%
//Memory Usage: 49.3 MB, less than 33.33%
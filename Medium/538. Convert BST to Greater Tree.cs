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
    public TreeNode ConvertBST(TreeNode root) {       
        Traverse(root, 0);
        return root;
    }
    
    private int Traverse(TreeNode node, int sum)
    {
        if(node == null)
            return sum;
        
        sum = Traverse(node.right, sum);
        node.val += sum;
        sum = Traverse(node.left, node.val);
        return sum;
    }
}
//Runtime: 100 ms, faster than 90.91%
//Memory Usage: 44.8 MB, less than 9.09%
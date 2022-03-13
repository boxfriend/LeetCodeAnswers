/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        
        if(head == null)
            return null;
        if(k < 1)
            return head;
        
        var nodes = new List<ListNode>();
        var node = head;
        while(node != null)
        {
            nodes.Add(node);
            node = node.next;
        }
        
        if(nodes.Count <= 1)
            return head;
        
        k %= nodes.Count;
        if(k < 1)
            return head;
        
        for(var i = 1; i <= k; i++)
        {
            nodes[^i].next = i-1 == 0 ? nodes[0] : nodes[^(i-1)];
        }
        nodes[^(k+1)].next = null;
        
        return nodes[^k];
    }
}
//Runtime: 169 ms, faster than 12.71%
//Memory Usage: 38 MB, less than 36.02%
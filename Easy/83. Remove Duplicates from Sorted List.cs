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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        
        var node = head.next;
        var prevNode = head;
        
        while(node != null)
        {
            if(node.val == prevNode.val)
            {
                node = node.next;
                prevNode.next = null;
            }
            else
            {
                prevNode.next = node;
                prevNode = node;
                node = node.next;
            }
        }
        return head;
    }
}
//Runtime: 107 ms, faster than 37.97%
//Memory Usage: 36.9 MB, less than 77.31%
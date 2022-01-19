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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;
        
        var prevNode = head;
        var node = head.next;
        while(node.next != null)
        {
            var temp = node.next;
            node.next = prevNode;
            prevNode = node;
            node = temp;
        }
        head.next = null;
        node.next = prevNode;
        return node;
    }
}
//Runtime: 99 ms, faster than 44.09%
//Memory Usage: 36.7 MB, less than 77.72%
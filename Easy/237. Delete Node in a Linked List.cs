/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var current = node;
        var next = node.next;
        
        while(next.next != null)
        {
            current.val = next.val;
            current = next;
            next = next.next;
        }
        current.val = next.val;
        current.next = null;
        
    }
}
//Runtime: 160 ms, faster than 7.39%
//Memory Usage: 36.8 MB, less than 60.12%
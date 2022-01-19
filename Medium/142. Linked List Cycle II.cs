/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null) return null;
        
        var map = new HashSet<ListNode>();
        while(head.next != null)
        {
            map.Add(head);
            
            if(map.Contains(head.next))
                return head.next;
            
            head = head.next;
        }
        return null;
    }
}
//Runtime: 187 ms, faster than 9.23%
//Memory Usage: 38.7 MB, less than 59.80%
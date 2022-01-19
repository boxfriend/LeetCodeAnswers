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
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        
        var map = new HashSet<ListNode>();
        while(head.next != null)
        {
            map.Add(head);
            
            if(map.Contains(head.next))
                return true;
            
            head = head.next;
        }
        return false;
    }
}
//Runtime: 110 ms, faster than 48.83%
//Memory Usage: 42 MB, less than 58.27%
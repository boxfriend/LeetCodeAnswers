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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        if(list1 == null) return list2;
        if(list2 == null) return list1;
        
        ListNode head;
        if(list1.val < list2.val)
        {
            head = list1;
            list1 = list1.next;
        } else {
            head = list2;
            list2 = list2.next;
        }
        
        var node = head;
        while(list1 != null && list2 != null)
        {            
            if(list1.val < list2.val)
            {
                node.next = list1;
                node = list1;
                list1 = list1.next;
            } else {
                node.next = list2;
                node = list2;
                list2 = list2.next;
            }
        }
        
        if(list1 == null)
            node.next = list2;
        
        if(list2 == null)
            node.next = list1;
        
        
        return head;
    }
}
//Runtime: 158 ms, faster than 7.89%
//Memory Usage: 36.4 MB, less than 97.32%
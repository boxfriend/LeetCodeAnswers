/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var hash = new HashSet<ListNode>();
        while(headA != null)
        {
            hash.Add(headA);
            headA = headA.next;
        }
        
        while(headB != null)
        {
            if(hash.Contains(headB))
                return headB;
            
            headB = headB.next;
        }
        return null;
    }
}
//Runtime: 209 ms, faster than 25.02%
//Memory Usage: 45.5 MB, less than 23.60%


public class Solution1 {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var hashA = new HashSet<ListNode>();
        var hashB = new HashSet<ListNode>();
        while(headA != null || headB != null)
        {
            if(headA != null)
            {
                if(CheckMap(headA,hashA,hashB))
                    return headA;
                headA = headA.next;
            }
            if(headB != null)
            {
                if(CheckMap(headB,hashB,hashA))
                    return headB;
                headB = headB.next;
            }
        }
        
        return null;
    }
    
    private bool CheckMap(ListNode node, HashSet<ListNode> thisMap, HashSet<ListNode> otherMap)
    {
        thisMap.Add(node);
        return otherMap.Contains(node);
    }

//Runtime: 208 ms, faster than 25.31%
//Memory Usage: 45.7 MB, less than 18.77%
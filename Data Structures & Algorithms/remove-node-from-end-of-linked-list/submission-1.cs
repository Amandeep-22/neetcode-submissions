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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode start = null;
        ListNode end = head;

        if(head.next==null)
        {
            return null;
        }


        while(n!=1)
        {
            end = end.next;
            n--;
        }

        while(end.next!=null)
        {
            if(start==null)
            {
                start=head;
            }
            else
            {
                start = start.next;
            }
            end = end.next;
        }

        if(start==null)
        {
            return head.next;
        }
        ListNode del = start.next;
        start.next = del.next;
        return head;
        
    }
}

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
    public ListNode MergeKLists(ListNode[] lists) {
        
        int n = lists.Length;
        if(n==0 || (n==1 && lists[0]==null))
        {
            return null;
        }
        ListNode head = lists[0];
        for(int i = 1; i<n ; i++)
        {
            head = MergeTwoLists(head,lists[i]);
        }
        return head;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    
        if(list1==null)
        {
            return list2;
        }
        if(list2==null)
        {
            return list1;
        }

        ListNode head = null;
        if(list1.val<=list2.val)
        {
            head = list1;
            list1 = list1.next;
        }
        else if(list2.val<list1.val)
        {
            head = list2;
            list2 = list2.next;
        }

        ListNode ptr = head;

        while(list1!=null && list2!=null)
        {
            if(list1.val<=list2.val)
            {
                ptr.next = list1;
                list1=list1.next;
            }
            else if(list2.val<list1.val)
            {
                ptr.next = list2;
                list2=list2.next;
            }
            ptr = ptr.next;
        }

        if(list1!=null)
        {
            ptr.next = list1;
        }
        if(list2!=null)
        {
            ptr.next = list2;
        }
        return head;
    }
}

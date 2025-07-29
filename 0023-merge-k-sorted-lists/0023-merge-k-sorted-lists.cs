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

        var q = new PriorityQueue<ListNode,int>();
        foreach(var list in lists)
        {
            if(list != null)
                q.Enqueue(list,list.val);
        }
        ListNode head = new ListNode();
        ListNode curr = head;
        while(q.Count >0)
        {
            ListNode min = q.Dequeue();
            curr.next =min;
            curr =min;
            if(min.next != null)
            
                q.Enqueue(min.next,min.next.val);
            
            
        }
     
          return head.next;
        }
    }

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
    public ListNode SwapPairs(ListNode head) {

        if(head is  null ) return null;
        if(head.next is null ) return head;

        ListNode temp = head;      // 1st node  
        head = head.next;          // new head becomes 2nd node
        temp.next= head.next;      // 1 -> 3
        head.next = temp;           // 2 -> 1 

        ListNode current =temp;  // start from node after swapped pair

        while(current.next != null && current.next.next != null)
        {
            temp = current.next;               // 3
            current.next = current.next.next;  // 1 -> 4
            temp.next = current.next.next;     // 3 -> 5
            current.next.next = temp;          // 4 -> 3
                  
            current = temp;                    // move forward
        }
       return head;

        
    }
}
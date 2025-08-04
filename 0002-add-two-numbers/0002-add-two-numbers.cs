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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    
        var node = DfsTraversal(l1,l2,0);
        return node;
    }

    private ListNode DfsTraversal(ListNode l1,ListNode l2,int carry)
    {
        int sum = carry;

        if(l1 == null && l2 ==null)
        {
            if(sum!=0)
            {
                return new ListNode(1);
            }
            else
            {
                return null;
            }
        }

        if(l1 != null)
        {
            sum +=l1.val;
        }
        if(l2 != null)
        {
            sum += l2.val;
        }

       
    
     var node = new ListNode(sum % 10);
     node.next = DfsTraversal(l1?.next, l2?.next, sum / 10);
     
        return node;
    }
    
}
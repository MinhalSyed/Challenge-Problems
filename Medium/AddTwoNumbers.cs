//https://leetcode.com/problems/add-two-numbers/solution/
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
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode head = new ListNode();
        ListNode current = head;
        ListNode prev = null;
        
       
        while(l1 != null || l2 != null)
        {
            int remainder = 0;

            int s = AddTwoNumbers(l1?.val??0, l2?.val??0, current.val, out remainder);

            current.val = s;    
            current.next = new ListNode(remainder);           

            l1 = l1?.next;
            l2 = l2?.next;

            prev = current;
            current = current.next;
        }
        
        if(current.val == 0)
        {
            prev.next = null;
            current = null;
        }
        
        return head;
    }
    
    private int AddTwoNumbers(int l1, int l2, int current, out int remainder)
    {
        if( (l1 + l2 + current) > 9)
        {
            remainder = 1;
            return (l1 + l2 + current) % 10;
        }
        else
        {
            remainder = 0;
            return l1 + l2 + current;
        }
    }
}

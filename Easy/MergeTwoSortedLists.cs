//https://leetcode.com/explore/interview/card/top-interview-questions-easy/93/linked-list/771/
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode headDummy = new ListNode();
        
        ListNode currentNode = headDummy;
        
        while (l1 != null || l2 != null)
        {
            if(l1 == null)
            {
                currentNode.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            else if(l2 == null)
            {
                currentNode.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else if((l1.val) < (l2.val))
            {
                currentNode.next = new ListNode(l1.val);
                l1 = l1.next;
            }
            else
            {
                currentNode.next = new ListNode(l2.val);
                l2 = l2.next;
            }
            
            currentNode = currentNode.next;
        }
        
        
        return headDummy.next;
    }
}
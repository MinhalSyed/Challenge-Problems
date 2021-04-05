//https://leetcode.com/problems/reverse-linked-list/solution/

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
    public ListNode ReverseList(ListNode head) {
        
        ListNode currentNode = head;
        ListNode previousNode = null;
        
        while(currentNode != null)
        {
            var temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        
        return previousNode;
    }
}
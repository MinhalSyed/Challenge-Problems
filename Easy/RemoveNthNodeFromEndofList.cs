//https://leetcode.com/problems/remove-nth-node-from-end-of-list/solution/

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
        
        Stack<ListNode> stack = new Stack<ListNode>();
        
        ListNode ptr = head;
        
        while(ptr != null)
        {
            stack.Push(ptr);
            ptr = ptr.next;
        }
        
        ListNode nodeToRemove = null;
        ListNode nodeToRemovePrevious = null;

            
        for(int i = 1; i <= n; i++)
        {
            if(stack.Count > 0)
            {
                nodeToRemove = stack.Pop();    
            }
        }
        
        if(stack.Count > 0)
        {
            nodeToRemovePrevious  = stack.Pop();    
        }
        
        if(nodeToRemovePrevious != null)
        {
            nodeToRemovePrevious.next = nodeToRemove.next;
            nodeToRemove.val = 0;
            nodeToRemove.next = null;
            nodeToRemove = null;
        }
        
        else if (nodeToRemove != null)
        {
            head = nodeToRemove.next;
            nodeToRemove.val = 0;
            nodeToRemove.next = null;
            nodeToRemove = null;
        }
        
        return head;
    }
}
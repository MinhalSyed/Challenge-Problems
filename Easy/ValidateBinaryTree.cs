/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
               
        return isValidBST(root, null, null);
    }
    
    private bool isValidBST(TreeNode node, int? max, int? min){
        if(node == null)
        {
            return true;
        }
        
        if ((max.HasValue && node.val >= max.Value) ||
            (min.HasValue && node.val <= min.Value))
        {
            return false;
        }
        
        
        return isValidBST(node.left, node.val, min) && isValidBST(node.right, max, node.val);

    }
}
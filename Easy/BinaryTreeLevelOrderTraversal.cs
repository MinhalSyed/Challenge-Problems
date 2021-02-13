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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        IList<IList<int>> result = new List<IList<int>>();
        
        if(root == null){
            return result;
        }       
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);       
       
        var list = new List<int>();
        
        while(queue.Count() > 0)
        {
            int queueSize = queue.Count();
            
            list = new List<int>();
            
            for(int i =0; i < queueSize; i++)
            {
                var queueItem = queue.Dequeue();
                
                var currentNode = queueItem;
                
                if(currentNode.val != null)
                {
                    list.Add(currentNode.val);    
                }

                if(currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if(currentNode.right != null){
                    queue.Enqueue(currentNode.right);
                }         
            }
            
            if(list.Count() > 0)
            {
                result.Add(list);
            }
        }
        
        return result;
    }
}
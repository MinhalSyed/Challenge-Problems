# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sortedArrayToBST(self, nums: List[int]) -> Optional[TreeNode]:
        
        if nums == None:
            return None
        
        if nums == []:
            return None
        
        if len(nums) == 1:
            return TreeNode(nums[0])
        
        mid_index = len(nums) // 2
        
        left = nums[:mid_index]
        
        right = nums[mid_index+1:]
        
        return TreeNode(nums[mid_index], self.sortedArrayToBST(left), self.sortedArrayToBST(right))

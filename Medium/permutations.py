# https://leetcode.com/problems/permutations/submissions/
class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:

        if(len(nums) < 1):
            return
        
        return self.permute_recursive(nums)
        
    
    def permute_recursive(self, nums):
        
        if len(nums) == 1:
            return [nums]
        
        if len(nums) > 1:
            return self.join_array(nums[0], self.permute_recursive(nums[1:]))
        
        
    def join_array(self, elem, array_of_arrays):
        new_array = []
        for array in array_of_arrays:
            for i in range(0, len(array) + 1):
                array_copy = array.copy()
                array_copy.insert(i, elem)
                new_array.append(array_copy)
        return new_array

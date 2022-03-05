class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
                
        num_dict = {}
        
        for index, value in enumerate(nums):
            if value in num_dict:
                num_dict[value].append(index)
            else:
                num_dict[value] = [index]
                
        for index1, num1 in enumerate(nums):
            diff = target - num1
            if diff in num_dict:
                for index2 in num_dict[diff]:
                    if index2 != index1:
                        return [index1,index2]

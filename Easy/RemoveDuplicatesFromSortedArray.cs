//https://leetcode.com/problems/remove-duplicates-from-sorted-array/solution/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Count() <= 0){
            return 0;
        }
        int i = 0;
        for(int j = 1; j < nums.Count(); j++)
        {
            if(nums[i] != nums[j]){
                nums[i+1] = nums[j];
                i++;
            }
        }
        return i + 1;
    }
}
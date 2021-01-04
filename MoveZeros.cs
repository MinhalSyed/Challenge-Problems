//https://leetcode.com/problems/move-zeroes/solution/

public class Solution {
    
    public void MoveZeroes(int[] nums) {
               
        int j = 0;
               
        for(int i = 0 ; i < nums.Count(); i++){
            if(nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;
            }
        }
        
        while(j < nums.Count()){
            nums[j] = 0;
            j++;
        }
    }
}
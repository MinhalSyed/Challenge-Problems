//https://leetcode.com/problems/rotate-array/solution/

public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Count();
        
        ReverseArray(0, nums.Count()-1, nums);
        ReverseArray(0, k-1, nums);
        ReverseArray(k,nums.Count()-1 , nums);
    }
    
    private void ReverseArray(int startIndex, int endIndex, int[] nums)
    {
        while(startIndex < endIndex)
        {
            int temp = nums[startIndex];
            nums[startIndex] = nums[endIndex];
            nums[endIndex] = temp;
            startIndex++;
            endIndex--;
        }
    }
}
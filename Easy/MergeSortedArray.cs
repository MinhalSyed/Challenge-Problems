/*
 I'm stupid.
 Just start at the end of nums1. :facepalm:
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        Rotate(nums1, n);
        
        int i = n;
        int j = 0;
        
        int ii = 0;
        
        while (ii < m+n && j < n && i < m + n)
        {
            if(nums1[i] <= nums2[j])
            {
                nums1[ii] = nums1[i];
                i++;
            }
            else
            {
                nums1[ii] = nums2[j];
                j++;
            }
            
            ii++;
        }
        
        while(ii < m+n){
            
            if(i >= m+n)
            {
                nums1[ii] = nums2[j];
                
                j++;
            }
            else if (j >= n)
            {
                nums1[ii] = nums1[i];
                i++;
            }
            
            ii++;
        }
        
    }
    
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
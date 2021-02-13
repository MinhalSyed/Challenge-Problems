public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int i = m - 1;
        
        int j = n - 1;
        
        int ii = m + n - 1;
        
        while(i >= 0 && j >= 0)
        {
            if(nums1[i] >= nums2[j])
            {
                nums1[ii] = nums1[i];
                i--;
            }
            else
            {
                nums1[ii] = nums2[j];
                j--;
            }
            
            ii--;
        }
        
        while(ii >=0 ){
            
            if(i < 0)
            {
                nums1[ii] = nums2[j];
                j--;
            }
            
            else if (j < 0)
            {
                nums1[ii] = nums1[i];
                i--;
            }
            
            ii--;
        }
    }
}
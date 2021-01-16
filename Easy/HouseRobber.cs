//Recursive Solution:
// Fails with [114,117,207,117,235,82,90,67,143,146,53,108,200,91,80,223,58,170,110,236,81,90,222,160,165,195,187,199,114,235,197,187,69,129,64,214,228,78,188,67,205,94,205,169,241,202,144,240]
public class Solution {
    public int Rob(int[] nums) {
        int N = nums.Count();
        return MaxRobSum(0, N-1, nums);
    }
    
    private int MaxRobSum(int start, int end, int [] nums)
    {
        if(start == end){
            return nums[start];
        }
        
        if(start > end){
            return 0;
        }
        
        return Math.Max(nums[start] + MaxRobSum(start+2, end, nums), MaxRobSum(start+1, end, nums));
    }
}

//Dynamic Programming Solution:
public class Solution {
    public int Rob(int[] nums) {
        int N = nums.Count();
        
        if (N <= 0){
            return 0;
        }
        
        int[] MaxRobSum = new int[N];
        
        for(int i = 0; i < N; i++){
            if(i == 0)
            {
                MaxRobSum[i] = nums[i];
            }
            else if(i == 1)
            {
                MaxRobSum[i] = Math.Max(MaxRobSum[i-1], nums[i]);
            }
            else
            {
                MaxRobSum[i] = Math.Max(MaxRobSum[i-1], nums[i] + MaxRobSum[i-2]);    
            }          
        }
        
        return MaxRobSum[N-1];
    }
}
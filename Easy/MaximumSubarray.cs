//https://leetcode.com/explore/interview/card/top-interview-questions-easy/97/dynamic-programming/566/

public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int N = nums.Count();
        int[,] Sum = new int[N, N];
        
        for(int i = 0; i < N; i++){
            for(int j = i; j < N; j++){
                if(i == j){
                    Sum[i,j] = nums[i];
                }
                else
                {
                    Sum[i,j] = nums[j] + Sum[i,j-1];
                }
                
                if(Sum[i,j] > maxSum){
                    maxSum = Sum[i,j];
                }
            }
        }
        
        return maxSum;
        
    }
}
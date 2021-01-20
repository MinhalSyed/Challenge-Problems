//This solution runs out of memory
public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProf = 0;
        
        int N = prices.Count();
        
        int[,] DP = new int[N,N];
        
        for(int i =0; i < N -1 ; i++)
        {
            for(int j = i + 1; j < N; j++)
            {
                DP[i,j] = prices[j] - prices[i];
                
                if(DP[i,j] > maxProf)
                {
                    maxProf = DP[i,j];
                }
            }
        }
        
        return maxProf;
    }
}


//correct solution:
// https://leetcode.com/explore/interview/card/top-interview-questions-easy/97/dynamic-programming/572/
public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProf = 0;
        
        int N = prices.Count();
        
        int minValue = prices[0];
        
        for(int i =1; i < N; i++)
        {
            if(prices[i] < minValue)
            {
                minValue = prices[i];
            }
            else if(prices[i] - minValue > maxProf)
            {
                maxProf = prices[i] - minValue;
            }
                
        }
        
        return maxProf;
    }
}
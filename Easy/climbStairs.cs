public class Solution {
    public int ClimbStairs(int n) {
        
        int previous2stepsTotal  = 0;
        int previousStepTotal = 0;
        
        int answer = 0;
        
        for(int i = 1; i <= n; i++)
        {
            if(i == 1)
            {
                answer = 1;
                previousStepTotal = 1;
            }
            else if(i == 2)
            {
                answer = 2;
                previous2stepsTotal = previousStepTotal;
                previousStepTotal = 2;
            }
            else
            {
                answer = previous2stepsTotal + previousStepTotal;
                previous2stepsTotal = previousStepTotal;
                previousStepTotal = answer;    
            }
        }
        
        
        return answer;
    }
}
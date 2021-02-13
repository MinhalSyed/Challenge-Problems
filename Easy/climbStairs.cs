public class Solution {
    public int ClimbStairs(int n) {
        
        int [] dp = new int[n+1];

        for(int i = 1; i < n; i ++){
            if(i == 1){

            }
        }


        return climb(n);
    }

    private int climb(int n)
    {
        if(n < 1)
        {
            return 0;
        }

        if (n == 1){
            return 1;
        }
        if (n == 2){
            return 2;
        }

        return climb(n-1) + climb(n-2);

    }


}
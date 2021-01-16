//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/559/
//Solution: Plus 1

public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        var j = digits.Count() - 1;

        Increment(ref digits, j);    
       
        return digits;
    }
    
    private void Increment(ref int[] digits, int index){
        
        if(index < 0){
            //Meaning we need more space.
            
            int[] newArray = new int[digits.Count() + 1];
            
            newArray[0] = 1;
            
            digits = newArray;
            
            return;
        }
        
        if(digits[index] == 9)
        {
            digits[index] = 0;
            Increment(ref digits, index -1);
        }
        else
        {
            digits[index] += 1;
        }

    }
}
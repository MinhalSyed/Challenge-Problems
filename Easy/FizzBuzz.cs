public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        var returnedVal = new List<string>();
        
        for(int i = 1; i<=n; i++)
        {
            
            string result = "";
            
            if(i % 3 == 0)
            {
                result += "Fizz";
            }
            if(i % 5 == 0)
            {
                result += "Buzz";
            }
            
            if(string.IsNullOrWhiteSpace(result))
            {
                result =  i.ToString();
            }
            
            returnedVal.Add(result);
        }
        
        return returnedVal;
    }
}
//https://leetcode.com/problems/two-sum/solution/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] answer = new int[2];
        
        var numberDictionary = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Count(); i++){
            var difference = target - nums[i];
            
            if(numberDictionary.ContainsKey(difference))
            {
                answer[0] = i;
                answer[1] = numberDictionary[difference];
            }
            else
            {
                numberDictionary.Add(nums[i], i);
            }
        }
        
        return answer;
    }
}
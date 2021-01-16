
//https://leetcode.com/problems/contains-duplicate/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var duplicates = new Dictionary<int,int>();
        
        foreach(var item in nums){
            
            if(!duplicates.ContainsKey(item)){
                duplicates.Add(item, 1);
            }
            else
            {
                return true;
            }
        }
        
        return false;
    }
}
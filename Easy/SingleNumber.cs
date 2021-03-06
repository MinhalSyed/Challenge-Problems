//https://leetcode.com/problems/single-number/solution/
//Solution #4: uses XOR bit manipulation and is T:O(n) and S:O(1);
public class Solution {
    public int SingleNumber(int[] nums) {
        var numsCount = new Dictionary<int,int>();
        
        foreach(var item in nums){
            if(!numsCount.ContainsKey(item)){
                numsCount.Add(item, 1);
            }
            else{
                numsCount[item] = numsCount[item] + 1;
            }
        }
        
        return numsCount.FirstOrDefault(nc => nc.Value == 1 ).Key;
    }
}

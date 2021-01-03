//https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/674/
//Intersection of Two Arrays II

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        var result = new List<int>();
        
        var nums2Dict = new Dictionary<int, int>();
        
        
        foreach(var item in nums2)
        {
            if(!nums2Dict.ContainsKey(item)){
                nums2Dict.Add(item, 1);
            }
            else
            {
                nums2Dict[item] += 1;
            }
        }
        
        
        foreach(var item in nums1){
            
            if(nums2Dict.ContainsKey(item))
            {
                result.Add(item);
                
                nums2Dict[item] -= 1;
                
                if(nums2Dict[item] == 0){
                    nums2Dict.Remove(item);
                }
            }
        }
        
        return result.ToArray();
    }
}
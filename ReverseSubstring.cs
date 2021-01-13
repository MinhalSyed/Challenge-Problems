//https://leetcode.com/problems/reverse-string/solution/

public class Solution {
    public void ReverseString(char[] s) {
        int i = 0;
        int j = s.Count() - 1;
        
        while(i < j)
        {
            var temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }
}
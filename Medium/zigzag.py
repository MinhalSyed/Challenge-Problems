# https://leetcode.com/problems/zigzag-conversion/solution/
class Solution:
    def is_first_or_last_row(self, row_index, numRows):
        return row_index == 0 or row_index == numRows -1
    
    def convert(self, s: str, numRows: int) -> str:
        if(numRows) < 1:
            return None
        if(numRows) == 1:
            return s
        
        length = len(s)
        
        if(numRows >= length):
            return s

        result_str_array = []
        
        for i in range(0, numRows):
            index = i           
            while(index < length):
                result_str_array.append(s[index])
                
                index += (numRows-1) * 2
                
                if(not self.is_first_or_last_row(i, numRows)):
                    previous_char_index = index - 2 * i
                    if(previous_char_index > numRows -1 and previous_char_index < length):
                        result_str_array.append(s[previous_char_index])
        
        return ''.join(result_str_array)

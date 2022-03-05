# The isBadVersion API is already defined for you.
# def isBadVersion(version: int) -> bool:

import sys


class Solution:
    def firstBadVersion(self, n: int) -> int:
        first_bad_version = self.find(1,n)
        if(first_bad_version <= n):
            return first_bad_version
        return 0
        
    def find(self, first_version, last_version):
        
        if( first_version > last_version ):
            return sys.maxsize

        if(first_version == last_version):
            if (isBadVersion(first_version)):
                return first_version
            else:
                return sys.maxsize
        
        mid = (last_version - first_version) // 2
        
        mid_version = first_version + mid
        
        if(isBadVersion(mid_version)):
            return min(mid_version, self.find(first_version, mid_version - 1)) 
        else:
            return self.find(mid_version + 1, last_version)

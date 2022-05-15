# https://leetcode.com/problems/k-closest-points-to-origin/
from queue import PriorityQueue

class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
              
        queue = PriorityQueue()
        
        for index, (x,y) in enumerate(points):
            queue.put((x**2 + y**2, index))
        
        closest_k_points = []
        
        while not queue.empty() and len(closest_k_points) < k:
            closest_point_distance, closest_point_index = queue.get()
            closest_k_points.append(points[closest_point_index])
        
        return closest_k_points

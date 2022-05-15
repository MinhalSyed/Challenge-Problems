# https://leetcode.com/problems/k-closest-points-to-origin/
from queue import PriorityQueue

class Solution:
    def kClosest(self, points: List[List[int]], k: int) -> List[List[int]]:
        distance_squared = [x**2 + y**2 for x, y in points]
               
        queue = PriorityQueue()
        
        for index, distance in enumerate(distance_squared):
            queue.put((distance, index))
        
        closest_k_points = []
        
        while not queue.empty() and len(closest_k_points) < k:
            distance_point, closest_point_index = queue.get()
            closest_k_points.append(points[closest_point_index])
        
        return closest_k_points

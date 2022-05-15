# https://leetcode.com/problems/number-of-islands/
from queue import Queue

class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        visited = set()
        
        num_of_islands = 0
        
        for i in range(0, len(grid)):
            for j in range(0, len(grid[0])):
                if (i, j) not in visited and grid[i][j] == "1":
                    self.bfs(i, j, visited, grid)
                    num_of_islands += 1
                    
        return num_of_islands
     
    def bfs(self, i, j, visited, grid):
        
        directions = [(0,1),(1,0),(0,-1),(-1,0)]
        
        queue = Queue()
        
        queue.put((i,j))
        
        while not queue.empty():
            
            i, j = queue.get()
            
            visited.add((i,j))
        
            for x_diff, y_diff in directions:

                new_x = i + x_diff
                new_y = j + y_diff
                
                if(new_x < len(grid) and new_y < len(grid[0]) and
                   new_x >= 0 and new_y >=0 ):

                    if (new_x, new_y) not in visited:

                        visited.add((new_x, new_y))

                        if(grid[new_x][new_y] == "1"):
                            queue.put((new_x, new_y))
                    
